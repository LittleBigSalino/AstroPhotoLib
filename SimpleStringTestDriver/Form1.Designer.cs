namespace SimpleStringTestDriver
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
            this.textBoxStringToParse = new System.Windows.Forms.TextBox();
            this.buttonParseString = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxStringToParse
            // 
            this.textBoxStringToParse.Location = new System.Drawing.Point(36, 34);
            this.textBoxStringToParse.Name = "textBoxStringToParse";
            this.textBoxStringToParse.Size = new System.Drawing.Size(165, 20);
            this.textBoxStringToParse.TabIndex = 0;
            // 
            // buttonParseString
            // 
            this.buttonParseString.Location = new System.Drawing.Point(277, 25);
            this.buttonParseString.Name = "buttonParseString";
            this.buttonParseString.Size = new System.Drawing.Size(148, 37);
            this.buttonParseString.TabIndex = 1;
            this.buttonParseString.Text = "button1";
            this.buttonParseString.UseVisualStyleBackColor = true;
            this.buttonParseString.Click += new System.EventHandler(this.buttonParseString_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 456);
            this.Controls.Add(this.buttonParseString);
            this.Controls.Add(this.textBoxStringToParse);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxStringToParse;
        private System.Windows.Forms.Button buttonParseString;
    }
}

