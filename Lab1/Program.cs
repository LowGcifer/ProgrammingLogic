namespace Lab1;

class Program
{
    static void Main(string[] args)
    {
        // Step 1
        /* Name: Logan Isley 
        Title: IT-1050 - Lab 1
        */

        // Step 2

        Console.WriteLine("Logan Isley, IT-1050 Intro to Programming");

        // Step 3

        int favNumber = 4;
        string progLang = "CSS";
        double programCount = 10;
        bool isExperienced = true;

        Console.WriteLine("Logan's favorite number is " + favNumber + ".");
        Console.WriteLine("Logan's favorite programming language is " + progLang + ".");
        Console.WriteLine("Logan has written " + programCount + " programs.");
        
        if (isExperienced == true)
        {
            Console.WriteLine("Yes, Logan has experience programming.");
        }
        else
        {
            Console.WriteLine("No, Logan doesn't have programming experience.");
        }

        // Step 4

        const string schoolName = "Tri-C";
        Console.WriteLine("Logan goes to school at " + schoolName + ".");

        // Step 5

        double funDouble = 9.78;
        int funInteger = (int) funDouble;

        Console.WriteLine("Double: " + funDouble);
        Console.WriteLine("Int: " + funInteger);
        Console.WriteLine("Integer String: " + Convert.ToString(funInteger));
        Console.WriteLine("Bool String: " + Convert.ToString(isExperienced));

        // Step 6

        Console.WriteLine("Please enter your name: ");
        string userName = Console.ReadLine();

        Console.WriteLine("Please enter your age:");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your name is " + userName + ", and your age is " + age);

        // Step 7

        int num1 = 5;
        int num2 = 8;
        int num3 = num1 + 10;
        Console.WriteLine(num1 + " + 10 = " + num3);
        int num4 = num2 - 2;
        Console.WriteLine(num2 + " - 2 = " + num4);
        int num5 = num1 * 3;
        Console.WriteLine(num1 + " * 3 = " + num5);
        int num6 = num2 / 2;
        Console.WriteLine(num2 + " / 2 = " + num6);
        int num7 = num1 % 2;
        Console.WriteLine(num1 + " % 2 = " + num7);

        // Step 8

        float floatDecimal = 1.123456789F;
        double doubleDecimal = 1.123456789D;

        Console.WriteLine("The float value is: " + floatDecimal + " . The double value is: " + doubleDecimal);

        // Step 9

        int upAndDown = 10;
        upAndDown++;
        Console.WriteLine("The integer upAndDown incremented is: " + upAndDown + ".");
        upAndDown--;
        upAndDown--;
        Console.WriteLine("The integer upAndDown decremented is: " + upAndDown + ".");
        
    }
}
