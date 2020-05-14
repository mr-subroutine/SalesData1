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
        string[] workerNames = new string[4];
        string[] daysOfWeek = new string[5];
        int[,] salesDataNumbers = new int[3, 4];

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
            if (isButton1clicked == true && !File.Exists(fileLocation))
            {
                File.WriteAllLines(@fileLocation, fileData);
                MessageBox.Show("Data File Created!");
            }


            else if (!File.Exists(fileCheck) && isButton1clicked == true)
            {
                File.WriteAllLines(@fileLocation, fileData);
                MessageBox.Show("Data File Created!");
            }

            else if (!File.Exists(fileCheck))
            {
                MessageBox.Show("Please click Create File button first.");
            }
        }

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

        private void txtBoxBasicInfo_Click(object sender, EventArgs e)
        {
            createFile(wasFileCreateBtnPressed);
            // checks if user hits button 2 first then it deletes any file there and forces user to create
            if (wasFileCreateBtnPressed == false)
            {
                string StartUpPath = Application.StartupPath;
                string fileLocation = StartUpPath + @"\salesdata.txt";
                File.Delete(fileLocation);
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
                for (int row = 0; row < 3 ; row++)
                {
                    for (int col = 0; col < 4; col++)
                    {
                        salesDataNumbers[row, col] = Convert.ToInt32(read.ReadLine());
                    }
                }

                for (int row = 0; row < 4; row++)
                {

                }
            }

            // store employee names


            // store days of week
        }
    }
}
