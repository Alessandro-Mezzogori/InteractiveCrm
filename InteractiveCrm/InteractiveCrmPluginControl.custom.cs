using InteractiveCrm.Controls;
using InteractiveCrm.Core;
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
        public void AddDockContent(CodeManager manager)
        {
            codeEditorDockedContent = new CodeEditorDockedContent(manager);
            codeEditorDockedContent.Show(mainDockPanel, DockState.Document);

            tabsDockedContent = new TabsDockedContent(diagnosticsDataGridView_CellDoubleClick);
            tabsDockedContent.Show(mainDockPanel, DockState.DockBottom);
        }

        private TabsDockedContent tabsDockedContent;
        private CodeEditorDockedContent codeEditorDockedContent;
    }
}
