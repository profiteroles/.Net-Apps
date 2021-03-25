using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices.WindowsRuntime;

namespace MotorbikeCollection
{
    public partial class MotorbikeForm : Form
    {
        //All the declared Variables listed here
        static int maxSize = 15;
        int arrayNum, emptyPtr = 0, total, comparisonCounter = 0;
        string[] make = new string[maxSize];
        string[] model = new string[maxSize];
        int[] cost = new int[maxSize];
        string[] sum = new string[maxSize];
        static string savedFile = "mybikes.dat"; // File will be saved in local bin folder

        public MotorbikeForm()
        {
            InitializeComponent();
        }

        // This method will display all the values in the array
        // and the number of array elements with data
        private void displayArray()
        {
            ListBoxOutput.Items.Clear();
            for (int x = 0; x < emptyPtr; x++)
            {
                ListBoxOutput.Items.Add(make[x] + " " + model[x] + " " + cost[x]); // list box output
            }
            textBoxMake.Text = emptyPtr.ToString();
            textBoxModel.Text = emptyPtr.ToString();
            textBoxCost.Text = emptyPtr.ToString();
        }
        //Sorts all the Arrays
        private void sortArrays()
        {
            Array.Sort(make, 0, emptyPtr);
            Array.Sort(model, 0, emptyPtr);
            Array.Sort(cost, 0, emptyPtr);
        }
        
        private void totalSum()
        {
            total = cost.Sum(); // calculates the total amount of cost bikes
            textBoxTotal.Text = total.ToString(); // Displays on total text box
        }
        //Function adds value to listbox when add button clicked
        private void addList()
        {
            try
            {
                if (!(string.IsNullOrEmpty(textBoxMake.Text)) // When Text Boxes are filled apply this
                   || !(string.IsNullOrEmpty(textBoxModel.Text)) || !(string.IsNullOrEmpty(textBoxCost.Text)))
                {
                    for (int i = 0; i <= maxSize; i++)// Loops this to the Max size 
                    {
                        if (cost[i] == 0) // add values into arrays 
                        {
                            // Next 3 arrays are the user inputs

                            make[i] = textBoxMake.Text;
                            model[i] = textBoxModel.Text;
                            cost[i] = int.Parse(textBoxCost.Text);
                            emptyPtr++; // counts the premeters
                            totalSum();
                            
                            break;
                        }
                    }
                }
                else // if the text box are empty shows this error message
                {
                    MessageBox.Show("Please Enter the details", "Error Message");
                }
                //Clears all the data after adding them to list box 
                sortArrays();
                displayArray();
                textBoxCost.Clear();
                textBoxModel.Clear();
                textBoxMake.Clear();
                statusMsg.Items.Clear();
                statusMsg.Items.Add("New Item Added to the List Box");
                // when list reaches to limit error message comes out
                } catch (FormatException ex)
            {
                statusMsg.Items.Clear();
                statusMsg.Items.Add("Please Type Number to Cost");
            }
            if (emptyPtr == maxSize) // stop when reaches the maximum size of the array
            {
                MessageBox.Show("The List is full", "Error Message");
                statusMsg.Items.Clear();
                statusMsg.Items.Add("ListBox Currently is Full. Please Reset to Add New Items");
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            addList();
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            // Clears all the text boxes
            textBoxMake.Clear();
            textBoxModel.Clear();
            textBoxCost.Clear();
            textBoxTotal.Clear();
            statusMsg.Items.Clear();
            statusMsg.Items.Add("Text Boxes are Cleared");
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            //clear all the 3 arrays
            Array.Clear(make, 0, make.Length);
            Array.Clear(model, 0, model.Length);
            Array.Clear(cost, 0, cost.Length);
            ListBoxOutput.Items.Clear();// clears the listbox
            emptyPtr = 0; // start from the 0 
            statusMsg.Items.Clear();
            statusMsg.Items.Add("Everything reset. We're starting from 0");
        }

        private void ListBoxOutput_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBoxOutput.SelectedItem != null) // when item selected it appears on the text boxes
            {
                textBoxMake.Text = make[ListBoxOutput.SelectedIndex];
                textBoxModel.Text = model[ListBoxOutput.SelectedIndex];
                textBoxCost.Text = cost[ListBoxOutput.SelectedIndex].ToString();
                statusMsg.Items.Clear();
                statusMsg.Items.Add("Selected Item Displays on Text Boxes");
            }
        }
        
        private void buttonBSearch_Click(object sender, EventArgs e)
        {
            //Binary search for model if the model text box empty
            if (!(string.IsNullOrEmpty(textBoxModel.Text)))

            {//index declared as and integer and searches in the array
                int index = Array.BinarySearch(model, 0, emptyPtr, textBoxModel.Text);

                if (index > -1)
                { // if targeted item found show this message
                    statusMsg.Items.Clear();
                    statusMsg.Items.Add("Your Search is on the Blue Line Section");
                    MessageBox.Show("Your Model has been Found. Check Blue Section on the List Box", "Notification Message");
                    ListBoxOutput.SetSelected(index, true); // points out he searched item in the list box
                }
                else
                { // if searched item has not found display this message
                    statusMsg.Items.Clear();
                    statusMsg.Items.Add("Model Could NOT Find");
                    MessageBox.Show("Searchg is successful but Item has NOT Found", "Error Message");
                    return;
                } 
            } else
            { // If Model Text box is empty displays this message
                statusMsg.Items.Clear();
                statusMsg.Items.Add("Enter the Model to Make Search");
                MessageBox.Show("Please Enter the Model", "Error Message");
                return;
            }
        }

            private void buttonLS_Click(object sender, EventArgs e)
        {
            bool found = false;
            string target = textBoxModel.Text;
            //Searches all the arrays premeters
            for(int x = 0; x <= emptyPtr; x++)
            {
                comparisonCounter++; // calculates the amount loops to indicate for the user
                if (string.IsNullOrEmpty(target)) // Model box empty shows this message
                {
                    statusMsg.Items.Clear();
                    statusMsg.Items.Add("Fill Model Text Box");
                    MessageBox.Show("Please Enter the data", "Error Message");
                    return;
                }
                
                else if (model[x] == target) // if target search finds displays this message 
                {
                    textBoxMake.Text = make[x]; // fills ups the text boxes with the information
                    textBoxModel.Text = model[x];
                    textBoxCost.Text = cost[x].ToString();
                    statusMsg.Items.Clear();
                    statusMsg.Items.Add("Model has Found");
                    MessageBox.Show("We've Found your \" " + target + " \" Model" + "\r\n" +
                        "Check Column " + (x + 1) + " On The List List Box", "Good News Message");
                    found = true;
                }
            }

            if (!found) // if search is not successfull display this message
            {
                statusMsg.Items.Clear();
                statusMsg.Items.Add("Model Could NOT Find");
                MessageBox.Show("Unfortunately We Could NOT Find" + "\r\n" +
                    " What You've Been Searching For" + "\r\n" +
                    "Number of comparisons " + comparisonCounter, "Bad News Message");
                textBoxModel.Clear();
                
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            { //Binary witer to save the values inside the arrays
                using (BinaryWriter bw = new BinaryWriter(new FileStream(savedFile, FileMode.Create)))
                {
                    for (int x = 0; x < emptyPtr; x++)
                    {
                        bw.Write(make[x]);
                        bw.Write(model[x]);
                        bw.Write(cost[x]);
                    }
                    //Shows Message that data has been saved
                    MessageBox.Show("Your File Has Saved", "Notification Message");
                    statusMsg.Items.Clear();
                    statusMsg.Items.Add("Your file is in save hands");
                }
            }
            catch // catches an error if data is missing on the list box
            {
                MessageBox.Show("Enter the data to save it", "Error Message");
                statusMsg.Items.Clear();
                statusMsg.Items.Add("Data Need to be on the List Box to Save it!!!");
                return;
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            ListBoxOutput.Items.Clear(); // Clears the List Box to load a File

            if (File.Exists(savedFile)) //Tries to open the mybikes.dat file
            {
                try
                {
                    BinaryReader br = new BinaryReader(File.Open(savedFile, FileMode.Open));
                    int fileLength = (int)br.BaseStream.Length / 3; // divides by 3 as we have 3 arrays
                    emptyPtr = 0;// starts from the 0 premeter
                    for (int x = 0; x < fileLength; x++) // it goes to size of the file length
                    { // displays saved files in the list box
                        make[x] = br.ReadString(); 
                        model[x] = br.ReadString();
                        cost[x] = br.ReadInt32();
                        ListBoxOutput.Items.Add(make[x] + " " + model[x] + " " + cost[x]);
                        emptyPtr++;
                        statusMsg.Items.Clear();
                        statusMsg.Items.Add("File Has Loaded");
                    }

                } catch (EndOfStreamException ex)
                { // cathes error and informs the user
                    statusMsg.Items.Clear();
                    statusMsg.Items.Add("Pass the Error: End Of Stream Exception");
                }

                catch (Exception ex)
                { // cathes the user error below and inform to them with instructions 
                    MessageBox.Show("You Have Tried to Reload the File. Please Reset the Program & Reload Your Saved File Again", "Error Message");
                    statusMsg.Items.Clear();
                    statusMsg.Items.Add("Issue with Loading the file");
                }
                sortArrays(); // Sorts the Array again
            }
        }
    }
}
