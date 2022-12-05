using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Classes {
    public class Lab1float {
        float Left { get; set; }
        float Right { get; set; }
        float result { get; set; }
        public Lab1float() {
            Left = 13245.09213890182f;
            Right = 65498789.981734298734892f ;
            result = 100;
        }
        public void Operators() {

            //Arithmetic operators
            Console.WriteLine("Operator + :" + (result = (Left + Right)));
            Console.WriteLine("Operator - :" + (result = (Left - Right)));
            Console.WriteLine("Operator * :" + (result = (Left * Right)));
            Console.WriteLine("Operator / :" + (result = (Left / Right)));
            Console.WriteLine("Operator ++ :" + (result = ++Left));
            Console.WriteLine("Operator -- :" + (result = --Left));
            Console.WriteLine("Operator % :" + (result = (Left % Right)));

            //Assignment Operators
            Console.WriteLine("Operator = :" + (result = Right));
            Console.WriteLine("Operator += :" + (result += Right));
            Console.WriteLine("Operator -= :" + (result -= Right));
            Console.WriteLine("Operator *= :" + (result *= Right));
            Console.WriteLine("Operator /= :" + (result /= Right));
            Console.WriteLine("Operator %= :" + (result %= Right));
            //Console.WriteLine("Operator $= :" + (result &= Right)); Not supported
            //Console.WriteLine("Operator |= :" + (result |= Right)); Not supported
            //Console.WriteLine("Operator ^= :" + (result ^= Right)); Not supported
            //Console.WriteLine("Operator >>= :" + (result >>= Right)); Not supported
            //Console.WriteLine("Operator <<= :" + (result <<= Right)); Not supported

            //Logical operators
            //Console.WriteLine("Operator $ :" + (result = (Left & Right))); Not supported
            //Console.WriteLine("Operator | :" + (result = (Left | Right))); Not supported
            //Console.WriteLine("Operator ^ :" + (result = (Left ^ Right))); Not supported
            //Console.WriteLine("Operator ~ :" + (result = ~Right)); Not supported
            //Console.WriteLine("Operator >> :" + (result = (Right >> 1))); Not supported
            //Console.WriteLine("Operator << :" + (result = (Right << 1))); Not supported

            // Comparison Operators
            Console.WriteLine("Operator == :" + (Left == Right));
            Console.WriteLine("Operator != :" + (Left != Right));
            Console.WriteLine("Operator > :" + (Left > Right));
            Console.WriteLine("Operator < :" + (Left < Right));
            Console.WriteLine("Operator >= :" + (Left >= Right));
            Console.WriteLine("Operator <= :" + (Left <= Right));
            }
        }
}
