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
using CsvHelper;
using LumenWorks.Framework.IO.Csv;
using CsvReader = LumenWorks.Framework.IO.Csv.CsvReader;


/*
 * 30023737
 * EROL A'NIL
 */
namespace CvsFiler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //Loads the file
        private void btnLoad_Click(object sender, EventArgs e)
        {
            using (CsvReader csv = new CsvReader(new System.IO.StreamReader("Users.csv"), true))
            {
              
            }
        }

        //adds the user input into  the list box
        private void btnAdd_Click(object sender, EventArgs e)
        {
          
        }

        //saves the list box into csv file
        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }

        //list box clear function
        private void btnClear_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
        }
    }
}
