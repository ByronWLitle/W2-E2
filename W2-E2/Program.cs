using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Prompts user to give number
            Console.Write("Enter an integer: ");
            //Input is converted to integer and stored in variable/memory
            int inputNum = int.Parse(Console.ReadLine());
            //Initialize variables before entering while loop
            int sum = 0;
            int rem = 0;
            //Calculates sum by seperating each number
            while (inputNum > 0) 
            {
                rem = inputNum % 10; //Divides number by 10 and stores remainder
                sum = sum + rem; //Number is now stored in sum
                inputNum = inputNum / 10; //Goes to next number by dividing by 10
            }
            Console.WriteLine($"The sum of the digits is: {sum}");
            Console.ReadLine();
        }
    }
}   
