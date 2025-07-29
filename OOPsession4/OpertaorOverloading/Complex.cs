using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsession4.OpertaorOverloading
{
    public class Complex
    {
        public int Real { get; set; }
        public int Imaginary { get; set; }

        public override string ToString()
        {
            return $"{Real} + {Imaginary}i";
        }
        #region Operator Overloading
        public static Complex operator +(Complex c1, Complex c2)
        {
            return new Complex
            {
                Real = (c1?.Real??0) + (c2?.Real??0),
                Imaginary = (c1?.Imaginary ?? 0) + (c2?.Imaginary ?? 0)
            };
        }

        public static Complex operator -(Complex c1, Complex c2)
        {
            return new Complex
            {
                Real = (c1?.Real ?? 0) - (c2?.Real ?? 0),
                Imaginary = (c1?.Imaginary ?? 0) - (c2?.Imaginary ?? 0)
            };
        }

        public static Complex operator ++(Complex c1)
        {
            return new Complex
            {
                Real = (c1?.Real ?? 0)+1,
                Imaginary = (c1?.Imaginary ?? 0)+1
            };
        }
        public static Complex operator *(Complex c1, Complex c2)
        {
            return new Complex
            {
                Real = (c1.Real * c2.Real) - (c1.Imaginary * c2.Imaginary),
                Imaginary = (c1.Real * c2.Imaginary) + (c1.Imaginary * c2.Real)
            };
        }

        public static bool operator >(Complex c1, Complex c2)
        {
           if(c1.Real==c2.Real)
            {
                return c1.Imaginary > c2.Imaginary;
            }
            else {               
                return c1.Real > c2.Real;
            }
           
        }
        public static bool operator <(Complex c1, Complex c2)
        {
            if (c1.Real == c2.Real)
            {
                return c1.Imaginary < c2.Imaginary;
            }
            else
            {
                return c1.Real < c2.Real;
            }

        }
        #endregion


    }
}
