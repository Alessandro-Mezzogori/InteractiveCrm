using FastColoredTextBoxNS;
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
    public partial class TabsDockedContent : DockContent
    {
        public TabsDockedContent(DataGridViewCellEventHandler dataGridViewCellEventHandler)
        {
            InitializeComponent();

            diagnosticsDataGridView.CellDoubleClick += dataGridViewCellEventHandler;
        }

        public ControlWriter GetConsoleWriter()
        {
            return new ControlWriter(this.consoleOutEmulator);
        }

        public ControlWriter GetLogWriter()
        {
            return new ControlWriter(this.logTextBox);
        }

        public void SelectConsoleTab()
        {
            this.infoTabs.SelectTab(this.consoleTab);
        }

        public void SelectDiagnosticsTab()
        {
            this.infoTabs.SelectTab(this.diagnosticsTab);
        }

        public BindingSource GetDiagnosticSource()
        {
            return diagnosticViewModelBindingSource;
        }
    }
}
