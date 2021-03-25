using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GameApp
{
    public partial class GameForm : Form
    {//declared variables
        const int maxRow = 4, maxCol = 10;
        string[,] data = new string[maxRow, maxCol];        
        static string saveGameFile = "save.txt";
        private int emptyPtr = 0;        

        public GameForm()
        {
            InitializeComponent();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear(); // Clears the List Box to load a File
            BinaryReader br;
            try {
                if (File.Exists(saveGameFile)) //Tries to open the mybikes.dat file
                {
                    try
                    {//create new binary Reader indicating the save file 
                        br = new BinaryReader(File.Open(saveGameFile, FileMode.Open));

                        emptyPtr = 0;

                        for (int c = 0; c < maxCol; c++)
                        { // displays saved files in the list box
                            for (int r = 0; r < maxRow; r++)
                            {
                                data[r, c] = br.ReadString();
                                statusMsg.Items.Clear();
                                statusMsg.Items.Add("File Has Loaded");
                            }
                            emptyPtr++;
                            Display();
                            
                        }

                    }
                    catch (EndOfStreamException ex)
                    { // cathes error and informs the user
                        statusMsg.Items.Clear();
                        statusMsg.Items.Add("Pass the Error: End Of Stream Exception & File Has Loaded");
                        return;                        
                    }
                }
            }
            catch (IOException ed)
            {
                statusMsg.Items.Clear();
                statusMsg.Items.Add("Error: IOExcption and Can't Load the File");
                return;
            }
        }

        public void BubbleSort()// sort using the bubble sort (the swap is builtin)
        {
            for (int r = 0; r < emptyPtr; r++)
            {
                for (int c = 0; c < emptyPtr - 1; c++)
                {
                    if (data[0, c].CompareTo(data[0, c + 1]) > 0)
                    {
                        Swap(c);
                    }
                }
            }
        }

        public void Swap(int i)
        {
            for (int r = 0; r < maxRow; r++)
            {
                string temp = data[r, i];
                data[r, i] = data[r, i + 1];
                data[r, i + 1] = temp;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxTitle.Clear();
            textBoxPlatform.Clear();
            textBoxGenre.Clear();
            textBoxPublisher.Clear();
            statusMsg.Items.Clear();
            statusMsg.Items.Add("Text Boxes are Cleared");
        }

        public void Display()
        {
            listBox.Items.Clear();
            for (int c = 0; c < emptyPtr; c++)
            {
                listBox.Items.Add($"{data[0, c] + "\t" + data[1, c] + "\t" + data[2, c] + "\t" + data[3, c]}");
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

            string keyWord = textBoxTitle.Text;
            BSearch(data, keyWord);
        }

        public void BSearch(string[,] array, string keyWord)
        {// Declared variables for binary search
            int mid = 0;
            int low = 0;
            int high = emptyPtr - 1;
            Boolean found = false;
            string target = textBoxTitle.Text;

            if (!(string.IsNullOrEmpty(textBoxTitle.Text))) // if the Game Title text box is not empty
            {
                try
                {
                    while (found != true && low <= high) // loops it until it founds
                    {
                        
                        for (int i = 0; i < maxRow; i++) // goes through the maxtrix
                        {
                            if (data[i, mid] == target) // if finds it
                            {
                                found = true;
                                listBox.SetSelected(mid, found);// selects the row 
                                statusMsg.Items.Clear();
                                statusMsg.Items.Add("Found it " + data[i, mid]);                                
                            }
                            else // if not then passes the message to user
                            {                                
                                mid++;
                                low++;
                            }

                        }
                    }
                }
                
                catch (Exception c) // to prevent any errors
                {
                    statusMsg.Items.Clear();
                    statusMsg.Items.Add("Error");
                }
            }
            else // if the game title box is empty warns the user
            {
                MessageBox.Show("Insert the Game Title You'd like to Search");
            }
        }        
        

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            { //Binary witer to save the values inside the arrays
                using (BinaryWriter bw = new BinaryWriter(new FileStream(saveGameFile, FileMode.Create)))
                {
                    for (int c = 0; c < emptyPtr; c++)
                    {
                        for (int r = 0; r < maxRow; r++) {
                            bw.Write(data[r, c]);
                        }
                    }
                    //Shows Message that data has been saved
                    MessageBox.Show("Your File Has Saved", "Notification Message");
                    statusMsg.Items.Clear();
                    statusMsg.Items.Add("Your file is in save hands");
                    bw.Close();
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


        private void clearListBoxButton_Click(object sender, EventArgs e)
        {// clears everything
            textBoxTitle.Clear();
            textBoxPlatform.Clear();
            textBoxGenre.Clear();
            textBoxPublisher.Clear();
            listBox.Items.Clear();
            Array.Clear(data, 0, data.Length);
            emptyPtr = 0;
            statusMsg.Items.Clear();
            statusMsg.Items.Add("Text Boxes are Cleared");
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox.SelectedItem != null) // when item selected it appears on the text boxes
            {                
                textBoxTitle.Text = data[0,listBox.SelectedIndex];
                textBoxPlatform.Text = data[1,listBox.SelectedIndex];
                textBoxGenre.Text = data[2, listBox.SelectedIndex];
                textBoxPublisher.Text = data[3, listBox.SelectedIndex];
                statusMsg.Items.Clear();
                statusMsg.Items.Add("Selected Item Displays on Text Boxes");
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (emptyPtr >= maxCol) // if the list is on the capacity informs the user
            {
                MessageBox.Show("List is Full", "Important Information");
            }
            else// if there is a room adds to the list box
            {
                try
                {//if none of those textboxes are not empty adds to the list box
                    if (!(string.IsNullOrEmpty(textBoxTitle.Text)) &&
                        !(string.IsNullOrEmpty(textBoxPlatform.Text)) &&
                        !(string.IsNullOrEmpty(textBoxGenre.Text)) &&
                        !(string.IsNullOrEmpty(textBoxPublisher.Text)))
                    {                                                    
                        data[0, emptyPtr] = textBoxTitle.Text;
                        data[1, emptyPtr] = textBoxPlatform.Text;
                        data[2, emptyPtr] = textBoxGenre.Text;
                        data[3, emptyPtr] = textBoxPublisher.Text;
                        listBox.Items.Clear();
                        emptyPtr++;
                        BubbleSort();
                        Display();
                        statusMsg.Items.Clear();
                        statusMsg.Items.Add("Data Added to the List Box");
                    }
                    else// otherwise passes message
                    {
                        statusMsg.Items.Clear();
                        statusMsg.Items.Add("Please Enter the Data");
                    }
                    }                

                catch (FormatException ex) // catches errors 
                {
                    statusMsg.Items.Clear();
                    statusMsg.Items.Add("Trying to pass an Error");
                }
            }
        }
    }
}
