using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    public class Taxi
    {
        //Protpeties
        public string DriveName { get; set; }
        public bool OnDuty { get; set; }
        public int NumPassanger { get; set; }

        //Method
        public void TaxiInfo()
        {

            string duti;
            if (OnDuty)
            {
                duti = "Yesss";
            }
            else
            {
                duti = "NO";
            }
            Console.WriteLine("Drive Name: {0}", DriveName);
            Console.WriteLine("On Duty?: {0}", duti);
            Console.WriteLine("Number Passange: {0}", NumPassanger);

        }

        public void PickUpPassanger()
        {
            Console.WriteLine("{0} sedang menjemput penumpang", DriveName);
        }

        public void DropOffPassanger()
        {
            Console.WriteLine("{0} selesai mengantar penumpang", DriveName);
        }

    }
}
