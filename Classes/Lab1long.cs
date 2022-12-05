using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Classes {
    public class Lab1long {
        long Left { get; set; }
        long Right { get; set; }
        long result { get; set; }
        public Lab1long() {
            Left = -11124342363300;
            Right = 16423411400;
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
            Console.WriteLine("Operator $= :" + (result &= Right));
            Console.WriteLine("Operator |= :" + (result |= Right));
            Console.WriteLine("Operator ^= :" + (result ^= Right));
            //Console.WriteLine("Operator >>= :" + (result >>= Right)); Not supported
            //Console.WriteLine("Operator <<= :" + (result <<= Right)); Not supported

            //Logical operators
            Console.WriteLine("Operator $ :" + (result = (Left & Right)));
            Console.WriteLine("Operator | :" + (result = (Left | Right)));
            Console.WriteLine("Operator ^ :" + (result = (Left ^ Right)));
            Console.WriteLine("Operator ~ :" + (result = ~Right));
            Console.WriteLine("Operator >> :" + (result = (Right >> 1)));
            Console.WriteLine("Operator << :" + (result = (Right << 1)));

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
