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
            string input = "y";
            string numberw = "Number";
            string squaredw = "Squared";
            string cubedw = "Cubed";
            string sevenmarks = "=======";


            while (input.ToLower() == "y")
            { 

                Console.WriteLine("Please enter an integer:");

                int n = int.Parse(Console.ReadLine());

                string header = string.Format("{0, 10}  {1, 10}  {2, 10}", numberw, squaredw, cubedw);
                Console.WriteLine(header);
                string border = string.Format("{0, 10}  {1, 10}  {2, 10}", sevenmarks, sevenmarks, sevenmarks);
                Console.WriteLine(border);

                for (int i = 1; i <= n; i++)
                {
                    int squared = i * i;
                    int cubed = i * i * i;

                    string result = string.Format("{0, 10}  {1, 10}  {2, 10}",
                        i,
                        squared,
                        cubed);

                    Console.WriteLine(result);
                }

                Console.WriteLine("Would you like to continue? (y/n)");
                input = Console.ReadLine();
            }
        }
    }
}