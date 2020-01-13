/*# I, CHIRAG BARANDA, student number 000759867, 
 * certify that all code submitted is my own work; 
 * that I have not copied it from any other source.  
 * I also certify that I have not allowed my work to be copied by others.
 * 
 * Author: Chirag Baranda
 * Student Number: 000759867
 * 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3B
{   /// <summary>
    /// This class is contains the logic after the user's GUI interaction
    /// such that add service, Calucate Charges, Reset and Exit
    /// </summary>
    public partial class Lab3B : Form
    {
        public Lab3B()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Load the parameters required at lOad time
        /// setting combobox parameter at index 0
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Lab3B_Load(object sender, EventArgs e)
        {
            HairDresserComboBox.SelectedIndex = 0;
        }
        /// <summary>
        /// exit button event, on button click user will exit the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Add selected service and its charges to the provided Lists
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddServiceButton_Click(object sender, EventArgs e)
        {
            int HairDresserCharge = 0, ServiceCharge; //hairdresser charge and service charge variable to sotre the charge


            //assigning hairdresser charge
            if (HairDresserComboBox.SelectedIndex == 0)
            {
                HairDresserCharge = 30;
            }
            if (HairDresserComboBox.SelectedIndex == 1)
            {
                HairDresserCharge = 45;
            }
            if (HairDresserComboBox.SelectedIndex == 2)
            {
                HairDresserCharge = 40;
            }
            if (HairDresserComboBox.SelectedIndex == 3)
            {
                HairDresserCharge = 50;
            }
            if (HairDresserComboBox.SelectedIndex == 4)
            {
                HairDresserCharge = 55;
            }



            //printing hairdresser name and charge in list boxes
            if (HairDresserComboBox.Enabled == true)
            {
                //printing hairdresser's name
                ChargedItemListBox.Items.Add(HairDresserComboBox.SelectedItem);
                HairDresserComboBox.Enabled = false;
                //printing hair dresser's charge
                PriceListBox.Items.Add(HairDresserCharge.ToString());

                
            }




            //service charges

            if (ServicesListBox.SelectedIndex == 0)
            {
                ServiceCharge = 30;
                //printing service name and charge
                //name
                ChargedItemListBox.Items.Add(ServicesListBox.SelectedItem);
                //charge
                PriceListBox.Items.Add(ServiceCharge.ToString());
            }
            if (ServicesListBox.SelectedIndex == 1)
            {
                ServiceCharge = 20;
                //printing service name and charge
                //name of service
                ChargedItemListBox.Items.Add(ServicesListBox.SelectedItem);
                //charge of service
                PriceListBox.Items.Add(ServiceCharge.ToString());

            }
            if (ServicesListBox.SelectedIndex == 2)
            {
                ServiceCharge = 40;
                //printing service name and charge
                //name of service
                ChargedItemListBox.Items.Add(ServicesListBox.SelectedItem);
                //charge of service
                PriceListBox.Items.Add(ServiceCharge.ToString());

            }
            if (ServicesListBox.SelectedIndex == 3)
            {
                ServiceCharge = 50;
                //printing service name and charge
                //name of service
                ChargedItemListBox.Items.Add(ServicesListBox.SelectedItem);
                //charge of service
                PriceListBox.Items.Add(ServiceCharge.ToString());

            }
            if (ServicesListBox.SelectedIndex == 4)
            {
                ServiceCharge = 200;
                //printing service name and charge
                //name of service
                ChargedItemListBox.Items.Add(ServicesListBox.SelectedItem);
                //charge of service
                PriceListBox.Items.Add(ServiceCharge.ToString());

            }
            if (ServicesListBox.SelectedIndex == 5)
            {
                ServiceCharge = 60;
                //printing service name and charge
                //name of service
                ChargedItemListBox.Items.Add(ServicesListBox.SelectedItem);
                //charge of service
                PriceListBox.Items.Add(ServiceCharge.ToString());

            }
            

            





        }
        /// <summary>
        /// On Click of resrt button Applcaition Data Resets
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetButton_Click(object sender, EventArgs e)
        {
            HairDresserComboBox.SelectedIndex = 0;
            ChargedItemListBox.Items.Clear();
            PriceListBox.Items.Clear();
            HairDresserComboBox.Enabled = true;
            TotalPriceTextBox.Text= String.Empty;
            
        }
        /// <summary>
        /// Calcuate the sum of all charges for the services selectes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateTotalPriceButton_Click(object sender, EventArgs e)
        {
            int totalCharge = 0;

            for (int i = 0; i < PriceListBox.Items.Count; i++)
            {
                totalCharge += Int32.Parse( PriceListBox.Items[i].ToString());
            }

            TotalPriceTextBox.Text = totalCharge.ToString("C");


        }
    }
}
