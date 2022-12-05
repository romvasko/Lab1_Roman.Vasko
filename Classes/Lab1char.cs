using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Classes {
    public class Lab1char {
        char Left { get; set; }
        char Right { get; set; }
        char result { get; set; }
        public Lab1char() {
            Left = 'Y';
            Right = 'N';
            result = '0'; 
        }
        public void Operators() {

            //Arithmetic operators
            Console.WriteLine("Operator + :" + (result = (char)(Left + Right)));
            Console.WriteLine("Operator - :" + (result = (char)(Left - Right)));
            Console.WriteLine("Operator * :" + (result = (char)(Left * Right)));
            Console.WriteLine("Operator / :" + (result = (char)(Left / Right)));
            Console.WriteLine("Operator ++ :" + (result = ++Left));
            Console.WriteLine("Operator -- :" + (result = --Left));
            Console.WriteLine("Operator % :" + (result = (char)(Left % Right)));

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
            Console.WriteLine("Operator $ :" + (result = (char)(Left & Right)));
            Console.WriteLine("Operator | :" + (result = (char)(Left | Right)));
            Console.WriteLine("Operator ^ :" + (result = (char)(Left ^ Right)));
            Console.WriteLine("Operator ~ :" + (result = (char)~Right));
            Console.WriteLine("Operator >> :" + (result = (char)(Right >> 1)));
            Console.WriteLine("Operator << :" + (result = (char)(Right << 1)));

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
