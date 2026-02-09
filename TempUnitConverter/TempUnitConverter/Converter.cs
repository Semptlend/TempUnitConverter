using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempUnitConverter
{
    public class Converter
    {
        /* Celsius-fok átváltás Fahrenheitbe: F= ((°C*9)/5)+32
           Fahrenheit átváltás Celsius-fokba: °C= ((F-32)*5)/9
           Celsius-fok átváltás Kelvinbe: °K= °C+273,15
           Kelvin átváltás Celsius-fokba: °C= K-273,15
           Fahrenheit átváltása Kelvinbe: °K=((F+459,67)*5)/9
           Kelvin átváltás Fahrenheitbe: F=((°K*9)/5)-459,67
         */
        //celsiusból kelvinbe
        public double CToK(double c) { return c + 273.15; }
        //celsiusból fahrenheitbe
        public double CToF(double c) { return ((c * 9) / 5) + 32; }
        //kelvinből celsiusba
        public double KToC(double k) { return k-273.15; }
        //kelvinből fahrenheitbe
        public double KToF(double k) { return ((k * 9) / 5) - 459.67; }
        //Fahrenheitből Celsiusba
        public double FToC(double f) { return ((f - 32) * 5) /9; }
        //Fahrenheitből Kelvinbe
        public double FToK(double f) { return ((f + 459.67) * 5) / 9; }
    }
}
