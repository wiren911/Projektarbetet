namespace RSSReader
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
            this.txtURL = new System.Windows.Forms.TextBox();
            this.btnGetXML = new System.Windows.Forms.Button();
            this.lstRSS = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(24, 28);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(442, 20);
            this.txtURL.TabIndex = 0;
            // 
            // btnGetXML
            // 
            this.btnGetXML.Location = new System.Drawing.Point(24, 72);
            this.btnGetXML.Name = "btnGetXML";
            this.btnGetXML.Size = new System.Drawing.Size(75, 23);
            this.btnGetXML.TabIndex = 1;
            this.btnGetXML.Text = "button1";
            this.btnGetXML.UseVisualStyleBackColor = true;
            this.btnGetXML.Click += new System.EventHandler(this.btnGetXML_Click);
            // 
            // lstRSS
            // 
            this.lstRSS.FormattingEnabled = true;
            this.lstRSS.Location = new System.Drawing.Point(170, 83);
            this.lstRSS.Name = "lstRSS";
            this.lstRSS.Size = new System.Drawing.Size(314, 251);
            this.lstRSS.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 345);
            this.Controls.Add(this.lstRSS);
            this.Controls.Add(this.btnGetXML);
            this.Controls.Add(this.txtURL);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Button btnGetXML;
        private System.Windows.Forms.ListBox lstRSS;
    }
}

