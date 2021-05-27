using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace payroll
{
    public partial class PayrollForm : Form
    {
        public PayrollForm()
        {
            InitializeComponent();
        }

        //new string tree
        BinaryTree<string> tree = new BinaryTree<string>();

        //insert nodes to the list
        private void InsertBtn_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(TextField.Text)))
            {
                
            }
            else
            
        }

        //display all the nodes
        public void DisplayTree()
        {
            
        }


        //delete function deletes the node 
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
           
        }


        //searching method finds the node 
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            i
        }


        //reset function clears node
        private void ResetBtn_Click(object sender, EventArgs e)
        {

        }
    }
    }

