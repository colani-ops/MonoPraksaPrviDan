using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    internal class SubMenu : AbMenu
    {
        public SubMenu() 
        {
            //Constructor
        }

        public virtual void MenuFunction(int prevMenuChoice)
        {
            Console.Clear();
            while (prevMenuChoice != 0) 
            {
                Console.WriteLine("===Addition / Subtraction===");
                Console.WriteLine("1.Addition");
                Console.WriteLine("2.Subtraction");
                Console.WriteLine("0.Back");
                Console.Write("Selection : ");

                menuInput = Console.ReadLine();
                menuChoice = Convert.ToInt32(menuInput);

                switch (menuChoice)
                {
                    case 1:
                        Console.Clear();

                        Console.Write("Enter the first number : ");
                        string number1 = Console.ReadLine();
                        Console.Write("\n");
                        Console.Write("Enter the second number : ");
                        string number2 = Console.ReadLine();

                        double result;
                        
                        return;
                    case 2:
                        //subtract function here
                        return;
                    case 0:
                        prevMenuChoice = 0;
                        break;
                }
            } 
        }
    }  
}

