using InteractiveCrm.Core;
using McTools.Xrm.Connection;
using Microsoft.Xrm.Sdk;
using System;
using System.IO;
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
        }

        private void MyPluginControl_Load(object sender, EventArgs e)
        {
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

            AddDockContent(_codeManager);

            _diagnosticManager = new DiagnosticManager(tabsDockedContent.GetDiagnosticSource());

            _outputConsoleWriter = tabsDockedContent.GetConsoleWriter();
            _logWriter = tabsDockedContent.GetLogWriter();

            _codeRunner = new CodeRunner(
                _codeManager, 
                new EntryPointResolver(), 
                _diagnosticManager,
                _outputConsoleWriter,
                _logWriter
            );

            var codeInitializer = new CodeInitializer();
            codeEditorDockedContent.mainCodeInput.Text = codeInitializer.GetInitialCode();
            codeEditorDockedContent.mainCodeInput.KeyDown += InteractiveCrmPluginControl_KeyDown;
        }

        private void executeCodeButton_Click(object sender, EventArgs e)
        {
            // The ExecuteMethod method handles connecting to an
            // organization if XrmToolBox is not yet connected
            // ExecuteMethod(GetAccounts);
            ExecuteMethod(ExecuteCode);
        }

        private void InteractiveCrmPluginControl_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F5)
            {
                ExecuteMethod(ExecuteCode);
            }
        }

        private void ExecuteCode()
        {
            _codeManager.UpdateSourceFile(codeEditorDockedContent.mainCodeInput.Text);
            _outputConsoleWriter.Clear();

            try
            {
                _codeRunner.Run(Service);
            }
            catch(Exception ex)
            {
                ShowErrorDialog(ex, "An exception occured");
            }

            tabsDockedContent.SelectConsoleTab();
            codeEditorDockedContent.mainCodeInput.Focus();
        }

        private void diagnosticsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // TEMP
            // TODO FIND WAY TO HANDLE DOCKED CONTENT BETTER
            // Move cursor to diagnostic location 
            var diagnostic = _diagnosticManager.GetDiagnostic(e.RowIndex);
            codeEditorDockedContent.mainCodeInput.SelectionStart = diagnostic.Location.SourceSpan.Start;
            codeEditorDockedContent.mainCodeInput.Focus();
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

        private void saveFileButton_Click(object sender, EventArgs e)
        {
            using(SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "C# File (*.cs)|*.cs|All Files (*.*)|*.*";
                saveFileDialog.Title = "Save File As";
                saveFileDialog.CheckFileExists = false;
                saveFileDialog.AddExtension = true;
                saveFileDialog.DefaultExt = "cs";
                saveFileDialog.SupportMultiDottedExtensions = true;

                if(saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    var sourceText = codeEditorDockedContent.mainCodeInput.Text;
                    File.WriteAllText(filePath, sourceText);
                }
            }
        }
    }
}