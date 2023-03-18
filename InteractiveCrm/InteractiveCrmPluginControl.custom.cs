using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeifenLuo.WinFormsUI.Docking;

namespace InteractiveCrm
{
    public partial class InteractiveCrmPluginControl
    {
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

        private FastColoredTextBoxNS.AutocompleteMenu mainCodeInputAutoCompleteMenu;
        private DockPanel dockPanel;
    }
}
