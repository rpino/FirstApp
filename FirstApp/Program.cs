//Write a C# Sharp program that takes a number as input and print its multiplication table

using System;
namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberString = string.Empty;
            int numberInput= 0;
            Console.WriteLine("Please insert a nuber: ");
            numberString = Console.ReadLine();
            try
            {
                numberInput = System.Convert.ToInt32(numberString);
                multiplicationTable(numberInput);
            }
            catch (Exception e)
            {
                Console.WriteLine("mmm... you did not insert a number! :(...GOODBYE!");
            }
        }

        public static void multiplicationTable(int number)
        {           
            int result;

            for(int i = 1; i <= 10; i++)
            {
                result = number * i;
                Console.WriteLine(number + " x " + i + " = " + result); ;
            }

        }

    }
}
