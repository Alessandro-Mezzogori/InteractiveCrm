namespace InteractiveCrm.Controls
{
    partial class CodeEditorDockedContent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CodeEditorDockedContent));
            this.mainCodeInput = new FastColoredTextBoxNS.FastColoredTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.mainCodeInput)).BeginInit();
            this.SuspendLayout();
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
            this.mainCodeInput.Location = new System.Drawing.Point(0, 0);
            this.mainCodeInput.Name = "mainCodeInput";
            this.mainCodeInput.Paddings = new System.Windows.Forms.Padding(0);
            this.mainCodeInput.RightBracket = ')';
            this.mainCodeInput.RightBracket2 = '}';
            this.mainCodeInput.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.mainCodeInput.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("mainCodeInput.ServiceColors")));
            this.mainCodeInput.Size = new System.Drawing.Size(664, 488);
            this.mainCodeInput.TabIndex = 11;
            this.mainCodeInput.TabLength = 3;
            this.mainCodeInput.Zoom = 100;
            this.mainCodeInput.KeyPressed += new System.Windows.Forms.KeyPressEventHandler(this.mainCodeInput_KeyPressed);
            // 
            // CodeEditorDockedContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 488);
            this.Controls.Add(this.mainCodeInput);
            this.Name = "CodeEditorDockedContent";
            this.Text = "Code editor";
            ((System.ComponentModel.ISupportInitialize)(this.mainCodeInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public FastColoredTextBoxNS.FastColoredTextBox mainCodeInput;
    }
}
