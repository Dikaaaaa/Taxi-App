using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Membuat objek dari class Taxi
            Taxi nama = new Taxi();

            //Mengeset nilai properties objek nama
            nama.DriveName = "Jono";
            nama.OnDuty = true;
            nama.NumPassanger = 10;

            //Pemanggilan Method
            nama.TaxiInfo();
            Console.WriteLine();
            nama.PickUpPassanger();
            nama.DropOffPassanger();


            Console.ReadKey();
        }
    }

}
