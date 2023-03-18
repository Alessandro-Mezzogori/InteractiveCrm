using InteractiveCrm.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace InteractiveCrm.Controls
{
    public partial class CodeEditorDockedContent : DockContent
    {
        private readonly CodeManager _codeManager;
        public FastColoredTextBoxNS.AutocompleteMenu mainCodeInputAutoCompleteMenu;

        public CodeEditorDockedContent(CodeManager codeManager)
        {
            _codeManager = codeManager;

            InitializeComponent();
            SetupAutocompleteMenu();
        }

        public void SetupAutocompleteMenu()
        {
            // 
            // mainCodeInputAutoCompleteMenu
            // 
            mainCodeInputAutoCompleteMenu = new FastColoredTextBoxNS.AutocompleteMenu(mainCodeInput);
            mainCodeInputAutoCompleteMenu.AllowTabKey = false;
            mainCodeInputAutoCompleteMenu.AlwaysShowTooltip = false;
            mainCodeInputAutoCompleteMenu.AppearInterval = 500;
            mainCodeInputAutoCompleteMenu.AutoClose = false;
            mainCodeInputAutoCompleteMenu.AutoSize = false;
            mainCodeInputAutoCompleteMenu.BackColor = System.Drawing.Color.White;
            mainCodeInputAutoCompleteMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            mainCodeInputAutoCompleteMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            mainCodeInputAutoCompleteMenu.MaxTooltipSize = new System.Drawing.Size(0, 0);
            mainCodeInputAutoCompleteMenu.MinFragmentLength = 1;
            mainCodeInputAutoCompleteMenu.Name = "mainCodeInputAutoCompleteMenu";
            mainCodeInputAutoCompleteMenu.Padding = new System.Windows.Forms.Padding(0);
            mainCodeInputAutoCompleteMenu.SearchPattern = "[\\w]";
            mainCodeInputAutoCompleteMenu.Size = new System.Drawing.Size(154, 154);
            mainCodeInputAutoCompleteMenu.ToolTipDuration = 3000;
        }

        private void mainCodeInput_KeyPressed(object sender, KeyPressEventArgs e)
        {
            _codeManager.UpdateSourceFile(mainCodeInput.Text);

            var autocompleteList = _codeManager.UpdateAutocompleteList(mainCodeInput.SelectionStart);
            mainCodeInputAutoCompleteMenu.Items.SetAutocompleteItems(autocompleteList);
            mainCodeInputAutoCompleteMenu.MinFragmentLength = e.KeyChar == '.' ? 0 : 1; // TODO centralize setting
        }
    }
}
