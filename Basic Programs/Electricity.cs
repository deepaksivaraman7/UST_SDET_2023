using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    class Electricity
    {
        public int consumernumber,prevreading,currreading;
        public string? consumername;

        public Electricity(int consumernumber, int prevreading, int currreading, string? consumername)
        {
            this.consumernumber = consumernumber;
            this.prevreading = prevreading;
            this.currreading = currreading;
            this.consumername = consumername;
        }

        /*public Electricity()
 {
     consumernumber = 123;
     prevreading = 5000;
     currreading = 5900;
     consumername = "New";
 }*/
        public double CalculateBill()
        {
            double billamount;
            int reading = currreading - prevreading;
            if (reading <=100) {
                billamount = reading * 2;
            }
            else if (reading <= 200) { 
                billamount = (100*2)+((reading-100) * 2.5);
            }
            else if (reading <= 400){
                billamount = (100 * 2) + (100 * 2.5) + ((reading - 200) * 3.5);
            }
            else
            {
                billamount = (100 * 2) + (100 * 2.5) + (200 * 3.5) + ((reading - 400) * 3.5);
            }
            return billamount;
        }
    }
}
