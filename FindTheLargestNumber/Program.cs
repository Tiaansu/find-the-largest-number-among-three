using System;

namespace FindTheLargestNumber
{
    class Program
    {
        public static void Main(string[] args)
        {
            string inputValue;
            int firstValue, 
                secondValue, 
                thirdValue
            ;

            Console.WriteLine("Find the largest of three numbers:");
            Console.WriteLine("----------------------------------");

            Console.Write("Input the 1st number: ");
            inputValue = Console.ReadLine();
            firstValue = Convert.ToInt32(inputValue);

            Console.Write("Input the 2nd number: ");
            inputValue = Console.ReadLine();
            secondValue = Convert.ToInt32(inputValue);

            Console.Write("Input the 3rd number: ");
            inputValue = Console.ReadLine();
            thirdValue = Convert.ToInt32(inputValue);

            if (firstValue > thirdValue && firstValue > secondValue)
            {
                if (firstValue > thirdValue)
                {
                    Console.WriteLine("The 1st number is the greatest among three.");
                }
                else
                {
                    Console.WriteLine("The 3rd number is the greatest among three.");
                }
            }
            else
            {
                if (secondValue > thirdValue)
                {
                    Console.WriteLine("The 2nd number is the greatest among three.");
                }
                else
                {
                    Console.WriteLine("The 3rd number is the greatest among three.");
                }
            }
        }
    }
}