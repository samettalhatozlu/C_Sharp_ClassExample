using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Araba_Sinif_Ornegi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Araba_Class araba = new Araba_Class();
            araba.marka = "BMW";
            araba.renk = "Siyah";
            araba.model = 2022;
            araba.motor = 1.6;

            Console.WriteLine("$$$ ARABA TANITIM KARTI $$$");
            Console.WriteLine();
            Console.WriteLine("Arabanın markası: " + araba.marka);
            Console.WriteLine("Arabanın modeli: " + araba.model);
            Console.WriteLine("Arabanın rengi: " + araba.renk);
            Console.WriteLine("Arabanın motor gücü: " + araba.motor);

            Console.Read();
        }
    }
}
