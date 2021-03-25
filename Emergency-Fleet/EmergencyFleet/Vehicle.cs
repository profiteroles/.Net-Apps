using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmergencyFleet
{
    class Vehicle
    {
        protected String vehicleID, make, model; //Declared Variable
        public Vehicle() { }//Default Constructor

        //all the getters & Setters
        public string getVehicleID()
        {
            return vehicleID;
        }

        public string getMake()
        {
            return make;
        }

        public string getModel()
        {
            return model;
        }

        public void setVehicleID(string vehicleID)
        {
            this.vehicleID = vehicleID;
        }

        public void setMake(string make)
        {
            this.make = make;
        }

        public void setModel(string model)
        {
            this.model = model;
        }
    }
}
