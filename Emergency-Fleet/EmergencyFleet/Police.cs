using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmergencyFleet
{// Derived class from Vehicle
    class Police : Vehicle
    {
        private String situationCode, type; //variables

        public Police() { } // Default constructor

        //overloaded Constructor
        public Police(string situationCode, string type)
        {
            this.situationCode = situationCode;
            this.type = type;
        }
        // Derived class from Animal
        public Police(string vehicleID, string make, string model, string situationCode, string type)
        {
            this.vehicleID = vehicleID;
            this.make = make;
            this.model = model;
            this.situationCode = situationCode;
            this.type = type;
        }
        //Accessor Methods
        public string GetSituationCode()
        {
            return situationCode;
        }

        public string GetPoliceType()
        {
            return type;
        }
    }
}
