using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmergencyFleet
{
    class Medical : Vehicle
    {
        //declared Variable
        private int numPatients;

        public Medical() { } // default Constructor

        //overloaded constructor
        public Medical(string vehicleID, string make, string model, int numPatients)
        {
            this.vehicleID = vehicleID;
            this.make = make;
            this.model = model;
            this.numPatients = numPatients; 
        }

        //Getter & Setter for numPatients
        public int getNumPatients()
        {
            return numPatients;
        }
        //Just Setter for numPatients
        public void SetNumPatiencts(int numberOfPatients)
        {
            numPatients = numberOfPatients;
        }
}
}
