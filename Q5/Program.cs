/* #############################
 * 
 * Author: Johnathon Mc Grory
 * Date : 4/ 10/ 2019
 * Description : Lab Two Question 5
 * 
 * ############################# */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the amount of stock you have: ");
            int stockAmount = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the amount you want to sell: ");
            int saleAmount = int.Parse(Console.ReadLine());
            bool answer = StockOnHand(stockAmount, saleAmount);
            if (answer == true)
            {
                Console.WriteLine("Sale possible");
            }
            else
            {
                Console.WriteLine("Sale not possible");
            }
        }
        static bool StockOnHand(int stockAmount, int saleAmount)
        {
            bool answer;
            if (stockAmount > saleAmount)
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

//5.	Write a method that accepts a stock-on-hand figure and a sales figure as int arguments.
//    It will update the stock-on-hand figure by deducting the sales figure 
//    if there is sufficient stock to fulfil the sale.  
    
//    The method shall return true if the stock-on-hand figure has been updated, otherwise false.