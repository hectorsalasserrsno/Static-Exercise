using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    internal static class TempConverter
    {


        public static double FarenheitToCelsius(double Farenheit)
        {
            double celsius = (Farenheit - 32) * 5 / 9;
            return celsius;
        }
        public static double CelciusToFarenheit(double celcius)
        {
            double Farenheit = (celcius * 9 / 5) + 32;
            return Farenheit;


        }
    }

}



    

