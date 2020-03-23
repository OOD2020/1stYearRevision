/* #############################
 * 
 * Author: Johnathon Mc Grory
 * Date : 4/ 10/ 2019
 * Description : Lab Two Question 4
 * 
 * ############################# */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter int one: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter int two: ");
            int n2 = int.Parse(Console.ReadLine());
            int answer = Sum(n1, n2);
            Console.WriteLine(answer);

        }
        static int Sum(int n1, int n2)
        {
            int number = 0;

            if (n1 < n2)
            {
                for (int i = n1; i < n2; i++)
                {
                    if (n1 % 2 == 0)
                        number += i;
                }

            }
            else if (n2 < n1)
            {
                for (int i = n2; i < n2; i++)
                {
                    if (n2 % 2 == 0)
                        number += i;
                }

            }
            else
            {

            }
            return number;


        }
    }
}
//4.	Write a method:
//static int Sum(int n1, int n2)
//That returns the sum of all even numbers between the two integer arguments(inclusive) passed to it.
//For example: Sum(2, 10) returns 30. 


