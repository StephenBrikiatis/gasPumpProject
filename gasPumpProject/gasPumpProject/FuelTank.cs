using System;
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
