using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1 {
    
    public class Lab1byte {
        byte Left { get; set; }
        byte Right { get; set; }
        byte result { get; set; }
        public Lab1byte() {
            Left = 10;
            Right = 15;
            result = 0;
        }
        public void Operators() {

            //Arithmetic operators
            Console.WriteLine("Operator + :" + (result = (byte)(Left + Right)));
            Console.WriteLine("Operator - :" + (result = (byte)(Left - Right)));
            Console.WriteLine("Operator * :" + (result = (byte)(Left * Right)));
            Console.WriteLine("Operator / :" + (result = (byte)(Left / Right)));
            Console.WriteLine("Operator ++ :" + (result = ++Left));
            Console.WriteLine("Operator -- :" + (result = --Left));
            Console.WriteLine("Operator % :" + (result = (byte)(Left % Right)));

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
            Console.WriteLine("Operator $ :" + (result = (byte)(Left & Right)));
            Console.WriteLine("Operator | :" + (result = (byte)(Left | Right)));
            Console.WriteLine("Operator ^ :" + (result = (byte)(Left ^ Right)));
            Console.WriteLine("Operator ~ :" + (result = (byte)~Right));
            Console.WriteLine("Operator >> :" + (result = (byte)(Right >> 1)));
            Console.WriteLine("Operator << :" + (result = (byte)(Right << 1)));

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
