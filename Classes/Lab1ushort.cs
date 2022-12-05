using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Classes {
    public class Lab1ushort {
        ushort Left { get; set; }
        ushort Right { get; set; }
        ushort result { get; set; }
        public Lab1ushort() {
            Left = 63300;
            Right = 64400;
            result = 100;
        }
        public void Operators() {

            //Arithmetic operators
            Console.WriteLine("Operator + :" + (result = (ushort)(Left + Right)));
            Console.WriteLine("Operator - :" + (result = (ushort)(Left - Right)));
            Console.WriteLine("Operator * :" + (result = (ushort)(Left * Right)));
            Console.WriteLine("Operator / :" + (result = (ushort)(Left / Right)));
            Console.WriteLine("Operator ++ :" + (result = ++Left));
            Console.WriteLine("Operator -- :" + (result = --Left));
            Console.WriteLine("Operator % :" + (result = (ushort)(Left % Right)));

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
            Console.WriteLine("Operator $ :" + (result = (ushort)(Left & Right)));
            Console.WriteLine("Operator | :" + (result = (ushort)(Left | Right)));
            Console.WriteLine("Operator ^ :" + (result = (ushort)(Left ^ Right)));
            Console.WriteLine("Operator ~ :" + (result = (ushort)~Right));
            Console.WriteLine("Operator >> :" + (result = (ushort)(Right >> 1)));
            Console.WriteLine("Operator << :" + (result = (ushort)(Right << 1)));

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
