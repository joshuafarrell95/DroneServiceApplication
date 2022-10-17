using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
                Int32.TryParse(numericUpDownServiceTag.Text, out int addServiceTag);

                /* NOTE service cost is set when the service priority is set after the try-catch */
                addDrone.SetClientName(textBoxClientName.Text);
                addDrone.SetDroneModel(textBoxDroneModel.Text);
                addDrone.SetServiceProblem(textBoxServiceProblem.Text);
                addDrone.SetServiceTag(addServiceTag);

                /* Increment the service tag by 10 from 100 to 900 */
                try
                {
                    numericUpDownServiceTag.Value = IncrementServiceTag(addServiceTag);
                }
                /* If the service tag would be incremented above 900, reset the service tag */
                catch (ArgumentOutOfRangeException ex)
                {
                    numericUpDownServiceTag.Value = 100;
                }

                /* Add to the proper queue dependent on the selected radio button */
                if (GetServicePriority() == "Regular")
                {
                    statusStrip.Items.Add("Regular drone service added for " + addDrone.GetClientName());
                    addDrone.SetServiceCost(addServiceCost);
                    RegularService.Enqueue(addDrone);
                    DisplayRegularQueue();
                }
                else if (GetServicePriority() == "Express")
                {
                    statusStrip.Items.Add("Express drone service added for " + addDrone.GetClientName());
                    addDrone.SetServiceCost(IncreaseServiceCost(addServiceCost, 15));
                    ExpressService.Enqueue(addDrone);
                    DisplayExpressQueue();
                }
                ClearAllTextboxes();
            }
        }

        private bool CheckAllGUIElements()
        {
            statusStrip.Items.Clear();
            /* If all textboxes are not empty, the numericUpDown is not empty and */
            /* one of the two radio buttons are selected, return true */
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
            statusStrip.Items.Add("Please fully fill in all text fields, then select either Regular or Express.");
            return false;
        }

        #endregion

        // 6.6	Before a new service item is added to the Express Queue the service cost must be increased by 15%.
        #region 6.6
        private double IncreaseServiceCost(double serviceCost, int percentage)
        {
            double increasedCost = serviceCost * (percentage / 100.0);
            return Math.Round(serviceCost + increasedCost, 1);
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
                lvi.SubItems.Add("$ " + drone.GetServiceCost().ToString());
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
                lvi.SubItems.Add("$ " + drone.GetServiceCost().ToString());
                lvi.SubItems.Add(drone.GetServiceTag().ToString());
                listViewExpressQueue.Items.Add(lvi);
            }
        }
        #endregion

        // 6.10	Create a custom keypress method to ensure the Service Cost textbox can only accept a double value with one decimal point.
        #region 6.10
        private void TextBoxServiceCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            statusStrip.Items.Clear();
            
            /* Filter out non-integer characters except for the period key U+002E */
            if ((!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) && e.KeyChar != 0x002E)
            {
                statusStrip.Items.Add("You must only enter numeric characters (0-9) and one number after the decimal point.");
                e.Handled = true;
            }

            /* Allow an indefinite amount of digits before the period, then allow only one digit after the period */
            string regexPattern = @"^\d*(\.([\d]{0}))*$";
            bool regexMatch = Regex.Match(textBoxServiceCost.Text, regexPattern).Success;

            if (!regexMatch)
            {
                /* Allow the BACKSPACE key to be used */
                if (e.KeyChar != 0x0008)
                {
                    statusStrip.Items.Add("You can only enter one number after the decimal point.");
                    e.Handled = true;
                }
            }
        }
        #endregion

        // 6.11	Create a custom method to increment the service tag control, this method must be called inside the “AddNewItem” method before the new service item is added to a queue.
        #region 6.11
        private int IncrementServiceTag(int oldServiceTag)
        {
            return oldServiceTag + 10;
        }
        #endregion

        // 6.12	Create a mouse click method for the regular service ListView that will display the Client Name and Service Problem in the related textboxes.
        #region 6.12
        private bool isDeveloperMode = false; /* Developer mode returns all other text boxes, the numericUpDown and each radio button */
        private void ListViewRegularQueue_MouseClick(object sender, MouseEventArgs e)
        {
            statusStrip.Items.Clear();
            int selIndx = GetSelectedRegularIndex();
            if (selIndx != -1)
            {
                textBoxClientName.Text = RegularService.ElementAt(selIndx).GetClientName();
                textBoxServiceProblem.Text = RegularService.ElementAt(selIndx).GetServiceProblem();

                if (isDeveloperMode)
                {
                    textBoxDroneModel.Text = RegularService.ElementAt(selIndx).GetDroneModel();
                    textBoxServiceCost.Text = RegularService.ElementAt(selIndx).GetServiceCost().ToString();
                    numericUpDownServiceTag.Value = RegularService.ElementAt(selIndx).GetServiceTag();

                    foreach (RadioButton rb in groupBoxQueue.Controls.OfType<RadioButton>())
                    {
                        if (rb.Text == "Regular")
                        {
                            rb.Checked = true;
                        }
                        else
                        {
                            rb.Checked = false;
                        }
                    }
                }

                statusStrip.Items.Add("Regular service data for " + RegularService.ElementAt(selIndx).GetClientName() + " populated in the text boxes");
            }
        }

        private int GetSelectedRegularIndex()
        {
            try
            {
                return listViewRegularQueue.SelectedIndices[0];
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Trace.TraceError(ex.Message);
                return -1;
            }
        }
        #endregion

        // 6.13	Create a mouse click method for the express service ListView that will display the Client Name and Service Problem in the related textboxes.
        #region 6.13
        private void ListViewExpressQueue_MouseClick(object sender, MouseEventArgs e)
        {
            int selIndx = GetSelectedExpressIndex();
            if (selIndx != -1)
            {
                textBoxClientName.Text = ExpressService.ElementAt(selIndx).GetClientName();
                textBoxServiceProblem.Text = ExpressService.ElementAt(selIndx).GetServiceProblem();

                if (isDeveloperMode)
                {
                    textBoxDroneModel.Text = ExpressService.ElementAt(selIndx).GetDroneModel();
                    textBoxServiceCost.Text = ExpressService.ElementAt(selIndx).GetServiceCost().ToString();
                    numericUpDownServiceTag.Value = ExpressService.ElementAt(selIndx).GetServiceTag();

                    foreach (RadioButton rb in groupBoxQueue.Controls.OfType<RadioButton>())
                    {
                        if (rb.Text == "Express")
                        {
                            rb.Checked = true;
                        }
                        else
                        {
                            rb.Checked = false;
                        }
                    }
                }

                statusStrip.Items.Add("Express service data for " + ExpressService.ElementAt(selIndx).GetClientName() + " populated in the text boxes");
            }
        }

        private int GetSelectedExpressIndex()
        {
            try
            {
                return listViewExpressQueue.SelectedIndices[0];
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Trace.TraceError(ex.Message);
                return -1;
            }
        }
        #endregion

        // 6.14	Create a button click method that will remove a service item from the regular ListView and dequeue the regular service Queue<T> data structure.
        // The dequeued item must be added to the List<T> and displayed in the ListBox for finished service items.
        #region 6.14
        private void ButtonRemoveFromRegularQueue_MouseClick(object sender, MouseEventArgs e)
        {
            statusStrip.Items.Clear();
            try
            {
                Drone drone = RegularService.Dequeue();
                statusStrip.Items.Add("Drone regular service finished for " + drone.GetClientName() + " and is now located in the finished list below.");
                DisplayRegularQueue();
                FinishedList.Add(drone);
                DisplayFinishedList();
            }
            catch (InvalidOperationException ex)
            {
                Trace.TraceError(ex.ToString());
            }
        }

        private void DisplayFinishedList()
        {
            listBoxFinishedList.Items.Clear();
            foreach (var drone in FinishedList)
            {
                listBoxFinishedList.Items.Add(drone.ToString());
            }
        }
        #endregion

        // 6.15	Create a button click method that will remove a service item from the express ListView and dequeue the express service Queue<T> data structure.
        // The dequeued item must be added to the List<T> and displayed in the ListBox for finished service items.
        #region 6.15
        private void ButtonRemoveFromExpressQueue_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                Drone drone = ExpressService.Dequeue();
                statusStrip.Items.Add("Drone express service finished for " + drone.GetClientName() + " and is now located in the finished list below.");
                DisplayExpressQueue();
                FinishedList.Add(drone);
                DisplayFinishedList();
            }
            catch (InvalidOperationException ex)
            {
                Trace.TraceError(ex.ToString());
            }
        }
        #endregion

        // 6.16	Create a double mouse click method that will delete a service item from the finished listbox and remove the same item from the List<T>.
        #region 6.16
        private void ListBoxFinishedList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            statusStrip.Items.Clear();
            
            int selIndx = GetSelectedFinishedIndex();

            string oldClientName = FinishedList.ElementAt<Drone>(selIndx).GetClientName();
            statusStrip.Items.Add("Drone service completed for " + oldClientName);

            FinishedList.RemoveAt(selIndx);
            DisplayFinishedList();
        }

        private int GetSelectedFinishedIndex()
        {
            try
            {
                return listBoxFinishedList.SelectedIndex;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Trace.TraceError(ex.ToString());
                return -1;
            }
        }
        #endregion

        // 6.17	Create a custom method that will clear all the textboxes after each service item has been added.
        #region 6.17
        private void ClearAllTextboxes()
        {
            textBoxClientName.Clear();
            textBoxDroneModel.Clear();
            textBoxServiceProblem.Clear();
            textBoxServiceCost.Clear();
        }
        #endregion

        // 6.18	All code is required to be adequately commented. Map the programming criteria and features to your code/methods by adding comments above the method signatures.
        // Ensure your code is compliant with the CITEMS coding standards (refer http://www.citems.com.au/).
    }
}
