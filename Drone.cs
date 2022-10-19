using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

// Joshua, M153428
// Drone Service Application
// 19/10/2022

namespace DroneServiceApplication
{
    // 6.1	Create a separate class file to hold the data items of the Drone.
    // Use separate getter and setter methods, ensure the attributes are private and the accessor methods are public.
    // Add a display method that returns a string for Client Name and Service Cost.
    // Add suitable code to the Client Name and Service Problem accessor methods so the data is formatted as Title case or Sentence case.
    // Save the class as “Drone.cs”.
    internal class Drone : IComparable<Drone>
    {
        private string clientName;
        private string droneModel;
        private string serviceProblem;
        private double serviceCost;
        private int serviceTag;
        
        // This class uses separate getter and setter methods which are public
        #region Getters and setters
        public string GetClientName()
        {
            return clientName;
        }

        // Format clientName to Title case (e.g. joshua farrell > Joshua Farrell)
        public void SetClientName(string newClientName)
        {
            TextInfo ti = new CultureInfo("en-AU", false).TextInfo;
            clientName = ti.ToTitleCase(newClientName);
        }

        public string GetDroneModel()
        {
            return droneModel;
        }

        public void SetDroneModel(string newDroneModel)
        {
            droneModel = newDroneModel;
        }

        public string GetServiceProblem()
        {
            return serviceProblem;
        }

        // Format serviceProblem to Sentence case (e.g. propellers are not spinning. > Propellers are not spinning.)
        public void SetServiceProblem(string newServiceProblem)
        {
            string lowerServiceProblem = newServiceProblem.ToLower();
            Regex regex = new Regex(@"(^[a-z])|\.\s+(.)", RegexOptions.ExplicitCapture);
            serviceProblem = regex.Replace(lowerServiceProblem, s => s.Value.ToUpper());
        }

        public double GetServiceCost()
        {
            return Math.Round(serviceCost, 2);
        }

        public void SetServiceCost(double newServiceCost)
        {
            serviceCost = newServiceCost;
        }

        public int GetServiceTag()
        {
            return serviceTag;
        }

        public void SetServiceTag(int newServiceTag)
        {
            serviceTag = newServiceTag;
        }
        #endregion

        // These methods are used to compare between different Drone class objects and to display drone data as a string
        #region Utilities
        public int CompareTo(Drone d)
        {
            return droneModel.CompareTo(d.droneModel);
        }

        public override string ToString()
        {
            //return GetClientName() + "\t\t" + GetDroneModel() + "\t\t" + GetServiceProblem() + "\t\t$ " + GetServiceCost() + "\t\t" + GetServiceTag();
            return GetClientName() + "\t\t$ " + GetServiceCost();
        }
        #endregion
    }
}
