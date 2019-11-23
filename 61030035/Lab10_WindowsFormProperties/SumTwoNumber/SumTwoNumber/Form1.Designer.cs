namespace SumTwoNumber
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.btnFontDialog = new System.Windows.Forms.Button();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.btnUpdateRichTextBox1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnFontDialog
            // 
            this.btnFontDialog.Location = new System.Drawing.Point(48, 25);
            this.btnFontDialog.Name = "btnFontDialog";
            this.btnFontDialog.Size = new System.Drawing.Size(139, 50);
            this.btnFontDialog.TabIndex = 0;
            this.btnFontDialog.Text = "Font Dialog";
            this.btnFontDialog.UseVisualStyleBackColor = true;
            this.btnFontDialog.Click += new System.EventHandler(this.btnFontDialog_Click);
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Location = new System.Drawing.Point(348, 25);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.SelectedObject = this.fontDialog1;
            this.propertyGrid1.Size = new System.Drawing.Size(286, 311);
            this.propertyGrid1.TabIndex = 1;
            // 
            // btnUpdateRichTextBox1
            // 
            this.btnUpdateRichTextBox1.Location = new System.Drawing.Point(48, 153);
            this.btnUpdateRichTextBox1.Name = "btnUpdateRichTextBox1";
            this.btnUpdateRichTextBox1.Size = new System.Drawing.Size(139, 49);
            this.btnUpdateRichTextBox1.TabIndex = 2;
            this.btnUpdateRichTextBox1.Text = "Update text";
            this.btnUpdateRichTextBox1.UseVisualStyleBackColor = true;
            this.btnUpdateRichTextBox1.Click += new System.EventHandler(this.btnUpdateRichTextBox1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(48, 102);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(139, 26);
            this.richTextBox1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(48, 240);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 26);
            this.textBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnUpdateRichTextBox1);
            this.Controls.Add(this.propertyGrid1);
            this.Controls.Add(this.btnFontDialog);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button btnFontDialog;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.Button btnUpdateRichTextBox1;
        private System.Windows.Forms.TextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

