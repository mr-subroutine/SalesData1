namespace SalesData1
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
            this.textBoxInfo = new System.Windows.Forms.TextBox();
            this.txtBoxBasicInfo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.Location = new System.Drawing.Point(227, 41);
            this.textBoxInfo.Multiline = true;
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.Size = new System.Drawing.Size(303, 433);
            this.textBoxInfo.TabIndex = 0;
            // 
            // txtBoxBasicInfo
            // 
            this.txtBoxBasicInfo.Location = new System.Drawing.Point(34, 102);
            this.txtBoxBasicInfo.Name = "txtBoxBasicInfo";
            this.txtBoxBasicInfo.Size = new System.Drawing.Size(158, 47);
            this.txtBoxBasicInfo.TabIndex = 1;
            this.txtBoxBasicInfo.Text = "Get Data From File";
            this.txtBoxBasicInfo.UseVisualStyleBackColor = true;
            this.txtBoxBasicInfo.Click += new System.EventHandler(this.txtBoxBasicInfo_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 47);
            this.button1.TabIndex = 2;
            this.button1.Text = "Create File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 519);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBoxBasicInfo);
            this.Controls.Add(this.textBoxInfo);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Data1 v.1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInfo;
        private System.Windows.Forms.Button txtBoxBasicInfo;
        private System.Windows.Forms.Button button1;
    }
}

