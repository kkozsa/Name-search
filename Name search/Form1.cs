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

namespace Name_search
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
              

        private void checkButton_Click(object sender, EventArgs e)
        {
            string[] boy_names = new string[200];       // Boy names array

            string[] girl_names = new string[200];      // Girl names array

            int indexb = 0;                 // Counter variable, different for boys and girls name.

            StreamReader boyinput;          // To read names from files
            StreamReader girlinput;

            boyinput = File.OpenText(@"C:\Users\KK\Desktop\DBS\Object oriented programming\CA\Name search\BoyNames.txt");

            while (indexb < boy_names.Length && !boyinput.EndOfStream)
            {
                boy_names[indexb] = boyinput.ReadLine();

                indexb++;

            }

            int indexg = 0;

            girlinput = File.OpenText(@"C:\Users\KK\Desktop\DBS\Object oriented programming\CA\Name search\GirlNames.txt");

            while (indexg < girl_names.Length && !girlinput.EndOfStream)
            {
                girl_names[indexg] = girlinput.ReadLine();

                indexg++; 

            }
                                   
            bool holdBoy = false;


            if (!string.IsNullOrEmpty(boyTextbox.Text))             // Check if boyTextbox is not empty
                for (int i = 0; i < boy_names.Length; i++) 
                {
                    if (boy_names[i] == boyTextbox.Text)            // Check if the name in the array matches the input
                    { 
                        holdBoy = true;
                        break;
                    }
                }
            if (holdBoy == true)
            {
                MessageBox.Show(boyTextbox.Text + " is a popular boy name");
            }
            else 
            {
                MessageBox.Show(boyTextbox.Text + " is not a popular boy name");
            }


            bool holdGirl = false;
            
            if (!string.IsNullOrEmpty(girlTextbox.Text))
                for(int i = 0; i < girl_names.Length; i++) 
                {
                    if (girl_names[i] == girlTextbox.Text)
                    { 
                        holdGirl = true; 
                        break;
                    }
                }
            if (holdGirl == true)
            {
                MessageBox.Show(girlTextbox.Text + " is a popular girl name");
            }
            else
            {
                MessageBox.Show(girlTextbox.Text + " is not a popular girl name");
            }

        }

        private void exitButton_Click(object sender, EventArgs e)       // Exit button
        {
            this.Close();
        }
    }
}
