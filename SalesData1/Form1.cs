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

        bool wasFileCreateBtnPressed = false;
        int[,] salesDataNumbers = new int[4, 5];
        string[] workerNames = new string[4];
        string[] daysOfWeek = new string[5];

        // button 1
        private void button1_Click(object sender, EventArgs e)
        {
            // bool to check if create file has been clicked
            wasFileCreateBtnPressed = true;
            createFile(wasFileCreateBtnPressed);
        }

        private void displaylabelTop()
        {
            textBoxInfo.Text += "-Sales Data-" + Environment.NewLine;
        }


        // button 2
        private void txtBoxBasicInfo_Click(object sender, EventArgs e)
        {
            // checks if user hits button 2 first then it deletes any file there and forces user to create
            if (wasFileCreateBtnPressed == false)
            {
                MessageBox.Show("Please click Create File button first.");
            }
            
            //createFile(wasFileCreateBtnPressed);

            if (wasFileCreateBtnPressed == true)
            {
                // displays header info first
                displaylabelTop();
                // gathers data first storing into arrays in a method
                storeAllData();
            }
        }

        private void createFile(bool isButton1clicked)
        {
            // path to write files
            string StartUpPath = Application.StartupPath;
            string fileLocation = StartUpPath + @"\salesdata.txt";

            // creates a file (this is needed so the application can be self-reliant)
            string[] fileData = {"100", "70", "80", "60", "70", "90",
                "100", "100", "90", "50", "70", "80", "90", "100", "51", "70", "75", "70", "80", "90",
                "Jim", "Kristina", "Darryl", "William", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday"};

            string fileCheck = fileLocation;
            if (File.Exists(fileCheck))
            {
                File.Delete(fileLocation);
            }

            if (isButton1clicked == false)
            {
                File.WriteAllLines(@fileLocation, fileData);
                MessageBox.Show("Data File Created!");
            }

            else if (!File.Exists(fileCheck))
            {
                File.WriteAllLines(@fileLocation, fileData);
                MessageBox.Show("Data File Created!");
                isButton1clicked = true;
            }

            else if (!File.Exists(fileCheck))
            {
                MessageBox.Show("Please click Create File button first.");
            }
        }

        private void storeAllData()
        {
            // path to read file
            string StartUpPath = Application.StartupPath;
            string fileLocation = StartUpPath + @"\salesdata.txt";

            // store all numeric data
            using (StreamReader read = new StreamReader(fileLocation))
            {
                // Read and display lines from the file until the end of
                // the file is reached.
                for (int row = 0; row < 4 ; row++)
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
                read.Close(); ;

                // call writeToDisplay here
            }
        }

        // write data to text box
        private void writeToDisplay(string[] names, int[] sales, int days)
        {
            // print days


            // print name and sales
        }
    }
}

// Display Sales (basic, all sales each day)
// Highest Total Sales for Everyone All Days
// Average Sales Total for Everyone
// Lowest Sale Day and Salesperson
// Highest Sales Day and Salesperson
// Total Sales Overall
