using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    internal class MainMenu : AbMenu
    {
        public MainMenu()
        {
            //Constructor
        }

        public virtual int MenuFunction()
        {
            while (true)
            {
                Console.WriteLine("===Calculator===");
                Console.WriteLine("1.Addition/Subtraction");
                Console.WriteLine("2.Multiplication");
                Console.WriteLine("3.Division");
                Console.WriteLine("0.Exit");
                Console.WriteLine("Selection : ");

                menuInput = Console.ReadLine();
                menuChoice = Convert.ToInt32(menuInput);

                switch (menuChoice)
                {
                    case 0:
                        Console.WriteLine("Successfuly exited the program");
                        return 0;
                    case 1:
                        return 1;
                    case 2:
                        return 2;
                    case 3:
                        return 3;
                }
            } 
        }
    }
}

