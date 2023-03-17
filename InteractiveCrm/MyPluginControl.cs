using InteractiveCrm.Core;
using McTools.Xrm.Connection;
using Microsoft.CodeAnalysis.Completion;
using Microsoft.Xrm.Sdk;
using System;
using System.Linq;
using System.Windows.Forms;
using XrmToolBox.Extensibility;

namespace InteractiveCrm
{
    public partial class InteractiveCrmPluginControl : PluginControlBase
    {
        private Settings mySettings;
        private CodeManager _codeManager;
        private CodeRunner _codeRunner;

        public InteractiveCrmPluginControl()
        {
            InitializeComponent();
            _codeManager = CodeManager.Create();

            string code = @"using System;
using Microsoft.Xrm.Sdk;
using Microsoft.Crm.Sdk.Messages;

class MainClass {
   public static void Execute(IOrganizationService service){
      Console.WriteLine(""Ciao"");
      var test = 2;
      Console.WriteLine(test);

      var request  = new WhoAmIRequest();
      var response = (WhoAmIResponse) service.Execute(request);
      Console.WriteLine(response.UserId);
   }
}";
            mainCodeInput.Text = code;

            _codeRunner = new CodeRunner(
                _codeManager, 
                new EntryPointResolver(), 
                new ControlWriter(consoleOutEmulator),
                diagnosticViewModelBindingSource
            );
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
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            CloseTool();
        }

        private void tsbSample_Click(object sender, EventArgs e)
        {
            // The ExecuteMethod method handles connecting to an
            // organization if XrmToolBox is not yet connected
            // ExecuteMethod(GetAccounts);
            ExecuteMethod(ExecuteCode);
        }

        private void ExecuteCode()
        {
            _codeManager.UpdateSourceFile(mainCodeInput.Text);
            _codeRunner.Run(Service);

            consoleOutEmulator.Focus();
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

            var completitionService = CompletionService.GetService(_codeManager.SourceDocument);
            var resultsTask = completitionService.GetCompletionsAsync(_codeManager.SourceDocument, mainCodeInput.SelectionStart);
            resultsTask.Wait();
            var autocompleteItems = resultsTask.Result.ItemsList
                .Select(x => x.DisplayText)
                .ToArray();

            mainCodeInputAutoCompleteMenu.Items.SetAutocompleteItems(autocompleteItems);
            mainCodeInputAutoCompleteMenu.MinFragmentLength = e.KeyChar == '.' ? 0 : 1;
        }
    }
}