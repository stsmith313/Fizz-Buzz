using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 101; i++)
            {
                if(i % 3 == 0 && i % 5 == 0) //if there is a multiple of 3 and 5 then it will output fizzbuzz
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if(i % 3 == 0) //if it is a multiple of 3 then we will output fizz
                {
                    Console.WriteLine("Fizz");
                }
                else if(i % 5 == 0) //if the number is a multiple of 5 then we will output buzz
                {
                    Console.WriteLine("Buzz");
                }
                else //otherwise we will output the number that we are at
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
