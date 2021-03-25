using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Drone
    {
        private string engine, range, accessory, price; // private variables

        public string gsEngine // getter and setter for engine variable
        {
            get { return engine; }
            set { engine = value; }
        }
        public string gsRange// getter and setter for range variable
        {
            get { return range; }
            set { range = value; }
        }
        public string gsAccessory// getter and setter for accessory variable
        {
            get { return accessory; }
            set { accessory = value; }
        }
        public string gsPrice// getter and setter for price variable
        {
            get { return price; }
            set { price = value; }
        }
    }
}
