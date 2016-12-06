/*Author: John Houk Stephen Brikiatis
Class:  CSI-340-01
Assignment: Semester project
Date Assigned: 09/16/16
Due Date: 12/05/16

Description: This is a simple class that creates the fuel tanks for the fuelPump class.

Certification of Authenticity:
We certify that this assignment is entirely our own work.
*/

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gasPumpProject
{
    class FuelTank
    {
        int fuelType;
        float pricePerGal;
        float galsRemaining;

        public FuelTank(int type)
        {
            fuelType = type;
            pricePerGal = (float)( 3.0 + (type * .25) );
            galsRemaining = 3000;
        }

        public void setFuelType(int type)
        {
            fuelType = type;
        }

        public void setPrice(float price)
        {
            pricePerGal = price;
        }

        public void setGallons(float gallon)
        {
            galsRemaining = gallon;
        }

        public int getType()
        {
            return fuelType;
        }

        public float getPrice()
        {
            return pricePerGal;
        }

        public float getGallons()
        {
            return galsRemaining;
        }
    }
}
