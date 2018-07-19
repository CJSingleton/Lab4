using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSingleton_Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring while loop default and header elements
            string input = "y";
            string numberw = "Number";
            string squaredw = "Squared";
            string cubedw = "Cubed";
            string sevenmks = "=======";
            string sixmks = "======";


            while (input.ToLower() == "y")//for exit prompt
            { 

                Console.WriteLine("Please enter an integer:");//salutation

                int n = int.Parse(Console.ReadLine());//user input

                string header = string.Format("{0, -10}  {1, -10}  {2, -10}", numberw, squaredw, cubedw);
                Console.WriteLine(header);//create row of labels for "table".

                string border = string.Format("{0, -10}  {1, -10}  {2, -10}", sevenmks, sevenmks, sixmks);
                Console.WriteLine(border);//create border for each label.

                for (int i = 1; i <= n; i++)//runs user input through a for loop that includes calculations.
                {
                    int squared = i * i;
                    int cubed = i * i * i;

                    string result = string.Format("{0, -10}  {1, -10}  {2, -10}", i, squared, cubed);//result converted to string to utilize string.Format.

                    Console.WriteLine(result);
                }

                Console.WriteLine("Would you like to continue? (y/n)");
                input = Console.ReadLine().ToLower();
            }
        }
    }
}