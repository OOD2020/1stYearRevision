/* #############################
 * 
 * Author: Johnathon Mc Grory
 * Date : 4/ 10/ 2019
 * Description : Lab Two Question 1
 * 
 * ############################# */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            bool allowed = AgeTest(age);
            if (allowed == true)
            {
                Console.WriteLine("Welcome to a young adult only site. Keith cannot access this content.");
            }
            else
            {
                Console.WriteLine("You cannot access this site");
            }

        }
        static Boolean AgeTest(int age)
        {
            bool answer;
            if ((age >= 18) && (age <= 21))
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            return answer;
        }
    }
}
//1.	A website only allows users in the age bracket 18 to 21 inclusive to access its content.
//    Write a method that accepts the age as an int argument and decides whether it is possible to access the site.
//    Your method shall return a boolean value.


