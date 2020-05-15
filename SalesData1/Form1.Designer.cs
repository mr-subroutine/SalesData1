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
            this.btn_display_sales = new System.Windows.Forms.Button();
            this.btn_create_file = new System.Windows.Forms.Button();
            this.btn_total_sales = new System.Windows.Forms.Button();
            this.btn_average = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_lowest = new System.Windows.Forms.Button();
            this.btn_highest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.Location = new System.Drawing.Point(227, 41);
            this.textBoxInfo.Multiline = true;
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.Size = new System.Drawing.Size(672, 410);
            this.textBoxInfo.TabIndex = 0;
            // 
            // btn_display_sales
            // 
            this.btn_display_sales.Location = new System.Drawing.Point(34, 105);
            this.btn_display_sales.Name = "btn_display_sales";
            this.btn_display_sales.Size = new System.Drawing.Size(158, 47);
            this.btn_display_sales.TabIndex = 1;
            this.btn_display_sales.Text = "Display Sales Data File";
            this.btn_display_sales.UseVisualStyleBackColor = true;
            this.btn_display_sales.Click += new System.EventHandler(this.txtBoxBasicInfo_Click);
            // 
            // btn_create_file
            // 
            this.btn_create_file.Location = new System.Drawing.Point(34, 41);
            this.btn_create_file.Name = "btn_create_file";
            this.btn_create_file.Size = new System.Drawing.Size(158, 47);
            this.btn_create_file.TabIndex = 2;
            this.btn_create_file.Text = "Create File";
            this.btn_create_file.UseVisualStyleBackColor = true;
            this.btn_create_file.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_total_sales
            // 
            this.btn_total_sales.Location = new System.Drawing.Point(34, 167);
            this.btn_total_sales.Name = "btn_total_sales";
            this.btn_total_sales.Size = new System.Drawing.Size(158, 47);
            this.btn_total_sales.TabIndex = 3;
            this.btn_total_sales.Text = "Total Sales";
            this.btn_total_sales.UseVisualStyleBackColor = true;
            // 
            // btn_average
            // 
            this.btn_average.Location = new System.Drawing.Point(34, 230);
            this.btn_average.Name = "btn_average";
            this.btn_average.Size = new System.Drawing.Size(158, 47);
            this.btn_average.TabIndex = 4;
            this.btn_average.Text = "Average Sales";
            this.btn_average.UseVisualStyleBackColor = true;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(227, 466);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 5;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(824, 466);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 6;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_lowest
            // 
            this.btn_lowest.Location = new System.Drawing.Point(34, 366);
            this.btn_lowest.Name = "btn_lowest";
            this.btn_lowest.Size = new System.Drawing.Size(158, 47);
            this.btn_lowest.TabIndex = 7;
            this.btn_lowest.Text = "Lowest Sales";
            this.btn_lowest.UseVisualStyleBackColor = true;
            // 
            // btn_highest
            // 
            this.btn_highest.Location = new System.Drawing.Point(34, 299);
            this.btn_highest.Name = "btn_highest";
            this.btn_highest.Size = new System.Drawing.Size(158, 47);
            this.btn_highest.TabIndex = 8;
            this.btn_highest.Text = "Highest Sales";
            this.btn_highest.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 519);
            this.Controls.Add(this.btn_highest);
            this.Controls.Add(this.btn_lowest);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_average);
            this.Controls.Add(this.btn_total_sales);
            this.Controls.Add(this.btn_create_file);
            this.Controls.Add(this.btn_display_sales);
            this.Controls.Add(this.textBoxInfo);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Data1 v.1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInfo;
        private System.Windows.Forms.Button btn_display_sales;
        private System.Windows.Forms.Button btn_create_file;
        private System.Windows.Forms.Button btn_total_sales;
        private System.Windows.Forms.Button btn_average;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_lowest;
        private System.Windows.Forms.Button btn_highest;
    }
}

