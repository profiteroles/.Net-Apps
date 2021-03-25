using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmergencyFleet
{
    class Fire : Vehicle
    {// declared variables
        private string responseType, personnel;
        public Fire() { } // default Constructor

        //Overloaded Constructor        
        public Fire(string vehicleID, string make, string model,string responseType, string personnel)
        {
            this.vehicleID = vehicleID;
            this.make = make;
            this.model = model;
            this.responseType = responseType;
            this.personnel = personnel;
        }
        //getters for the private variables
        public string getResponseType()
        {
            return responseType;
        }

        public string getPersonnel()
        {
            return personnel;}
        }

    }

