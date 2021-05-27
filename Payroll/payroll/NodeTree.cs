using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace payroll
{
    class NodeTree<T>
    {
        //variables of the nodetree class
        public T Element { get; set; }
        public NodeTree<T> Left { get; set; }
        public NodeTree<T> Right { get; set; }


        //overriding the toString method to display in the list box
        public override string ToString()
        {
            
        }

        //class constructor
        public NodeTree(T element)
        {
            
        }



    }
}
