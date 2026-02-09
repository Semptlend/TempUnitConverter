using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TempUnitConverter
{
    class Program
    {
        /*
          0 °C = 32 F = 273.15 °K
        10 °C = 50 F = 283.15 °K
        100 °C = 212 F = 373.15 °K
        0 °K = -273 °C = -459.67 F
        100 °K = -173.15 °C = -279.67 F
        -273.15 °K = 0 °C = 32 F 
         */
        static void Main(string[] args)
        {
            //Az értékek melyekkel számolunk
            double c = 10;
            double k = 0;
            double f = 32;
            //függvény meghívása
            Converter converter = new Converter();
            //Számolás az adatokkal
            double kk = converter.CToK(c);
            Console.WriteLine("°C =" + kk + " °K");
            double ff = converter.CToF(c);
            Console.WriteLine("°C =" + ff + " F");
            double cc = converter.KToC(k);
            Console.WriteLine("°K =" + cc + " °C");
            double fff = converter.KToF(k);
            Console.WriteLine("°K =" + fff + " F");
            double kkk = converter.FToK(f);
            Console.WriteLine("F =" + kkk + " °K");
            double ccc = converter.FToC(f);
            Console.WriteLine("F =" + ccc + " °C");
            Console.ReadKey();
        }
    }
}
