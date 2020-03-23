/* #############################
 * 
 * Author: Johnathon Mc Grory
 * Date : 4/ 10/ 2019
 * Description : Lab Two Question 2
 * 
 * ############################# */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter what product you would like to buy: ");
            string product = Console.ReadLine();
            product = product.ToLower();
            double price = Price(product);
            if (price == -999)
            {
                Console.WriteLine("error");
            }
            else
            {
                Console.WriteLine("The cost is: " + price);
            }

        }
        static double Price(string product)
        {
            double price;
            switch (product)
            {
                case "jeans":
                    price = 67.99;
                    break;

                case "jacket":
                    price = 68.99;
                    break;
                case "boots":
                    price = 34.99;
                    break;

                case "scarves":
                case "belts":
                case "socks":
                    price = 10;
                    break;

                default:
                    price = -999;
                    break;
            }
            return price;
        }
    }
}

//2.	Write a method that uses a switch statement to return the cost of a product, where the method receives a product description as a string argument.

//The cost of each product is listed below:

//Product Description Cost
//“Jeans”	67.99
//“Jacket”	68.99
//“Boots”	34.99
//“Scarves”,”Belts”,”Socks”	These are all 10
//None of the above   Signal error with a cost of -999
