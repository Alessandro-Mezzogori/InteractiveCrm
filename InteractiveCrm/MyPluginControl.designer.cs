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
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.tssSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSample = new System.Windows.Forms.ToolStripButton();
            this.infoTabs = new System.Windows.Forms.TabControl();
            this.consoleTab = new System.Windows.Forms.TabPage();
            this.consoleOutEmulator = new System.Windows.Forms.TextBox();
            this.diagnosticsTab = new System.Windows.Forms.TabPage();
            this.diagnosticsDataGridView = new System.Windows.Forms.DataGridView();
            this.errorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnosticViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainCodeInput = new FastColoredTextBoxNS.FastColoredTextBox();
            this.toolStripMenu.SuspendLayout();
            this.infoTabs.SuspendLayout();
            this.consoleTab.SuspendLayout();
            this.diagnosticsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainCodeInput)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbClose,
            this.tssSeparator1,
            this.tsbSample});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripMenu.Size = new System.Drawing.Size(1396, 27);
            this.toolStripMenu.TabIndex = 4;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // tsbClose
            // 
            this.tsbClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(107, 24);
            this.tsbClose.Text = "Close this tool";
            this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click);
            // 
            // tssSeparator1
            // 
            this.tssSeparator1.Name = "tssSeparator1";
            this.tssSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbSample
            // 
            this.tsbSample.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbSample.Name = "tsbSample";
            this.tsbSample.Size = new System.Drawing.Size(57, 24);
            this.tsbSample.Text = "Try me";
            this.tsbSample.Click += new System.EventHandler(this.tsbSample_Click);
            // 
            // infoTabs
            // 
            this.infoTabs.Controls.Add(this.consoleTab);
            this.infoTabs.Controls.Add(this.diagnosticsTab);
            this.infoTabs.Location = new System.Drawing.Point(17, 531);
            this.infoTabs.Name = "infoTabs";
            this.infoTabs.SelectedIndex = 0;
            this.infoTabs.Size = new System.Drawing.Size(1353, 236);
            this.infoTabs.TabIndex = 9;
            // 
            // consoleTab
            // 
            this.consoleTab.Controls.Add(this.consoleOutEmulator);
            this.consoleTab.Location = new System.Drawing.Point(4, 25);
            this.consoleTab.Name = "consoleTab";
            this.consoleTab.Padding = new System.Windows.Forms.Padding(3);
            this.consoleTab.Size = new System.Drawing.Size(1345, 207);
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
            this.consoleOutEmulator.Size = new System.Drawing.Size(1339, 201);
            this.consoleOutEmulator.TabIndex = 0;
            // 
            // diagnosticsTab
            // 
            this.diagnosticsTab.Controls.Add(this.diagnosticsDataGridView);
            this.diagnosticsTab.Location = new System.Drawing.Point(4, 25);
            this.diagnosticsTab.Name = "diagnosticsTab";
            this.diagnosticsTab.Padding = new System.Windows.Forms.Padding(3);
            this.diagnosticsTab.Size = new System.Drawing.Size(1345, 207);
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
            this.diagnosticsDataGridView.Location = new System.Drawing.Point(4, 4);
            this.diagnosticsDataGridView.Name = "diagnosticsDataGridView";
            this.diagnosticsDataGridView.ReadOnly = true;
            this.diagnosticsDataGridView.RowHeadersWidth = 51;
            this.diagnosticsDataGridView.RowTemplate.Height = 24;
            this.diagnosticsDataGridView.Size = new System.Drawing.Size(1674, 251);
            this.diagnosticsDataGridView.TabIndex = 0;
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
            this.mainCodeInput.AutoScrollMinSize = new System.Drawing.Size(31, 18);
            this.mainCodeInput.BackBrush = null;
            this.mainCodeInput.CharHeight = 18;
            this.mainCodeInput.CharWidth = 10;
            this.mainCodeInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mainCodeInput.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.mainCodeInput.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.mainCodeInput.IsReplaceMode = false;
            this.mainCodeInput.Language = FastColoredTextBoxNS.Language.CSharp;
            this.mainCodeInput.Location = new System.Drawing.Point(17, 42);
            this.mainCodeInput.Name = "mainCodeInput";
            this.mainCodeInput.Paddings = new System.Windows.Forms.Padding(0);
            this.mainCodeInput.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.mainCodeInput.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("mainCodeInput.ServiceColors")));
            this.mainCodeInput.Size = new System.Drawing.Size(1353, 454);
            this.mainCodeInput.TabIndex = 10;
            this.mainCodeInput.TabLength = 3;
            this.mainCodeInput.Zoom = 100;
            this.mainCodeInput.KeyPressed += mainCodeInput_TextChanged;

            this.mainCodeInputAutoCompleteMenu = new FastColoredTextBoxNS.AutocompleteMenu(mainCodeInput);
            this.mainCodeInputAutoCompleteMenu.MinFragmentLength = 1;
            this.mainCodeInputAutoCompleteMenu.SearchPattern = @"[\w]";

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
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainCodeInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.ToolStripButton tsbSample;
        private System.Windows.Forms.ToolStripSeparator tssSeparator1;
        private System.Windows.Forms.TabControl infoTabs;
        private System.Windows.Forms.TabPage consoleTab;
        private System.Windows.Forms.TabPage diagnosticsTab;
        private System.Windows.Forms.DataGridView diagnosticsDataGridView;
        private System.Windows.Forms.BindingSource diagnosticViewModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn severityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn errorDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox consoleOutEmulator;

        private FastColoredTextBoxNS.FastColoredTextBox mainCodeInput;
        private FastColoredTextBoxNS.AutocompleteMenu mainCodeInputAutoCompleteMenu;
    }

}
