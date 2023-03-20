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
            this.diagnosticViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diagnosticsTab = new System.Windows.Forms.TabPage();
            this.diagnosticsDataGridView = new System.Windows.Forms.DataGridView();
            this.errorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consoleTab = new System.Windows.Forms.TabPage();
            this.consoleOutEmulator = new System.Windows.Forms.TextBox();
            this.infoTabs = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticViewModelBindingSource)).BeginInit();
            this.diagnosticsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticsDataGridView)).BeginInit();
            this.consoleTab.SuspendLayout();
            this.infoTabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // diagnosticViewModelBindingSource
            // 
            this.diagnosticViewModelBindingSource.DataSource = typeof(InteractiveCrm.DiagnosticViewModel);
            // 
            // diagnosticsTab
            // 
            this.diagnosticsTab.Controls.Add(this.diagnosticsDataGridView);
            this.diagnosticsTab.Location = new System.Drawing.Point(4, 22);
            this.diagnosticsTab.Margin = new System.Windows.Forms.Padding(2);
            this.diagnosticsTab.Name = "diagnosticsTab";
            this.diagnosticsTab.Padding = new System.Windows.Forms.Padding(2);
            this.diagnosticsTab.Size = new System.Drawing.Size(912, 459);
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
            this.diagnosticsDataGridView.Location = new System.Drawing.Point(2, 2);
            this.diagnosticsDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.diagnosticsDataGridView.Name = "diagnosticsDataGridView";
            this.diagnosticsDataGridView.ReadOnly = true;
            this.diagnosticsDataGridView.RowHeadersWidth = 51;
            this.diagnosticsDataGridView.RowTemplate.Height = 24;
            this.diagnosticsDataGridView.Size = new System.Drawing.Size(908, 455);
            this.diagnosticsDataGridView.TabIndex = 0;
            // 
            // errorDataGridViewTextBoxColumn
            // 
            this.errorDataGridViewTextBoxColumn.DataPropertyName = "Error";
            this.errorDataGridViewTextBoxColumn.HeaderText = "Error";
            this.errorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.errorDataGridViewTextBoxColumn.Name = "errorDataGridViewTextBoxColumn";
            this.errorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // consoleTab
            // 
            this.consoleTab.Controls.Add(this.consoleOutEmulator);
            this.consoleTab.Location = new System.Drawing.Point(4, 22);
            this.consoleTab.Margin = new System.Windows.Forms.Padding(2);
            this.consoleTab.Name = "consoleTab";
            this.consoleTab.Padding = new System.Windows.Forms.Padding(2);
            this.consoleTab.Size = new System.Drawing.Size(912, 459);
            this.consoleTab.TabIndex = 0;
            this.consoleTab.Text = "Console";
            this.consoleTab.UseVisualStyleBackColor = true;
            // 
            // consoleOutEmulator
            // 
            this.consoleOutEmulator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.consoleOutEmulator.Location = new System.Drawing.Point(2, 2);
            this.consoleOutEmulator.Margin = new System.Windows.Forms.Padding(2);
            this.consoleOutEmulator.Multiline = true;
            this.consoleOutEmulator.Name = "consoleOutEmulator";
            this.consoleOutEmulator.ReadOnly = true;
            this.consoleOutEmulator.ShortcutsEnabled = false;
            this.consoleOutEmulator.Size = new System.Drawing.Size(908, 455);
            this.consoleOutEmulator.TabIndex = 1;
            // 
            // infoTabs
            // 
            this.infoTabs.Controls.Add(this.consoleTab);
            this.infoTabs.Controls.Add(this.diagnosticsTab);
            this.infoTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoTabs.Location = new System.Drawing.Point(0, 0);
            this.infoTabs.Margin = new System.Windows.Forms.Padding(2);
            this.infoTabs.Name = "infoTabs";
            this.infoTabs.SelectedIndex = 0;
            this.infoTabs.Size = new System.Drawing.Size(920, 485);
            this.infoTabs.TabIndex = 10;
            // 
            // TabsDockedContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 485);
            this.Controls.Add(this.infoTabs);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TabsDockedContent";
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticViewModelBindingSource)).EndInit();
            this.diagnosticsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticsDataGridView)).EndInit();
            this.consoleTab.ResumeLayout(false);
            this.consoleTab.PerformLayout();
            this.infoTabs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource diagnosticViewModelBindingSource;
        private System.Windows.Forms.TabPage diagnosticsTab;
        private System.Windows.Forms.DataGridView diagnosticsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn errorDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage consoleTab;
        private System.Windows.Forms.TextBox consoleOutEmulator;
        private System.Windows.Forms.TabControl infoTabs;
    }
}
