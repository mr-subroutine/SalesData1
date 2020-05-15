using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesData1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // disable all buttons except create button

        int[,] salesDataNumbers = new int[4, 5];
        string[] workerNames = new string[4];
        string[] daysOfWeek = new string[5];

        private void Form1_Load(object sender, EventArgs e)
        {
            string StartUpPath = Application.StartupPath;
            string fileLocation = StartUpPath + @"\salesdata.txt";
            
            // 1 delete any previous sales file
            File.Delete(fileLocation);

            // 2 locks all buttons on initial load
            lockButtonSecurity();
        }

        private void lockButtonSecurity()
        {
            // disable all buttons but create
            btn_total_sales.Enabled = false;
            btn_average.Enabled = false;
            btn_seperate_totals.Enabled = false;
            btn_highest.Enabled = false;
            btn_lowest.Enabled = false;
            btn_clear.Enabled = false;
        }

        private void unlockButtonSecurity()
        {
            // disable all buttons but create
            btn_total_sales.Enabled = true;
            btn_average.Enabled = true;
            btn_seperate_totals.Enabled = true;
            btn_highest.Enabled = true;
            btn_lowest.Enabled = true;
            btn_clear.Enabled = true;
        }

        // button 1
        private void button1_Click(object sender, EventArgs e)
        {
            createFile();
            writeToDisplay(workerNames, salesDataNumbers, daysOfWeek);
        }

        // clear form
        private void btn_clear_Click(object sender, EventArgs e)
        {
            
        }

        // Close Form
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createFile()
        {
            // path to write files
            string StartUpPath = Application.StartupPath;
            string fileLocation = StartUpPath + @"\salesdata.txt";
            string fileCheck = fileLocation;

            // creates a file (this is needed so the application can be self-reliant)
            string[] fileData = {"100", "70", "80", "60", "70", "90",
                "100", "100", "95", "50", "70", "80", "90", "100", "51", "70", "75", "70", "80", "90",
                "Jim", "Kathleen", "Darryl", "William", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday"};

            File.WriteAllLines(@fileLocation, fileData);
            MessageBox.Show("Data File Created!");
            btn_create_file.Enabled = false;
            // gathers data first storing into arrays in a method
            storeAllData();
            unlockButtonSecurity();

        }

        private void storeAllData()
        {
            // path to read file
            string StartUpPath = Application.StartupPath;
            string fileLocation = StartUpPath + @"\salesdata.txt";

            // store all numeric data
            using (StreamReader read = new StreamReader(fileLocation))
            {
                // Read and display lines from the file until the end of...
                // the file is reached.
                for (int row = 0; row < 4; row++)
                {
                    for (int col = 0; col < 5; col++)
                    {
                        salesDataNumbers[row, col] = Convert.ToInt32(read.ReadLine());
                    }
                }
                // readline continues where it left off since file isn't closed and stores employee names
                for (int row = 0; row < 4; row++)
                {
                    workerNames[row] = read.ReadLine();
                }

                // store days of week
                for (int row = 0; row < 5; row++)
                {
                    daysOfWeek[row] = read.ReadLine();
                }
                read.Close();

                // call writeToDisplay here
            }
        }

        private void displaylabelTop()
        {
            textBoxInfo.Text += "Sales Data Analysis" + Environment.NewLine;
            textBoxInfo.Text += Environment.NewLine;
            textBoxInfo.Text += "Base Data" + Environment.NewLine;
            textBoxInfo.Text += Environment.NewLine;
        }

        // write data to text box
        private void writeToDisplay(string[] names, int[,] sales, string[] days)
        {
            // displays header info first
            displaylabelTop();

            // print days
            textBoxInfo.Text += "\t";
            for (int i = 0; i < 5; i++)
            {
                textBoxInfo.Text += "\t";
                textBoxInfo.Text += days[i];
                textBoxInfo.Text += "\t";
            }

            textBoxInfo.Text += Environment.NewLine;
            // print name and sales
            int nameLength = names.Length;

            for (int row = 0; row < 4; row++)
            {
                textBoxInfo.Text += Environment.NewLine;
                textBoxInfo.Text += names[row];
                textBoxInfo.Text += "\t";

                for (int col = 0; col < 5; col++)
                {
                    textBoxInfo.Text += "\t";
                    textBoxInfo.Text += sales[row, col].ToString("n");
                    textBoxInfo.Text += "\t";
                }
            }
        }

        private void btn_total_sales_Click(object sender, EventArgs e)
        {
            btn_total_sales.Enabled = false;
            int totalSales = 0;
            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 5; col++)
                {
                    totalSales += salesDataNumbers[row, col];
                }
            }
            textBoxInfo.Text += Environment.NewLine;
            textBoxInfo.Text += "Group Total Sales Data: " + totalSales;
        }
    }
}

// Display Sales (basic, all sales each day) x
// Highest Total Sales for Everyone All Days x
// Average Sales Total for Everyone
// Lowest Sale Day and Salesperson
// Highest Sales Day and Salesperson
// Total Sales Overall
