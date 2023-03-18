namespace InteractiveCrm.Controls
{
    partial class TabsDockedContent
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.consoleOutEmulator = new System.Windows.Forms.TextBox();
            this.infoTabs = new System.Windows.Forms.TabControl();
            this.diagnosticsTab = new System.Windows.Forms.TabPage();
            this.diagnosticsDataGridView = new System.Windows.Forms.DataGridView();
            this.logTab = new System.Windows.Forms.TabPage();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.errorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnosticViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consoleTab = new System.Windows.Forms.TabPage();
            this.infoTabs.SuspendLayout();
            this.diagnosticsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticsDataGridView)).BeginInit();
            this.logTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticViewModelBindingSource)).BeginInit();
            this.consoleTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // consoleOutEmulator
            // 
            this.consoleOutEmulator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.consoleOutEmulator.Location = new System.Drawing.Point(3, 3);
            this.consoleOutEmulator.Multiline = true;
            this.consoleOutEmulator.Name = "consoleOutEmulator";
            this.consoleOutEmulator.ReadOnly = true;
            this.consoleOutEmulator.ShortcutsEnabled = false;
            this.consoleOutEmulator.Size = new System.Drawing.Size(1213, 562);
            this.consoleOutEmulator.TabIndex = 1;
            // 
            // infoTabs
            // 
            this.infoTabs.Controls.Add(this.consoleTab);
            this.infoTabs.Controls.Add(this.diagnosticsTab);
            this.infoTabs.Controls.Add(this.logTab);
            this.infoTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoTabs.Location = new System.Drawing.Point(0, 0);
            this.infoTabs.Name = "infoTabs";
            this.infoTabs.SelectedIndex = 0;
            this.infoTabs.Size = new System.Drawing.Size(1227, 597);
            this.infoTabs.TabIndex = 10;
            // 
            // diagnosticsTab
            // 
            this.diagnosticsTab.Controls.Add(this.diagnosticsDataGridView);
            this.diagnosticsTab.Location = new System.Drawing.Point(4, 25);
            this.diagnosticsTab.Name = "diagnosticsTab";
            this.diagnosticsTab.Padding = new System.Windows.Forms.Padding(3);
            this.diagnosticsTab.Size = new System.Drawing.Size(875, 420);
            this.diagnosticsTab.TabIndex = 1;
            this.diagnosticsTab.Text = "Diagnostics";
            this.diagnosticsTab.UseVisualStyleBackColor = true;
            // 
            // diagnosticsDataGridView
            // 
            this.diagnosticsDataGridView.AllowUserToAddRows = false;
            this.diagnosticsDataGridView.AllowUserToDeleteRows = false;
            this.diagnosticsDataGridView.AutoGenerateColumns = false;
            this.diagnosticsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.diagnosticsDataGridView.Size = new System.Drawing.Size(869, 414);
            this.diagnosticsDataGridView.TabIndex = 0;
            // 
            // logTab
            // 
            this.logTab.Controls.Add(this.logTextBox);
            this.logTab.Location = new System.Drawing.Point(4, 25);
            this.logTab.Name = "logTab";
            this.logTab.Padding = new System.Windows.Forms.Padding(3);
            this.logTab.Size = new System.Drawing.Size(875, 420);
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
            this.logTextBox.Size = new System.Drawing.Size(869, 414);
            this.logTextBox.TabIndex = 1;
            // 
            // errorDataGridViewTextBoxColumn
            // 
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
            // consoleTab
            // 
            this.consoleTab.Controls.Add(this.consoleOutEmulator);
            this.consoleTab.Location = new System.Drawing.Point(4, 25);
            this.consoleTab.Name = "consoleTab";
            this.consoleTab.Padding = new System.Windows.Forms.Padding(3);
            this.consoleTab.Size = new System.Drawing.Size(1219, 568);
            this.consoleTab.TabIndex = 0;
            this.consoleTab.Text = "Console";
            this.consoleTab.UseVisualStyleBackColor = true;
            // 
            // TabsDockedContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 597);
            this.Controls.Add(this.infoTabs);
            this.Name = "TabsDockedContent";
            this.infoTabs.ResumeLayout(false);
            this.diagnosticsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticsDataGridView)).EndInit();
            this.logTab.ResumeLayout(false);
            this.logTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticViewModelBindingSource)).EndInit();
            this.consoleTab.ResumeLayout(false);
            this.consoleTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox consoleOutEmulator;
        private System.Windows.Forms.TabControl infoTabs;
        private System.Windows.Forms.TabPage diagnosticsTab;
        private System.Windows.Forms.DataGridView diagnosticsDataGridView;
        private System.Windows.Forms.TabPage logTab;
        private System.Windows.Forms.TextBox logTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn errorDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource diagnosticViewModelBindingSource;
        private System.Windows.Forms.TabPage consoleTab;
    }
}
