using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RcktFuel
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
        InitializeComponent();
        }

        private void ButtonFuelCalc_Click(object sender, EventArgs e){
            bool troposphereSelected = true; 
            double TroposphereMilesMax = 14500;  //max miles of troposphere
            double terriMalMass = 3260; //unit = lbs

            if (troposphereSelected){ 
                double terriMalGallons = TroposphereMilesMax * terriMalMass;               
                labelFuelage.Text = Convert.ToString(terriMalGallons);
            }
            else
            {
            Console.WriteLine("Please make a selection");
            }
                
            }

        private void ComboBoxRocketType_SelectedIndexChanged(object sender, EventArgs e){
            
            object TerMalRocket;
               //Weight of Rocket 
            

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
