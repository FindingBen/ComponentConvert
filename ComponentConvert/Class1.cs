using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ComponentConvert
{
    public class Class1
    {
       public static double ConvertGramsToOunces(double grams)
        {
            double ounces = grams / 28.34952;
            return ounces;
        }


        public static double ConvertOuncesToGram(double ounces)
        {
            double grams = ounces * 28.34952;
            return grams;
        }



        

    }
}
