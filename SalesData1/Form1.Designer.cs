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
            this.btn_create_file = new System.Windows.Forms.Button();
            this.btn_total_sales = new System.Windows.Forms.Button();
            this.btn_average = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_lowest = new System.Windows.Forms.Button();
            this.btn_highest = new System.Windows.Forms.Button();
            this.btn_seperate_totals = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.Location = new System.Drawing.Point(227, 41);
            this.textBoxInfo.Multiline = true;
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.ReadOnly = true;
            this.textBoxInfo.Size = new System.Drawing.Size(672, 432);
            this.textBoxInfo.TabIndex = 0;
            // 
            // btn_create_file
            // 
            this.btn_create_file.Location = new System.Drawing.Point(34, 41);
            this.btn_create_file.Name = "btn_create_file";
            this.btn_create_file.Size = new System.Drawing.Size(158, 47);
            this.btn_create_file.TabIndex = 2;
            this.btn_create_file.Text = "Create Test File";
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
            this.btn_total_sales.Click += new System.EventHandler(this.btn_total_sales_Click);
            // 
            // btn_average
            // 
            this.btn_average.Location = new System.Drawing.Point(34, 230);
            this.btn_average.Name = "btn_average";
            this.btn_average.Size = new System.Drawing.Size(158, 47);
            this.btn_average.TabIndex = 4;
            this.btn_average.Text = "Average Sales";
            this.btn_average.UseVisualStyleBackColor = true;
            this.btn_average.Click += new System.EventHandler(this.btn_average_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(227, 489);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 5;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(824, 489);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 6;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_lowest
            // 
            this.btn_lowest.Location = new System.Drawing.Point(34, 426);
            this.btn_lowest.Name = "btn_lowest";
            this.btn_lowest.Size = new System.Drawing.Size(158, 47);
            this.btn_lowest.TabIndex = 7;
            this.btn_lowest.Text = "Lowest Sales";
            this.btn_lowest.UseVisualStyleBackColor = true;
            this.btn_lowest.Click += new System.EventHandler(this.btn_lowest_Click);
            // 
            // btn_highest
            // 
            this.btn_highest.Location = new System.Drawing.Point(34, 361);
            this.btn_highest.Name = "btn_highest";
            this.btn_highest.Size = new System.Drawing.Size(158, 47);
            this.btn_highest.TabIndex = 8;
            this.btn_highest.Text = "Highest Sales";
            this.btn_highest.UseVisualStyleBackColor = true;
            this.btn_highest.Click += new System.EventHandler(this.btn_highest_Click);
            // 
            // btn_seperate_totals
            // 
            this.btn_seperate_totals.Location = new System.Drawing.Point(34, 296);
            this.btn_seperate_totals.Name = "btn_seperate_totals";
            this.btn_seperate_totals.Size = new System.Drawing.Size(158, 47);
            this.btn_seperate_totals.TabIndex = 9;
            this.btn_seperate_totals.Text = "Individual Totals";
            this.btn_seperate_totals.UseVisualStyleBackColor = true;
            this.btn_seperate_totals.Click += new System.EventHandler(this.btn_seperate_totals_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 544);
            this.Controls.Add(this.btn_seperate_totals);
            this.Controls.Add(this.btn_highest);
            this.Controls.Add(this.btn_lowest);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_average);
            this.Controls.Add(this.btn_total_sales);
            this.Controls.Add(this.btn_create_file);
            this.Controls.Add(this.textBoxInfo);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Data1 v.1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInfo;
        private System.Windows.Forms.Button btn_create_file;
        private System.Windows.Forms.Button btn_total_sales;
        private System.Windows.Forms.Button btn_average;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_lowest;
        private System.Windows.Forms.Button btn_highest;
        private System.Windows.Forms.Button btn_seperate_totals;
    }
}

