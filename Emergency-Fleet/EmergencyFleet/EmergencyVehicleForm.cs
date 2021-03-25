using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmergencyFleet
{
    public partial class EmergencyVehicleForm : Form
    {
        public EmergencyVehicleForm()
        {
            InitializeComponent();
        }

        static int max = 10;
        Vehicle[] vehicles = new Vehicle[max];
        int emptyPtr = 0;

        private void listBoxVehicle_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DisplayAllVehicles()
        {
            listBoxVehicle.Items.Clear();// clears the listbox
            for (int i = 0; i < emptyPtr; i++)// adds to the list 
            {
                if (vehicles[i].GetType() == typeof(Police))//if its input to related to police class adds to that
                {
                    Police displayPolice = (Police)vehicles[i];
                    //displays data on listbox
                    listBoxVehicle.Items.Add("Vehicle ID: " + displayPolice.getVehicleID() + " Make: " 
                        + displayPolice.getMake() + " Model: " + displayPolice.getModel() 
                        + " Situation Code: " + displayPolice.GetSituationCode()
                        + " Type: " + displayPolice.GetPoliceType());
                }
                if (vehicles[i].GetType() == typeof(Fire))//if its input to related to Fire class adds to that
                {
                    Fire displayFire = (Fire)vehicles[i];
                    //displays data on listbox
                    listBoxVehicle.Items.Add("Vehicle ID: " + displayFire.getVehicleID() + " Make: " 
                        + displayFire.getMake() + " Model: " + displayFire.getModel() + " Response Type: " 
                        + displayFire.getResponseType() + " Personnel: " + displayFire.getPersonnel());
                }
                if (vehicles[i].GetType() == typeof(Medical))//if its input to related to Medical class adds to that
                {
                    Medical displayMedical = (Medical)vehicles[i];
                    //displays data on listbox
                    listBoxVehicle.Items.Add("Vehicle ID: " + displayMedical.getVehicleID() + " Make: "
                        + displayMedical.getMake() + " Model: " + displayMedical.getModel() + 
                        " Number Of Patients: " + displayMedical.getNumPatients());
                }
            }
        }

        //Function : Clears All the Boxes 
        private void ClearAllBoxes()
        {
            vehicleIDBox.Clear();
            modelBox.Clear();
            makeBox.Clear();
            situationCodeBox.Clear();
            typeBox.Clear();
            responseTypeBox.Clear();
            personnelBox.Clear();
            numberPatientsBox.Clear();
        }


        private void addPoliceButton_Click(object sender, EventArgs e)
        {
            if (emptyPtr >= max) //if array is full shows the message below
            {
                MessageBox.Show("Array is full");
            }
            else
            {//if those main boxes are not empty adds police vehicle to the empty parametter
                try { 
                if (!(string.IsNullOrEmpty(vehicleIDBox.Text)) &&
                    !(string.IsNullOrEmpty(makeBox.Text)) &&
                    !(string.IsNullOrEmpty(modelBox.Text)))
                {//addPolice function adds to the police class
                    Police addPolice = new Police(vehicleIDBox.Text, makeBox.Text, 
                        modelBox.Text, situationCodeBox.Text, typeBox.Text);
                    
                    vehicles[emptyPtr] = addPolice;
                    emptyPtr++;
                }
                else//if its empty shows this message
                {
                    MessageBox.Show("Please Check Police Vehicle Information!");
                }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("List is Full");
                }
            }
            DisplayAllVehicles(); // shows input data on listbox
            ClearAllBoxes(); // clear boxes
        }

        private void policeOverloadButton_Click(object sender, EventArgs e)
        {//Overloaded information adds on the listbox
            try
            {
                Police addPolice = new Police("POLVHC001", "Ford", "Falcon", "000", "Emergency");
                vehicles[emptyPtr] = addPolice;
                emptyPtr++;
                DisplayAllVehicles();
                ClearAllBoxes();
            }catch(Exception ex)
            {
                MessageBox.Show("List is Full");
            }
        }

        private void addFireButton_Click(object sender, EventArgs e)
        {
            if (emptyPtr >= max)//if array is full shows the message below
            {
                MessageBox.Show("Array is full");
            }
            else
            {//if those main boxes are not empty adds Fire vehicle to the empty parametter
                try { 
                if (!(string.IsNullOrEmpty(vehicleIDBox.Text)) &&
                    !(string.IsNullOrEmpty(makeBox.Text)) &&
                    !(string.IsNullOrEmpty(modelBox.Text)))
                {
                    Fire addFire = new Fire(vehicleIDBox.Text, makeBox.Text,
                        modelBox.Text, responseTypeBox.Text, personnelBox.Text);

                    vehicles[emptyPtr] = addFire;
                    emptyPtr++;
                }
                else
                {
                    MessageBox.Show("Please Check Fire Vehicle Information!");
                }
            }catch (Exception ex)
            {
                MessageBox.Show("List is Full");
            }
        }
            DisplayAllVehicles();
            ClearAllBoxes();
        }

        private void fireOverloadButton_Click(object sender, EventArgs e)
        {//Overloaded information adds on the listbox
            try { 
            Fire addFire = new Fire("FIREVHC001", "Suzuki", "Truck", "Emergency 000", "FireMan");
            vehicles[emptyPtr] = addFire;
            emptyPtr++;
            DisplayAllVehicles();
            ClearAllBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("List is Full");
            }
        }

        private void addMedicalButton_Click(object sender, EventArgs e)
        {
            if (emptyPtr >= max)//if array is full shows the message below
            {
                MessageBox.Show("Array is full");
            }
            else//if those main boxes are not empty adds Medical vehicle to the empty parametter
            {
                try
                {//if those main boxes are not empty adds Fire vehicle to the empty parametter
                    if (!(string.IsNullOrEmpty(vehicleIDBox.Text)) &&
                        !(string.IsNullOrEmpty(makeBox.Text)) &&
                        !(string.IsNullOrEmpty(modelBox.Text)) &&
                        !(string.IsNullOrEmpty(numberPatientsBox.Text)))
                    {
                        Medical addMedical = new Medical(vehicleIDBox.Text, makeBox.Text,
                            modelBox.Text, int.Parse(numberPatientsBox.Text));

                        vehicles[emptyPtr] = addMedical;
                        emptyPtr++;
                    }
                    else
                    {
                        MessageBox.Show("Please Check Medical Vehicle Details!");
                    }
                } catch(FormatException ex)
                {//Catches the user input if they put else other number for the Number of Patients.
                    MessageBox.Show("Please enter number of patients");
                }
            catch (Exception ex)
            {
                MessageBox.Show("List is Full");
            }
            DisplayAllVehicles();
                ClearAllBoxes();
            }
        }

        private void medicalOverloadButton_Click(object sender, EventArgs e)
        {//Overloaded information adds on the listbox
            try { 
            Medical addMedical = new Medical("MEDVHC001", "Ford", "Falcon", 2);
            vehicles[emptyPtr] = addMedical;
            emptyPtr++;
            DisplayAllVehicles();
            ClearAllBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("List is Full");
            }
        }
    }    
}
