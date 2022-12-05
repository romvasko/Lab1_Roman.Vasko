using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1 {
    internal class Lab1sbyte {
        sbyte Left { get; set; }
        sbyte Right { get; set; }
        sbyte result { get; set; }
        public Lab1sbyte() {
            Left = -126;
            Right = 100;
            result = 100;
        }
        public void Operators() {

            //Arithmetic operators
            Console.WriteLine("Operator + :" + (result = (sbyte)(Left + Right)));
            Console.WriteLine("Operator - :" + (result = (sbyte)(Left - Right)));
            Console.WriteLine("Operator * :" + (result = (sbyte)(Left * Right)));
            Console.WriteLine("Operator / :" + (result = (sbyte)(Left / Right)));
            Console.WriteLine("Operator ++ :" + (result = ++Left));
            Console.WriteLine("Operator -- :" + (result = --Left));
            Console.WriteLine("Operator % :" + (result = (sbyte)(Left % Right)));

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
            Console.WriteLine("Operator $ :" + (result = (sbyte)(Left & Right)));
            Console.WriteLine("Operator | :" + (result = (sbyte)(Left | Right)));
            Console.WriteLine("Operator ^ :" + (result = (sbyte)(Left ^ Right)));
            Console.WriteLine("Operator ~ :" + (result = (sbyte)~Right));
            Console.WriteLine("Operator >> :" + (result = (sbyte)(Right >> 1)));
            Console.WriteLine("Operator << :" + (result = (sbyte)(Right << 1)));

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
