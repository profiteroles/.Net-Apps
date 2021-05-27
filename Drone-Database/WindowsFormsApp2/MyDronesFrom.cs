using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class MyDronesFrom : Form
    {

        static int maxSize = 10, emptyPtr = 0;
        Drone[] drone = new Drone[maxSize];
                            
        public MyDronesFrom()
        {
            InitializeComponent();
        }

        private void display() // function for displays input data on the list box
        {
          
                drone[emptyPtr] = new Drone();
                drone[emptyPtr].gsEngine = textBoxEngine.Text;
                drone[emptyPtr].gsRange = textBoxRange.Text;
                drone[emptyPtr].gsAccessory = textBoxAcc.Text;
                drone[emptyPtr].gsPrice = textBoxPrice.Text;
                listBox.Items.Add($"{drone[emptyPtr].gsEngine} {drone[emptyPtr].gsRange} { drone[emptyPtr].gsAccessory} { drone[emptyPtr].gsPrice}");
            statusMsg.Items.Clear();
            statusMsg.Items.Add(drone[emptyPtr].gsEngine + " Drone Added to the List");
                
                emptyPtr++;
            
        }

        private void clearAll() // function to clear all the boxes 
        {
            textBoxEngine.Clear();
            textBoxRange.Clear();
            textBoxAcc.Clear();
            textBoxPrice.Clear();
            statusMsg.Items.Clear();
            listBox.Items.Clear();
        }

        private void textBoxClear() // function to clear to all the text Boxes
        {
            textBoxEngine.Clear();
            textBoxRange.Clear();
            textBoxAcc.Clear();
            textBoxPrice.Clear();
        }

        private void listBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listBox.SelectedItem != null) // if any of the items are selected transforms to the belonging textbox
            {
                textBoxEngine.Text = drone[listBox.SelectedIndex].gsEngine;
                textBoxRange.Text = drone[listBox.SelectedIndex].gsRange;
                textBoxAcc.Text = drone[listBox.SelectedIndex].gsAccessory;
                textBoxPrice.Text = drone[listBox.SelectedIndex].gsPrice;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(string.IsNullOrEmpty(textBoxEngine.Text))) // if the box is full does the function below
                {       
                    display(); // add item to the list box
                    textBoxClear(); // clear all the textboxes
                }
                else // indicates that there is no data to place in listbox
                {
                    MessageBox.Show("Please enter the Details");
                }
            } catch (IndexOutOfRangeException ex) // cathes the error when array gets full
            {
                clearAll();
                MessageBox.Show("List is full will clear all");
                emptyPtr = 0; // paramatter goes back to 0 to start from the very beginning
            }
        }
    }
}

