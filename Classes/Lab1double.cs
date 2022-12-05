using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Classes {
    internal class Lab1double {
        double Left { get; set; }
        double Right { get; set; }
        double result { get; set; }
        public Lab1double() {
            Left = -11163300.28304198334094;
            Right = 164400.83894798123749;
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
