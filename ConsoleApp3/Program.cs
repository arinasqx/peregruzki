using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Number
    {
        private int value;

        public Number(int value)
        {
            this.value = value;
        }

        public static Number operator +(Number num1, Number num2)
        {
            return new Number(num1.value + num2.value);
        }

        public static Number operator -(Number num1, Number num2)
        {
            return new Number(num1.value - num2.value);
        }

        public static bool operator ==(Number num1, Number num2)
        {
            return num1.value == num2.value;
        }

        public static bool operator !=(Number num1, Number num2)
        {
            return num1.value != num2.value;
        }

        public static explicit operator int(Number num)
        {
            return num.value;
        }

        public static implicit operator Number(int value)
        {
            return new Number(value);
        }

        public override string ToString()
        {
            return value.ToString();
        }
    }

    class Program
    {
        static void Main()
        {
            Number num1 = new Number(5);
            Number num2 = new Number(3);

            Number sum = num1 + num2;
            Number difference = num1 - num2;

            Console.WriteLine($"Сумма: {sum}");
            Console.WriteLine($"Разница: {difference}");

            int intValue = (int)sum;
            Console.WriteLine($"Сумма целая: {intValue}");

            Number num3 = 10;
            Console.WriteLine($"num3: {num3}");

            Console.WriteLine($"Число 1 и число 2 равны? {num1 == num2}");
            Console.WriteLine($"Число 1 и число 3 равны?? {num1 == num3}");
            Console.ReadKey();
        }
    }
}
