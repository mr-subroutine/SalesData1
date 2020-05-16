using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        int totalSales = 0;
        int getAverage = 0;

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
            textBoxInfo.Clear();
            lockButtonSecurity();

            string StartUpPath = Application.StartupPath;
            string fileLocation = StartUpPath + @"\salesdata.txt";
            File.Delete(fileLocation);

            // unlocks create button for return to initial state
            btn_create_file.Enabled = true;
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
            string[] fileData = {"200", "170", "180", "160", "170", "190",
                "170", "250", "195", "150", "180", "180", "190", "110", "51", "170", "75", "170", "50", "190",
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
        private void writeToDisplay(string[] names, int[,] sales, string[] daysOfweek)
        {
            // displays header info first
            displaylabelTop();

            // print days
            textBoxInfo.Text += "\t";
            for (int i = 0; i < 5; i++)
            {
                textBoxInfo.Text += "\t";
                textBoxInfo.Text += daysOfweek[i] + "\t";
            }

            textBoxInfo.Text += Environment.NewLine;
            // print table with names and sales
            for (int row = 0; row < 4; row++)
            {
                textBoxInfo.Text += Environment.NewLine;
                textBoxInfo.Text += names[row];
                textBoxInfo.Text += "\t";

                for (int col = 0; col < 5; col++)
                {
                    textBoxInfo.Text += "\t";
                    textBoxInfo.Text += sales[row, col].ToString("c");
                    textBoxInfo.Text += "\t";
                }
            }
        }

        private void btn_total_sales_Click(object sender, EventArgs e)
        {
            totalSales = 0;
            btn_total_sales.Enabled = false;
            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 5; col++)
                {
                    totalSales += salesDataNumbers[row, col];
                }
            }
            textBoxInfo.Text += "\r\n";
            textBoxInfo.Text += "\r\n" + "Group Total Sales: " +  totalSales.ToString("c");
        }

        // button 3 
        private void btn_average_Click(object sender, EventArgs e)
        {
            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 5; col++)
                {
                    totalSales += salesDataNumbers[row, col];
                }
            }
            getAverage = totalSales / 20;
            textBoxInfo.Text += "\r\n";
            textBoxInfo.Text += "\r\n" + "Average Daily Sales: " + getAverage.ToString("c") + Environment.NewLine;
            btn_average.Enabled = false;
        }

        private void btn_seperate_totals_Click(object sender, EventArgs e)
        {
            displayIndiTotals(workerNames, salesDataNumbers);
        }

        private void displayIndiTotals(string[] names, int[,] sales)
        {
            btn_seperate_totals.Enabled = false;
            textBoxInfo.Text += Environment.NewLine + "Individual Sales Totals: ";

            int singleTotal = 0;
            for (int row = 0; row < 4; row++)
            {
                textBoxInfo.Text += Environment.NewLine + names[row];
                textBoxInfo.Text += "\t";

                for (int col = 0; col < 5; col++)
                {
                    int count = 0;
                    if (count < 5)
                    {
                        singleTotal += salesDataNumbers[row, col];
                    }
                    count++;

                    if (col == 4)
                    {
                        textBoxInfo.Text += "Sales Total: " + singleTotal.ToString("c");
                        singleTotal = 0;
                    }
                }
            }
        }

        private void displayHighest()
        {
            int highestSales = -1;
            string storeUser = "";

            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 5; col++)
                {
                    if (highestSales < salesDataNumbers[row, col])
                    {
                        highestSales = salesDataNumbers[row, col];
                        storeUser = workerNames[row];
                    }
                }
            }

            textBoxInfo.Text += "\r\n";
            textBoxInfo.Text += "\r\n" + storeUser + " has highest sale at: " + highestSales.ToString("c");
        }

        private void btn_highest_Click(object sender, EventArgs e)
        {
            btn_highest.Enabled = false;
            displayHighest();
        }

        private void displayLowest()
        {
            int lowestSales = 150000;
            string storeUser = "";

            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 5; col++)
                {
                    if (lowestSales > salesDataNumbers[row, col])
                    {
                        lowestSales = salesDataNumbers[row, col];
                        storeUser = workerNames[row];
                    }
                }
            }

            textBoxInfo.Text += "\r\n";
            textBoxInfo.Text += "\r\n" + storeUser + " has lowest sale at: " + lowestSales.ToString("c");
        }

        private void btn_lowest_Click(object sender, EventArgs e)
        {
            btn_lowest.Enabled = false;
            displayLowest();
        }
    }
}
