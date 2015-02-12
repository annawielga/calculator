// X00097779
//Program calculating toll charges
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toll_calculator
{
    class TollCalculater
    {
        static void Main()
        {
            Console.WriteLine(" Toll calculator");
            Console.WriteLine(" Vehicle type: ");
            Console.WriteLine("\t1. Car");
            Console.WriteLine("\t2. Public Service Vehicle");
            Console.WriteLine("\t3. Bus or Coach");
            Console.WriteLine("\t4. Goods Vehicle");

            
            const double CarCharge = 2.00;
            const double PSVCharge = 2.00;
            const double BusCharge = 2.80;
            const double GoodsCharge = 4.10;

Double userInput = double.Parse(Console.ReadLine());

            double toll = 0;

            if (userInput == 1)
            {
                 toll = CarCharge;
            }
            else if (userInput == 2)
               
                toll = PSVCharge;
            else if (userInput == 3)
           
                toll = BusCharge;
            else if (userInput == 4)
            
                toll = GoodsCharge;
           
            
            const string Yes = "Y";
            const string No = "N";
      
            const double discount = 0.20;
            
            Console.WriteLine(" Electronic type a car?");
            Console.Write("Enter Y if yes");
            Console.Write("Enter N if no");

            string electronic = Console.ReadLine();

            if (electronic == "Y" || electronic == "y")
            {
                toll =   toll - (toll * discount);
                Console.WriteLine("you pay " + toll+ " euros");
            }
            Console.ReadLine();

            }
            
            

        }
    }
