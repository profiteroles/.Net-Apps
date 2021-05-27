using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace AceDrones
{
    public partial class AceDronesForm : Form
    {
        public AceDronesForm()
        {
            InitializeComponent();
        }
        //variables
       
        //saved data file
   
        //class arrays
        private Drone[] drones = new Drone[maxArrayNo];
        private Customer[] customers = new Customer[maxArrayNo];
        private string[,] trans = new string[maxArrayNo, 3];

        //when the add button clicks
        private void buttonAddDrone_Click(object sender, EventArgs e)
        {
            if (emptyPtrDrone < maxArrayNo)
            {// indicates if its not empty
              
                }
                else // warns user about invalid input data
                {
                    MessageBox.Show("Please Fill the all the boxes", "Warning Message");
                    statusMsg.Items.Clear();
                    statusMsg.Items.Add("Invalid Data");
                    Console.WriteLine("User Tired to put Invalid Data to the boxes");
                }
            }
            else // indicates user if the the list is full
            {
             
            }
            
        }
        //display methods for drones
      
        {
            //new drone 
           

           }
            //clears the Items in the listbox to add new one
           
        //if the item gets selected 
        private void listBoxDrones_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
        //displays selected customer on the relevant text boxes
        private void listBoxCust_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
        //displays the selected transactions to all of the text boxes
        private void listBoxTrans_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        //drone binary search method
        private void droneSearch()
        {//declared variables 
            
        }

        //add customer when add customer button clicks
        private void buttonAddCust_Click(object sender, EventArgs e)
        {
           
            }
            else
            {
                statusMsg.Items.Clear();
                statusMsg.Items.Add("Customer list is full");
            }
            clearBoxesCust();
            displayCustomer();
        }
        //remove function
        private void custRemove()
        {
            
        }
        //deletes the element from customer array
        static int deleteElement(Customer[] arr,
                              int n, string x)
        {
            
        }

        //customer search method
        private void custSearch()
        {
            
        }

        //Binary search for transactions
        private void searchTrans()
        {
            
        }

        //display function for customer
        private void displayCustomer()
        {
            
            }

            listBoxCust.Items.Clear();
            for (int i = 0; i < emptyPtrCust; i++)
            {
                Customer tempCust = customers[i];
                listBoxCust.Items.Add($"{tempCust.CustID}\t{tempCust.Name}\t{tempCust.City}");
            }
        }

        //when add transaction button clicks
        private void buttonAddTrans_Click(object sender, EventArgs e)
        {
           
            }
            else
            {
 	    }

        }


        //display method for transactions
        private void displayTrans()
        {
            string dispTrans;
           
            }
            listBoxTrans.Items.Clear();
            for (int i = 0; i < emptyPtrTrans; i++)
            {
                listBoxTrans.Items.Add($"   {trans[i, 0]}\t{trans[i, 1]}\t{trans[i, 2]}");
            }
        }
        //clear all the boxes of drone group
        private void clearBoxesDrone()
        {
            
        }

        //when customer id text box double clicks
        private void textBoxCustID_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        //when transaction id text box double clicks 
        private void textBoxTransID_DoubleClick(object sender, EventArgs e)
        {
           
        }

        //when customer id text box right clicks
        private void searchCustomerIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        
        //double click on customer list box deletes the selected element in the array
        private void listBoxCust_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        //clear boxes function for customer
        private void clearBoxesCust()
        {
            
        }

        //clear boxes function for transaction
        private void clearBoxesTrans()
        {
           
        }

        //clear all the boxes on the window
        private void clearBoxesAll()
        {
           
        }

        //save to file method for drones when user exits the program
        private void saveDrones()
        {
            
            }
            catch (IOException)
            {
                MessageBox.Show("System Could't Save the Drones, Please Do not Close", "Warning Message");
                return;
            }            
        }
        //save function for all the elements in the transaction array
        private void saveTrans()
        {
           
            }
            catch (IOException)
            {
                
            }
        }

        //method saved all the elements in the customer array
        private void saveCust()
        {
           
            }
            catch (IOException)
            {
               
            }
        }

        
        //loading method for drones
        private void loadDrones()
        {
           
            }
            catch (IOException io)
            {
                MessageBox.Show("Issue with reading Drones");
                Console.WriteLine("Issue: " + io);
            }catch(FormatException e)
            {
                MessageBox.Show("Different format to ready");
                Console.WriteLine("Issue: " + e);
            }
        }

        //when the program starts loads the existing files
        private void AceDronesForm_Load(object sender, EventArgs e)
        {
           
        }
        //mouse hover info for customer id text box
        private void textBoxCustID_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip Tip = new System.Windows.Forms.ToolTip();
            Tip.SetToolTip(this.textBoxCustID, "Double Click to Clear the Boxes\nRight click to search");
        }
        
        //clears all the boxes of drones on double click to model text box
        private void textBoxModel_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           
        }

        //////// all the hover over methods provides info to user//////////////
        private void groupBox1_MouseHover(object sender, EventArgs e)
        {

        }

        private void listBoxDrones_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void buttonAddDrone_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void buttonAddCust_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void buttonAddTrans_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void textBoxTCustID_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void textBoxTSerialNo_MouseHover(object sender, EventArgs e)
        {

        }

        private void textBoxTransID_MouseHover(object sender, EventArgs e)
        {
          
        }

        private void listBoxTrans_MouseHover(object sender, EventArgs e)
        {

        }

        private void listBoxCust_MouseHover(object sender, EventArgs e)
        {
            
        }
                
        private void textBoxSerialNo_MouseHover(object sender, EventArgs e)
        {

        }
     
        //////////////////////////////////////////////////////////////////////////////
        

        //this method doesnt work its because serial no text box is read only
        private void textBoxSerialNo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           
        }

        //loads customers when the program starts
        private void loadCust()
        {
            
        }

        //loads transactions when the program starts
        private void loadTrans()
        {
            
            }
            catch (IOException e)
            {
                MessageBox.Show("Issue Occoured While Loading Transactions", "Warning Message");
                Console.WriteLine("issue: " + e);
            }
        }
        //warns user if they wish to save to file all the input data
        private void AceDronesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}