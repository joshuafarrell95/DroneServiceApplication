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

                addDrone.setClientName(textBoxClientName.Text);
                addDrone.setDroneModel(textBoxDroneModel.Text);
                addDrone.setServiceProblem(textBoxServiceProblem.Text);
                addDrone.setServiceCost(addServiceCost);
                addDrone.setServiceTag(addServiceTag);

                if (GetPriorityRadioButton() == "Regular")
                {
                    RegularService.Enqueue(addDrone);
                }
                else if (GetPriorityRadioButton() == "Express")
                {
                    ExpressService.Enqueue(addDrone);
                }
                // Add clear GUI code here
            }
        }

        private string GetPriorityRadioButton()
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
    }
}
