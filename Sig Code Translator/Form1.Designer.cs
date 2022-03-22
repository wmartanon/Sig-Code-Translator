namespace Sig_Code_Translator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.lblSig = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.codeSupportedCurrentlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(33, 114);
            this.txtInput.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(678, 35);
            this.txtInput.TabIndex = 0;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(582, 161);
            this.btnConvert.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(129, 46);
            this.btnConvert.TabIndex = 1;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(33, 219);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(678, 214);
            this.txtOutput.TabIndex = 2;
            // 
            // lblSig
            // 
            this.lblSig.AutoSize = true;
            this.lblSig.Location = new System.Drawing.Point(33, 78);
            this.lblSig.Name = "lblSig";
            this.lblSig.Size = new System.Drawing.Size(46, 30);
            this.lblSig.TabIndex = 3;
            this.lblSig.Text = "Sig:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.codeSupportedCurrentlyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(761, 38);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // codeSupportedCurrentlyToolStripMenuItem
            // 
            this.codeSupportedCurrentlyToolStripMenuItem.Name = "codeSupportedCurrentlyToolStripMenuItem";
            this.codeSupportedCurrentlyToolStripMenuItem.Size = new System.Drawing.Size(271, 34);
            this.codeSupportedCurrentlyToolStripMenuItem.Text = "Code Supported Currently";
            this.codeSupportedCurrentlyToolStripMenuItem.Click += new System.EventHandler(this.codeSupportedCurrentlyToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 464);
            this.Controls.Add(this.lblSig);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.Text = "wmartanon\'s Sig Code Converter";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtInput;
        private Button btnConvert;
        private TextBox txtOutput;
        private Label lblSig;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem codeSupportedCurrentlyToolStripMenuItem;
    }
}