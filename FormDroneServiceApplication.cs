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
        private List<Drone> FinishedList = new List<Drone>();
        private Queue<Drone> RegularService = new Queue<Drone>();
        private Queue<Drone> ExpressService = new Queue<Drone>();
    }
}
