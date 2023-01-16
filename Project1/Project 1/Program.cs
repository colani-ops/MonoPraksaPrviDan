
using Project_1;

class Program
{
    private static void Main(string[] args)
    {
        int mainProgramChoice;
        MainMenu mainMenu = new MainMenu();
        SubMenu subMenu = new SubMenu();


        mainProgramChoice = mainMenu.MenuFunction();

        switch (mainProgramChoice)
        { 
            case 1:
                subMenu.MenuFunction(mainProgramChoice);
                break;
            case 2:

                Console.Clear();

                Console.Write("Enter the first number : ");
                string number1 = Console.ReadLine();
                Console.Write("\n");
                Console.Write("Enter the second number : ");
                string number2 = Console.ReadLine();

                Multiplication multiplyClass = new Multiplication();

                //double result1 = multiplyClass.Multiply(Convert.ToDouble(number1), Convert.ToDouble(number2));

                Console.WriteLine("The result is : " + multiplyClass.GetResult());
                break;
            case 3:

                Console.Clear();

                Console.Write("Enter the first number : ");
                string number3 = Console.ReadLine();
                Console.Write("\n");
                Console.Write("Enter the second number : ");
                string number4 = Console.ReadLine();

                Convert.ToDouble(number3);
                Convert.ToDouble(number4);

                Division divideClass = new Division(number3, number4);
                Console.WriteLine("The result of the operation is : " + divideClass.GetResult());

                break;
        }
    }
}