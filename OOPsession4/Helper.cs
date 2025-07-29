using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsession4
{
    internal static class Helper
    {

        //private static double pi;
        private const double pi=3.14;


        public static double PI { get { return pi; }
            //set { pi = value; } 
        }
      

        //static Helper()
        //{
        //    pi = 3.14; // Default value for PI
        //}

     

        public static double CmToInch(double cm)
        {
            return cm / 2.54;
        }

        public static double calacCircleArea(double radius)
        {
            return PI * Math.Pow(radius,2);
        }


    }
}
