using System;
namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, temp;
            Console.WriteLine("Enter the first number:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            num2 = Convert.ToInt32(Console.ReadLine());
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("After Swapping ");
            Console.WriteLine("\n First number:" + num1);
            Console.WriteLine("\n Second number:" + num2);

            Console.ReadLine();

        }
    }

}
