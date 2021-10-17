using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;
            int userChoice;
            double firstNumber;
            double secondNumber;
            bool successfullParse;
            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine("Welcome to your calculator");
                Console.WriteLine("[1] Addition");
                Console.WriteLine("[2] Multiplikation");
                Console.WriteLine("[3] Subtraction");
                Console.WriteLine("[4] Division");
                Console.WriteLine("[5] Convert celsius to farenheit");
                Console.WriteLine("[6] Calcultate area and circumference from radius");
                Console.WriteLine("[7] Quit");
                Console.Write("Choose an option: ");
                Int32.TryParse(Console.ReadLine(), out userChoice);

                //Switch 
                switch (userChoice)
                {
                    
                    case 1:
                        Console.Clear();
                        firstNumber = getNumber("first number");
                        secondNumber = getNumber("second number");
                        Console.WriteLine("Result: " + addition(firstNumber, secondNumber));
                        Console.WriteLine("Press any key to get back to the menu");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        firstNumber = getNumber("first number");
                        secondNumber = getNumber("second number");
                        Console.WriteLine("Result: " + multiplicaton(firstNumber, secondNumber));
                        Console.WriteLine("Press any key to get back to the menu");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        firstNumber = getNumber("first number");
                        secondNumber = getNumber("second number");
                        Console.WriteLine(subtraction(firstNumber, secondNumber));
                        Console.WriteLine("Result: " + subtraction(firstNumber, secondNumber));
                        Console.WriteLine("Press any key to get back to the menu");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        firstNumber = getNumber("first number");
                        secondNumber = getNumber("second number");
                        while(secondNumber == 0)
                        {
                            Console.WriteLine("Cant divide by zera enter a new second number");
                            secondNumber = getNumber("secondNumber");

                        }
                        if(secondNumber != 0)
                        {
                            Console.WriteLine("Result: " + division(firstNumber, secondNumber));
                            Console.WriteLine("Press any key to get back to the menu");
                            Console.ReadKey();
                        }
                       
                        break;
                    case 5:
                        Console.WriteLine("Enter how many celsius you want to convert to farenheit");
                        double celsius = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(celsius + " is " + convertToFarenheit(celsius) + " in farenheit!");
                        Console.WriteLine("Press any key to return to the menu!");
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.Write("Enter the radius: ");
                        double radius = Convert.ToInt32(Console.ReadLine());
                        double area = radius * radius * Math.PI;
                        double circumference = 2 * Math.PI * radius;
                        Console.WriteLine("Area: " + area + "\nCircumference: " + circumference);
                        Console.WriteLine("Press any key to return to the main menu!");
                        Console.ReadKey();
                        break;
                    case 7:
                        isRunning = false;
                        break;
                    default:
                        break;
                }

            }
            
        }
        public static double convertToFarenheit(double celsius)
        {
            double farenheit = celsius * 1.8 + 32;
            return farenheit;
        }
        //functions to calculate the result from user input
        public static double addition(double num1,double num2)
        {
            double num3 = num1 + num2;
            return num3;
        }
        public static double subtraction(double num1, double num2)
        {
            double num3 = num1 - num2;
            return num3;
        }
        public static double multiplicaton(double num1, double num2)
        {
            double num3 = num1 * num2;
            return num3;
        }
        public static double division(double num1, double num2)
        {
            double num3 = num1 / num2;
            return num3;
        }
        //Function to get numbers from user
        public static int getNumber(string specifyMumber)
        {
            Console.Write("Enter " + specifyMumber + ": ");
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }
        private static int checkUserInput(int input)
        {
            while(input == 0)
            {
                Console.WriteLine("Enter a number between 1-7: ");
                input = Int32.Parse(Console.ReadLine());
            }
            return input;
        }
    }
}
