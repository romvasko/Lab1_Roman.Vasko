using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Classes {
    public class Lab1short {
        short Left { get; set; }
        short Right { get; set; }
        short result { get; set; }
        public Lab1short() {
            Left = -32700;
            Right = 32000;
            result = 100;
        }
        public void Operators() {

            //Arithmetic operators
            Console.WriteLine("Operator + :" + (result = (short)(Left + Right)));
            Console.WriteLine("Operator - :" + (result = (short)(Left - Right)));
            Console.WriteLine("Operator * :" + (result = (short)(Left * Right)));
            Console.WriteLine("Operator / :" + (result = (short)(Left / Right)));
            Console.WriteLine("Operator ++ :" + (result = ++Left));
            Console.WriteLine("Operator -- :" + (result = --Left));
            Console.WriteLine("Operator % :" + (result = (short)(Left % Right)));

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
            Console.WriteLine("Operator >>= :" + (result >>= Right));
            Console.WriteLine("Operator <<= :" + (result <<= Right));

            //Logical operators
            Console.WriteLine("Operator $ :" + (result = (short)(Left & Right)));
            Console.WriteLine("Operator | :" + (result = (short)(Left | Right)));
            Console.WriteLine("Operator ^ :" + (result = (short)(Left ^ Right)));
            Console.WriteLine("Operator ~ :" + (result = (short)~Right));
            Console.WriteLine("Operator >> :" + (result = (short)(Right >> 1)));
            Console.WriteLine("Operator << :" + (result = (short)(Right << 1)));

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
