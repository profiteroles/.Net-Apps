using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IoT_Logic
{
    public partial class LogicForm : Form
    {
        public LogicForm()
        {
            InitializeComponent();
        }
        // false: light is OFF 
        // true: light is ON
        bool office1_Status = false;
        bool office2_Light_Status = false;
        bool toilet2_Light_Status = false;
        bool toilet1_Light_Status = false;
        bool kitchen_Light_Status = false;
        bool passage_1_Light_Status = false;
        bool passage_2_Light_Status = false;
        bool dining_Light_Status = false;
        bool reception_Light_Status = false;
        bool entrance_Light_Status = false;

        // switch the light in dining area on and off
        private void Dining_Switch_Click(object sender, EventArgs e)
        {
            if (dining_Light_Status) 
            {
                Dining_Light.Image = Properties.Resources.off;
                dining_Light_Status = false;
            }
            else
            {
                Dining_Light.Image = Properties.Resources.on;
                dining_Light_Status = true;
            }
           
        }
        // switch the light in reception on and off
        private void Reception_Switch_Click(object sender, EventArgs e)
        {
            if (!(reception_Light_Status))
            {
                Reception_Light.Image = Properties.Resources.on;
                reception_Light_Status = true;
            }
            else
            {
                Reception_Light.Image = Properties.Resources.off;
                reception_Light_Status = false;
            }
            
        }
        // switch the light in entrance on and off (includes Reception off)
        private void Entrance_Switch_Click(object sender, EventArgs e)
        {
            if (entrance_Light_Status || reception_Light_Status)
            {
                Entrance_Light.Image = Properties.Resources.off;
                Reception_Light.Image = Properties.Resources.off;
                entrance_Light_Status = false;
                reception_Light_Status = false;
            }
            else if (!(entrance_Light_Status) && reception_Light_Status)
            {
                Entrance_Light.Image = Properties.Resources.off;
                Reception_Light.Image = Properties.Resources.off;
                entrance_Light_Status = false;
                reception_Light_Status = false;
            }
            else
            {
                Entrance_Light.Image = Properties.Resources.on;
                entrance_Light_Status = true;
            }
        }
        // master switch for Dining Area, Reception and Enterance
        private void Master_Switch_Click(object sender, EventArgs e)
        {
            if (dining_Light_Status || reception_Light_Status || entrance_Light_Status)
            {
                Dining_Light.Image = Properties.Resources.off;
                Reception_Light.Image = Properties.Resources.off;
                Entrance_Light.Image = Properties.Resources.off;
                dining_Light_Status = false;
                reception_Light_Status = false;
                entrance_Light_Status = false;
            }                      
        }

        // switch the light on and off for Office One
        private void Office1_Switch_Click(object sender, EventArgs e)
        {
            if (office1_Status == false)
            {
                Office1_Light1.Image = Properties.Resources.on;
                Office1_Light2.Image = Properties.Resources.on;
                office1_Status = true;
            }
            else
            {
                Office1_Light1.Image = Properties.Resources.off;
                Office1_Light2.Image = Properties.Resources.off;
                office1_Status = false;
            }
        }
        // switch the light on and off for Toilet One
        private void Toilet1_Switch_Click(object sender, EventArgs e)
        {
            if (toilet1_Light_Status)
            {
                Toilet1_Light.Image = Properties.Resources.off;
                toilet1_Light_Status = false;
            }
            else
            {
                Toilet1_Light.Image = Properties.Resources.on;
                toilet1_Light_Status = true;
            }
        }             
        // switch the light on and off for Kitchen
        private void Kitchen_Switch_Click(object sender, EventArgs e)
        {
            if (kitchen_Light_Status)
            {
                Kitchen_Light.Image = Properties.Resources.off;
                kitchen_Light_Status = false;
            }
            else
            {
                Kitchen_Light.Image = Properties.Resources.on;
                kitchen_Light_Status = true;
            }
        }        
        // switch the light on and off for Toilet Two
        private void Toilet2_Switch_Click(object sender, EventArgs e)
        {
            if (toilet2_Light_Status)
            {
                Toilet2_Light.Image = Properties.Resources.off;
                toilet2_Light_Status = false;
            }
            else
            {
                Toilet2_Light.Image = Properties.Resources.on;
                toilet2_Light_Status = true;
            }
        }
        // switch the light on and off for Office Two and Toilet Two
        private void Office2_Switch_Click(object sender, EventArgs e)
        {
            if (office2_Light_Status)
            {
                Office2_Light.Image = Properties.Resources.off;
                Toilet2_Light.Image = Properties.Resources.off;
                office2_Light_Status = false;
                toilet2_Light_Status = false;
            }
            else
            {
                Office2_Light.Image = Properties.Resources.on;
                office2_Light_Status = true;
                toilet2_Light_Status = false;
            }
        }

        // switch for lights in passage_1 switch
        // this logic is correct and should no be changed
        private void Passage_1_Switch_Click(object sender, EventArgs e)
        {
            if (passage_1_Light_Status || passage_2_Light_Status)
            {
                Passage_Light_A.Image = Properties.Resources.off;
                Passage_Light_B.Image = Properties.Resources.off;
                Passage_Light_C.Image = Properties.Resources.off;
                passage_1_Light_Status = false;
                passage_2_Light_Status = false;
            }
            else if (passage_1_Light_Status)
            {
                Passage_Light_A.Image = Properties.Resources.off;
                Passage_Light_B.Image = Properties.Resources.off;
                passage_1_Light_Status = false;
            }
            else
            {
                Passage_Light_A.Image = Properties.Resources.on;
                Passage_Light_B.Image = Properties.Resources.on;
                passage_1_Light_Status = true;
            }
        }
        // switch for lights in passage_2 switch
        // This light is faulty, check the pseudo code 
        // and correct the logic errors.
        private void Passage_2_Switch_Click(object sender, EventArgs e)
        {
            //  PassageLight_2 OFF && PassageLight_1 ON
            if (!(passage_2_Light_Status) && passage_1_Light_Status)
            {
                // Turn on PassageLight
                Passage_Light_A.Image = Properties.Resources.on;
                Passage_Light_B.Image = Properties.Resources.on;
                Passage_Light_C.Image = Properties.Resources.off;
                passage_1_Light_Status = true;
                passage_2_Light_Status = true;
            }
            // PassageLight_2 ON && PassageLight_1 ON
            else if (passage_2_Light_Status && passage_1_Light_Status)
            {
                Passage_Light_A.Image = Properties.Resources.off;
                Passage_Light_B.Image = Properties.Resources.on;
                Passage_Light_C.Image = Properties.Resources.off;
                passage_1_Light_Status = false;
                passage_2_Light_Status = false;
            }
            else
            {
                Passage_Light_A.Image = Properties.Resources.off;
                Passage_Light_B.Image = Properties.Resources.on;
                Passage_Light_C.Image = Properties.Resources.on;
                passage_1_Light_Status = true;
                passage_2_Light_Status = true;
            }
        }
    }
}
