﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

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

        #region Getters and setters
        public string getClientName()
        {
            return clientName;
        }

        public void setClientName(string newClientName)
        {
            clientName = newClientName;
        }

        public string getDroneModel()
        {
            return droneModel;
        }

        public void setDroneModel(string newDroneModel)
        {
            droneModel = newDroneModel;
        }

        public string getServiceProblem()
        {
            return serviceProblem;
        }

        public void setServiceProblem(string newServiceProblem)
        {
            serviceProblem = newServiceProblem;
        }

        public double getServiceCost()
        {
            return Math.Round(serviceCost, 2);
        }

        public void setServiceCost(double newServiceCost)
        {
            serviceCost = newServiceCost;
        }

        public int getServiceTag()
        {
            return serviceTag;
        }

        public void setServiceTag(int newServiceTag)
        {
            serviceTag = newServiceTag;
        }
        #endregion

        #region Utilities

        public int CompareTo(Drone d)
        {
            return droneModel.CompareTo(d.droneModel);
        }
        #endregion
    }
}
