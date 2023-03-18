using InteractiveCrm.Core;
using McTools.Xrm.Connection;
using Microsoft.Xrm.Sdk;
using System;
using System.Windows.Forms;
using XrmToolBox.Extensibility;

namespace InteractiveCrm
{
    public partial class InteractiveCrmPluginControl : PluginControlBase
    {
        private Settings mySettings;
        private CodeManager _codeManager;
        private CodeRunner _codeRunner;
        private DiagnosticManager _diagnosticManager;
        private ControlWriter _outputConsoleWriter;
        private ControlWriter _logWriter;

        public InteractiveCrmPluginControl()
        {
            InitializeComponent();
            SetupAutocompleteMenu();
        }

        private void MyPluginControl_Load(object sender, EventArgs e)
        {
            ShowInfoNotification("This is a notification that can lead to XrmToolBox repository", new Uri("https://github.com/MscrmTools/XrmToolBox"));

            // Loads or creates the settings for the plugin
            if (!SettingsManager.Instance.TryLoad(GetType(), out mySettings))
            {
                mySettings = new Settings();

                LogWarning("Settings not found => a new settings file has been created!");
            }
            else
            {
                LogInfo("Settings found and loaded");
            }
            
            _codeManager = CodeManager.Create();
            _diagnosticManager = new DiagnosticManager(this.diagnosticViewModelBindingSource);
            _outputConsoleWriter = new ControlWriter(consoleOutEmulator);
            _logWriter = new ControlWriter(logTextBox);

            _codeRunner = new CodeRunner(
                _codeManager, 
                new EntryPointResolver(), 
                _diagnosticManager,
                _outputConsoleWriter,
                _logWriter
            );

            var codeInitializer = new CodeInitializer();
            mainCodeInput.Text = codeInitializer.GetInitialCode();
        }

        private void executeCodeButton_Click(object sender, EventArgs e)
        {
            // The ExecuteMethod method handles connecting to an
            // organization if XrmToolBox is not yet connected
            // ExecuteMethod(GetAccounts);
            ExecuteMethod(ExecuteCode);
        }

        private void mainCodeInput_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F5)
            {
                ExecuteMethod(ExecuteCode);
            }
        }

        private void ExecuteCode()
        {
            _codeManager.UpdateSourceFile(mainCodeInput.Text);
            _outputConsoleWriter.Clear();

            try
            {
                _codeRunner.Run(Service);
            }
            catch(Exception ex)
            {
                ShowErrorDialog(ex, "An exception occured");
            }

            infoTabs.SelectTab(consoleTab);
            mainCodeInput.Focus();
        }

        /// <summary>
        /// This event occurs when the plugin is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyPluginControl_OnCloseTool(object sender, EventArgs e)
        {
            // Before leaving, save the settings
            SettingsManager.Instance.Save(GetType(), mySettings);
        }

        /// <summary>
        /// This event occurs when the connection has been updated in XrmToolBox
        /// </summary>
        public override void UpdateConnection(IOrganizationService newService, ConnectionDetail detail, string actionName, object parameter)
        {
            base.UpdateConnection(newService, detail, actionName, parameter);

            if (mySettings != null && detail != null)
            {
                mySettings.LastUsedOrganizationWebappUrl = detail.WebApplicationUrl;
                LogInfo("Connection has changed to: {0}", detail.WebApplicationUrl);
            }
        }

        private void mainCodeInput_TextChanged(object sender, KeyPressEventArgs e)
        {
            _codeManager.UpdateSourceFile(mainCodeInput.Text);

            var autocompleteList = _codeManager.UpdateAutocompleteList(mainCodeInput.SelectionStart);
            mainCodeInputAutoCompleteMenu.Items.SetAutocompleteItems(autocompleteList);
            mainCodeInputAutoCompleteMenu.MinFragmentLength = e.KeyChar == '.' ? 0 : 1; // TODO centralize setting
        }

        private void diagnosticsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Move cursor to diagnostic location 
            var diagnostic = _diagnosticManager.GetDiagnostic(e.RowIndex);
            mainCodeInput.SelectionStart = diagnostic.Location.SourceSpan.Start;
            mainCodeInput.Focus();
        }

    }
}