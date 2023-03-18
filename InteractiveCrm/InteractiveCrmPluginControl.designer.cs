using ScintillaNET;
using System.Drawing;

namespace InteractiveCrm
{
    partial class InteractiveCrmPluginControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InteractiveCrmPluginControl));
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.tssSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.executeCodeButton = new System.Windows.Forms.ToolStripButton();
            this.saveFileButton = new System.Windows.Forms.ToolStripButton();
            this.infoTabs = new System.Windows.Forms.TabControl();
            this.consoleTab = new System.Windows.Forms.TabPage();
            this.consoleOutEmulator = new System.Windows.Forms.TextBox();
            this.diagnosticsTab = new System.Windows.Forms.TabPage();
            this.diagnosticsDataGridView = new System.Windows.Forms.DataGridView();
            this.mainCodeInput = new FastColoredTextBoxNS.FastColoredTextBox();
            this.logTab = new System.Windows.Forms.TabPage();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.errorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnosticViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dockPanel1 = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.toolStripMenu.SuspendLayout();
            this.infoTabs.SuspendLayout();
            this.consoleTab.SuspendLayout();
            this.diagnosticsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainCodeInput)).BeginInit();
            this.logTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticViewModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssSeparator1,
            this.executeCodeButton,
            this.saveFileButton});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripMenu.Size = new System.Drawing.Size(1396, 27);
            this.toolStripMenu.TabIndex = 4;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // tssSeparator1
            // 
            this.tssSeparator1.Name = "tssSeparator1";
            this.tssSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // executeCodeButton
            // 
            this.executeCodeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.executeCodeButton.Name = "executeCodeButton";
            this.executeCodeButton.Size = new System.Drawing.Size(64, 24);
            this.executeCodeButton.Text = "Execute";
            this.executeCodeButton.Click += new System.EventHandler(this.executeCodeButton_Click);
            // 
            // saveFileButton
            // 
            this.saveFileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.saveFileButton.Image = ((System.Drawing.Image)(resources.GetObject("saveFileButton.Image")));
            this.saveFileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveFileButton.Name = "saveFileButton";
            this.saveFileButton.Size = new System.Drawing.Size(44, 24);
            this.saveFileButton.Text = "Save";
            // 
            // infoTabs
            // 
            this.infoTabs.Controls.Add(this.consoleTab);
            this.infoTabs.Controls.Add(this.diagnosticsTab);
            this.infoTabs.Controls.Add(this.logTab);
            this.infoTabs.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.infoTabs.Location = new System.Drawing.Point(0, 698);
            this.infoTabs.Name = "infoTabs";
            this.infoTabs.SelectedIndex = 0;
            this.infoTabs.Size = new System.Drawing.Size(1396, 226);
            this.infoTabs.TabIndex = 9;
            // 
            // consoleTab
            // 
            this.consoleTab.Controls.Add(this.dockPanel1);
            this.consoleTab.Controls.Add(this.consoleOutEmulator);
            this.consoleTab.Location = new System.Drawing.Point(4, 25);
            this.consoleTab.Name = "consoleTab";
            this.consoleTab.Padding = new System.Windows.Forms.Padding(3);
            this.consoleTab.Size = new System.Drawing.Size(1388, 197);
            this.consoleTab.TabIndex = 0;
            this.consoleTab.Text = "Console";
            this.consoleTab.UseVisualStyleBackColor = true;
            // 
            // consoleOutEmulator
            // 
            this.consoleOutEmulator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.consoleOutEmulator.Location = new System.Drawing.Point(3, 3);
            this.consoleOutEmulator.Multiline = true;
            this.consoleOutEmulator.Name = "consoleOutEmulator";
            this.consoleOutEmulator.ReadOnly = true;
            this.consoleOutEmulator.ShortcutsEnabled = false;
            this.consoleOutEmulator.Size = new System.Drawing.Size(1382, 191);
            this.consoleOutEmulator.TabIndex = 0;
            // 
            // diagnosticsTab
            // 
            this.diagnosticsTab.Controls.Add(this.diagnosticsDataGridView);
            this.diagnosticsTab.Location = new System.Drawing.Point(4, 25);
            this.diagnosticsTab.Name = "diagnosticsTab";
            this.diagnosticsTab.Padding = new System.Windows.Forms.Padding(3);
            this.diagnosticsTab.Size = new System.Drawing.Size(1388, 197);
            this.diagnosticsTab.TabIndex = 1;
            this.diagnosticsTab.Text = "Diagnostics";
            this.diagnosticsTab.UseVisualStyleBackColor = true;
            // 
            // diagnosticsDataGridView
            // 
            this.diagnosticsDataGridView.AllowUserToAddRows = false;
            this.diagnosticsDataGridView.AllowUserToDeleteRows = false;
            this.diagnosticsDataGridView.AutoGenerateColumns = false;
            this.diagnosticsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.diagnosticsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.errorDataGridViewTextBoxColumn});
            this.diagnosticsDataGridView.DataSource = this.diagnosticViewModelBindingSource;
            this.diagnosticsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diagnosticsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.diagnosticsDataGridView.Name = "diagnosticsDataGridView";
            this.diagnosticsDataGridView.ReadOnly = true;
            this.diagnosticsDataGridView.RowHeadersWidth = 51;
            this.diagnosticsDataGridView.RowTemplate.Height = 24;
            this.diagnosticsDataGridView.Size = new System.Drawing.Size(1382, 191);
            this.diagnosticsDataGridView.TabIndex = 0;
            this.diagnosticsDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.diagnosticsDataGridView_CellDoubleClick);
            // 
            // mainCodeInput
            // 
            this.mainCodeInput.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.mainCodeInput.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\r\n^\\s*(case|default)\\s*[^:]" +
    "*(?<range>:)\\s*(?<range>[^;]+);\r\n";
            this.mainCodeInput.AutoScrollMinSize = new System.Drawing.Size(31, 18);
            this.mainCodeInput.BackBrush = null;
            this.mainCodeInput.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.mainCodeInput.CharHeight = 18;
            this.mainCodeInput.CharWidth = 10;
            this.mainCodeInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mainCodeInput.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.mainCodeInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainCodeInput.IsReplaceMode = false;
            this.mainCodeInput.Language = FastColoredTextBoxNS.Language.CSharp;
            this.mainCodeInput.LeftBracket = '(';
            this.mainCodeInput.LeftBracket2 = '{';
            this.mainCodeInput.Location = new System.Drawing.Point(0, 27);
            this.mainCodeInput.Name = "mainCodeInput";
            this.mainCodeInput.Paddings = new System.Windows.Forms.Padding(0);
            this.mainCodeInput.RightBracket = ')';
            this.mainCodeInput.RightBracket2 = '}';
            this.mainCodeInput.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.mainCodeInput.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("mainCodeInput.ServiceColors")));
            this.mainCodeInput.Size = new System.Drawing.Size(1396, 671);
            this.mainCodeInput.TabIndex = 10;
            this.mainCodeInput.TabLength = 3;
            this.mainCodeInput.Zoom = 100;
            this.mainCodeInput.KeyPressed += new System.Windows.Forms.KeyPressEventHandler(this.mainCodeInput_TextChanged);
            this.mainCodeInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mainCodeInput_KeyDown);
            // 
            // logTab
            // 
            this.logTab.Controls.Add(this.logTextBox);
            this.logTab.Location = new System.Drawing.Point(4, 25);
            this.logTab.Name = "logTab";
            this.logTab.Padding = new System.Windows.Forms.Padding(3);
            this.logTab.Size = new System.Drawing.Size(1388, 197);
            this.logTab.TabIndex = 2;
            this.logTab.Text = "Logs";
            this.logTab.UseVisualStyleBackColor = true;
            // 
            // logTextBox
            // 
            this.logTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logTextBox.Location = new System.Drawing.Point(3, 3);
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.ShortcutsEnabled = false;
            this.logTextBox.Size = new System.Drawing.Size(1382, 191);
            this.logTextBox.TabIndex = 1;
            // 
            // errorDataGridViewTextBoxColumn
            // 
            this.errorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.errorDataGridViewTextBoxColumn.DataPropertyName = "Error";
            this.errorDataGridViewTextBoxColumn.HeaderText = "Error";
            this.errorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.errorDataGridViewTextBoxColumn.Name = "errorDataGridViewTextBoxColumn";
            this.errorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diagnosticViewModelBindingSource
            // 
            this.diagnosticViewModelBindingSource.DataSource = typeof(InteractiveCrm.DiagnosticViewModel);
            // 
            // dockPanel1
            // 
            this.dockPanel1.Location = new System.Drawing.Point(0, 0);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.Size = new System.Drawing.Size(200, 100);
            this.dockPanel1.TabIndex = 1;
            // 
            // InteractiveCrmPluginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainCodeInput);
            this.Controls.Add(this.infoTabs);
            this.Controls.Add(this.toolStripMenu);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InteractiveCrmPluginControl";
            this.Size = new System.Drawing.Size(1396, 924);
            this.Load += new System.EventHandler(this.MyPluginControl_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.infoTabs.ResumeLayout(false);
            this.consoleTab.ResumeLayout(false);
            this.consoleTab.PerformLayout();
            this.diagnosticsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainCodeInput)).EndInit();
            this.logTab.ResumeLayout(false);
            this.logTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticViewModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton executeCodeButton;
        private System.Windows.Forms.ToolStripSeparator tssSeparator1;
        private System.Windows.Forms.TabControl infoTabs;
        private System.Windows.Forms.TabPage consoleTab;
        private System.Windows.Forms.TabPage diagnosticsTab;
        private System.Windows.Forms.DataGridView diagnosticsDataGridView;
        private System.Windows.Forms.BindingSource diagnosticViewModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn errorDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox consoleOutEmulator;

        private FastColoredTextBoxNS.FastColoredTextBox mainCodeInput;
        private System.Windows.Forms.ToolStripButton saveFileButton;
        private System.Windows.Forms.TabPage logTab;
        private System.Windows.Forms.TextBox logTextBox;
        private WeifenLuo.WinFormsUI.Docking.DockPanel dockPanel1;
    }

}
