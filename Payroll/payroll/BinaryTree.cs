using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace payroll
{
    class BinaryTree<T>
    {

        //class constructor
        public BinaryTree()
        { this.Root = null; }

        //the root of the tree 
        public NodeTree<T> Root { get; set; }


        //insert function
        public void Insert(T x)
        { this.Root = Insert(x, this.Root); }

        //search funtion
        public T Search(T x)
        { return ElementAt(Search(x, this.Root)); }

        //delete function
        public void Delete(T x)
        { this.Root = DeleteNode(x, this.Root); }

        //reset function
        public void Reset()
        { this.Root = null; }

        //element to to search
        private T ElementAt(NodeTree<T> t)
        { return t == null ? default(T) : t.Element; }

        //insertion of node 
        protected NodeTree<T> Insert(T x, NodeTree<T> t)
        {
            try
            {
                i
            }
            catch(Exception e)
            {
                
            }
            return t;
        }

        //searchs thru node
        private NodeTree<T> Search(T x, NodeTree<T> t)
        {
            
        }

        //gets rid of the lower value
        protected NodeTree<T> EraseLow(NodeTree<T> t)
        {
            
        }
        

        //deletes the Node
        protected NodeTree<T> DeleteNode(T x, NodeTree<T> t)
        {
            try
            {
                
            } catch (Exception e)
            {
                Console.WriteLine("Cought an Error While Removing the Item Error is: " + e);

                return null;
            }
        }

        //Finds the lowest value
        private NodeTree<T> FindLow(NodeTree<T> t)
        {
           
        }

        //gets empty string to display in the list box
        public override string ToString()
        {
           
        }
    }
}
