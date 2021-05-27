using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace payroll
{
    class AVLtree
    {//root node
        Node root;
        class Node
        {
            //nodes and variables.
            public int data;
            public Node left;
            public Node right;

            //constructor
            public Node(int data)
            {
                this.data = data;
            }
        }
        public AVLtree() { }
        

        //inserts nodes to the tree
        public void Add(int data)
        {
            
        }

        //deletes the node
        private Node Delete(Node current, int target)
        {
            
                //right subtree
                else if (target > current.data)
                {
                }
                //if target is found
                else
                {
                    
                    }
                    else
                    {   //if current.left != null
                       
                    }
                }
            }
            return current;
        }

        //Finds the node
        public void Find(int key)
        {
          
        }

        //displays the right order in the list box
        private void InOrderDisplayTree(Node current)
        {
            
        }

        //Helps balancer if the tree is out of balance. { -1, 0, 1} 
        private int max(int l, int r)
        {
            
        }

        // height of the tree
        private int getHeight(Node current)
        {
            
        }

        //balace factor of the tree
        private int balance_factor(Node current)
        {
            
        }

        //if tree is right right heavy
        private Node RotateRR(Node parent)
        {
            
        }

        //if the tree is left left heavy
        private Node RotateLL(Node parent)
        {
           
        }

        //if the tree left Right Heavy
        private Node RotateLR(Node parent)
        {

        }

        //If tree Rigth left heavy
        private Node RotateRL(Node parent)
        {

        }

        //Display method
        public void DisplayTree()
        {
           
        }

        //Search function
        private Node Search (int target, Node current)
        {
           
        }

        //balanced insertion function
        private Node RecursiveInsert(Node current, Node n)
        {
            
        }

        //balances the tree
        private Node BalanceTree(Node current)
        {
            
            }
            else if (b_factor < -1)
            {
            }
        }


        //delete funtion
        public void Delete(int target)
        {
           
        }

    }
}
