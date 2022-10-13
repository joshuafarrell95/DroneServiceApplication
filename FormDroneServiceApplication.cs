using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DroneServiceApplication
{
    public partial class FormDroneServiceApplication : Form
    {
        public FormDroneServiceApplication()
        {
            InitializeComponent();
        }
        // 6.2	Create a global List<T> of type Drone called “FinishedList”. 
        #region 6.2
        private List<Drone> FinishedList = new List<Drone>();
        #endregion

        // 6.3	Create a global Queue<T> of type Drone called “RegularService”.
        #region 6.3
        private Queue<Drone> RegularService = new Queue<Drone>();
        #endregion

        // 6.4	Create a global Queue<T> of type Drone called “ExpressService”.
        #region 6.4
        private Queue<Drone> ExpressService = new Queue<Drone>();
        #endregion

        // 6.5	Create a button method called “AddNewItem” that will add a new service item to a Queue<> based on the priority.
        // Use TextBoxes for the Client Name, Drone Model, Service Problem and Service Cost.
        // Use a numeric up/down control for the Service Tag.
        // The new service item will be added to the appropriate Queue based on the Priority radio button.
        #region 6.5
        private void AddNewItem(object sender, MouseEventArgs e)
        {
            statusStrip.Items.Clear();

            if (CheckAllGUIElements())
            {
                Drone addDrone = new Drone();
                Double.TryParse(textBoxServiceCost.Text, out double addServiceCost);
                Int32.TryParse(textBoxServiceCost.Text, out int addServiceTag);

                addDrone.SetClientName(textBoxClientName.Text);
                addDrone.SetDroneModel(textBoxDroneModel.Text);
                addDrone.SetServiceProblem(textBoxServiceProblem.Text);
                addDrone.SetServiceCost(addServiceCost);
                addDrone.SetServiceTag(addServiceTag);

                if (GetServicePriority() == "Regular")
                {
                    RegularService.Enqueue(addDrone);
                }
                else if (GetServicePriority() == "Express")
                {
                    ExpressService.Enqueue(addDrone);
                }
                // Add clear GUI code here
            }
        }

        private bool CheckAllGUIElements()
        {
            //return true;
            if (!string.IsNullOrEmpty(textBoxClientName.Text) &&
                !string.IsNullOrEmpty(textBoxDroneModel.Text) &&
                !string.IsNullOrEmpty(textBoxServiceProblem.Text) &&
                !string.IsNullOrEmpty(textBoxServiceCost.Text) &&
                !string.IsNullOrEmpty(numericUpDownServiceTag.Value.ToString()) &&
                (!string.IsNullOrEmpty(radioButtonRegular.Text) ||
                !string.IsNullOrEmpty(radioButtonExpress.Text)))
            {
                return true;
            }
            return false;
        }
        #endregion

        // 6.6	Before a new service item is added to the Express Queue the service cost must be increased by 15%.
        #region 6.6
        private double IncreaseServiceCost(double serviceCost, int percentage)
        {
            /* Add original service cost plus a percentage of that cost */
            /* e.g., let serviceCost = 100 and percentage = 15 */
            /* Therefore it follows that 100 + (100 * (15 / 100)) */
            /* then 100 + (100 * 0.15) */
            /* then 100 + 15 which will return 15.00d */
            return Math.Round(serviceCost + (serviceCost * (percentage / 100)), 2);
        }
        #endregion

        // 6.7	Create a custom method called “GetServicePriority” which returns the value of the priority radio group.
        // This method must be called inside the “AddNewItem” method before the new service item is added to a queue.
        #region 6.7
        private string GetServicePriority()
        {
            string rbValue = "";
            foreach (RadioButton rb in groupBoxQueue.Controls.OfType<RadioButton>())
            {
                if (rb.Checked)
                {
                    rbValue = rb.Text;
                    break;
                }
                else
                {
                    rbValue = "Other";
                }
            }
            return rbValue;
        }
        #endregion


        // 6.8	Create a custom method that will display all the elements in the RegularService queue
        // The display must use a List View and with appropriate column headers.
        #region 6.8
        private void DisplayRegularQueue()
        {
            listViewRegularQueue.Items.Clear();
            foreach (Drone drone in RegularService)
            {
                ListViewItem lvi = new ListViewItem(drone.GetClientName());
                lvi.SubItems.Add(drone.GetDroneModel());
                lvi.SubItems.Add(drone.GetServiceProblem());
                lvi.SubItems.Add(drone.GetServiceCost().ToString());
                lvi.SubItems.Add(drone.GetServiceTag().ToString());
                listViewRegularQueue.Items.Add(lvi);
            }
        }
        #endregion

        // 6.9	Create a custom method that will display all the elements in the ExpressService queue.
        // The display must use a List View and with appropriate column headers.
        #region 6.9
        private void DisplayExpressQueue()
        {
            listViewExpressQueue.Items.Clear();
            foreach (Drone drone in ExpressService)
            {
                ListViewItem lvi = new ListViewItem(drone.GetClientName());
                lvi.SubItems.Add(drone.GetDroneModel());
                lvi.SubItems.Add(drone.GetServiceProblem());
                lvi.SubItems.Add(drone.GetServiceCost().ToString());
                lvi.SubItems.Add(drone.GetServiceTag().ToString());
                listViewExpressQueue.Items.Add(lvi);
            }
        }
        #endregion

        // 6.10	Create a custom keypress method to ensure the Service Cost textbox can only accept a double value with one decimal point.
        #region 6.10
        private void TextBoxServiceCost_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        #endregion


        // 6.11	Create a custom method to increment the service tag control, this method must be called inside the “AddNewItem” method before the new service item is added to a queue.

    }
}
