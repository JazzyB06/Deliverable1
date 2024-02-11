using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many sodas have been sold today? 100 in stock");
            Console.WriteLine(60);
            int num1 = 100;
            int num2 = 60;
            int num3 = num1 - num2;
            Console.WriteLine("There are 40 sodas left");
            Console.WriteLine("How many chips have been sold today? 40 in stock");
            Console.WriteLine(20);
            int num4 = 40;
            int num5 = 20;
            int num6 = num4 - num5;
            Console.WriteLine("There are 20 chips left");
            Console.WriteLine("How much candy has been sold today? 40 in stock");
            Console.WriteLine(20);
            int num7 = 60;
            int num8 = 20;
            int num9 = num7 - num8;
            Console.WriteLine("There are 40 candies left");

            int number = 40;
            if (number <= 40)
            {
                Console.WriteLine("40 sodas need to be restocked");
            }
            else if (number >= 40)
            {
                Console.WriteLine("That value is too high. Stock not adjusted");
            }
            int number2 = 20;
            if (number2 >= 20)
            {
                Console.WriteLine("20 chips need to be restocked");
            }
            else if (number <= 20)
            {
                Console.WriteLine("That value is too high. Stock not adjusted");
            }
            int number3 = 40;
            if (number3 >= 40)
            {
                Console.WriteLine("40 candies need to be restocked");
            }
            else if (number <= 40)
            {
                Console.WriteLine("That value is too high. Stock not adjusted");
            }
            int number4 = 90;
            if (number >= 90)
            {
            }
            else if (number <= 90)
            {
                Console.WriteLine("That value is too high. Stock not adjusted");
            }
        }
    }
}