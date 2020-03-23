/* #############################
 * 
 * Author: Johnathon Mc Grory
 * Date : 4/ 10/ 2019
 * Description : Lab Two Question 3
 * 
 * ############################# */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[7];

            Zero(myArray);

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
           
        }
        static Array Zero(int [] myArray)
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = 0;
            }
            return myArray;
        }
    }
}

//3.	Write a method named Zero that accepts an int array as an argument and stores the value 0 in each element.

