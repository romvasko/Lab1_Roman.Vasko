using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1 {
    public class Lab1bool {
        bool Left { get; set; }
        bool Right { get; set; }
        bool result { get; set; }
        public Lab1bool() { 
            Left = false;
            Right = true;
            result = false;
        }
        public void Operators() {

            //Arithmetic operators not supported
            //Console.WriteLine("Operator + :" + (result = Left + Right));
            //Console.WriteLine("Operator - :" + (result = Left - Right));
            //Console.WriteLine("Operator * :" + (result = Left * Right));
            //Console.WriteLine("Operator / :" + (result = Left / Right));
            //Console.WriteLine("Operator ++ :" + (result = ++Left));
            //Console.WriteLine("Operator -- :" + (result = ++Left));
            //Console.WriteLine("Operator % :" + (result = Left % Right));

            //Assignment Operators
            Console.WriteLine("Operator = :" + (result = Right));
            //Console.WriteLine("Operator += :" + (result += Right)); Not supported
            //Console.WriteLine("Operator -= :" + (result -= Right)); Not supported
            //Console.WriteLine("Operator *= :" + (result *= Right)); Not supported
            //Console.WriteLine("Operator /= :" + (result /= Right)); Not supported
            //Console.WriteLine("Operator %= :" + (result %= Right)); Not supported
            Console.WriteLine("Operator $= :" + (result &= Right));
            Console.WriteLine("Operator |= :" + (result |= Right));
            Console.WriteLine("Operator ^= :" + (result ^= Right));
            //Console.WriteLine("Operator >>= :" + (result >>= Right)); Not supported
            //Console.WriteLine("Operator <<= :" + (result <<= Right)); Not supported

            //Logical operators
            Console.WriteLine("Operator $ :" + (result = Left & Right)); 
            Console.WriteLine("Operator | :" + (result = Left | Right)); 
            Console.WriteLine("Operator ^ :" + (result = Left ^ Right));
            //Console.WriteLine("Operator ~ :" + (result = ~Right)); Not supported
            //Console.WriteLine("Operator >> :" + (result = Right >> 1)); Not supported
            //Console.WriteLine("Operator << :" + (result = Right << 1)); Not supported

            // Comparison Operators
            Console.WriteLine("Operator == :" + (result = (Left == Right)));
            Console.WriteLine("Operator != :" + (result = (Left != Right)));
            //Console.WriteLine("Operator > :" + (result = (Left > Right))); Not supported
            //Console.WriteLine("Operator < :" + (result = (Left < Right))); Not supported
            //Console.WriteLine("Operator >= :" + (result = (Left >= Right))); Not supported
            //Console.WriteLine("Operator <= :" + (result = (Left <= Right))); Not supported

            //


        }
    }
}
