using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gasPumpProject
{
    class FuelTank
    {
        string fuelType;
        float pricePerGal;
        float galsRemaining;

        public void setFuelType(string type)
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

        public string getType()
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
