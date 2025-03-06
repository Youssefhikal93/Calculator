using System.ComponentModel;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = new List<int>();
            string input;

            while (true)
            {
                Console.WriteLine("Please choose opertaion to start between ['+', '-', '*', '/'], Press '-1' to end the application");

                string operation = Console.ReadLine();

                if (operation.Trim() == "+" || operation.Trim() == "-")
                {

                    while (true)
                    {
                        Console.WriteLine("Please enter the numbers. Type 'calculate' to perform the operation.");
                        input = Console.ReadLine();

                        if (input.ToLower() == "calculate")
                        {
                            break;
                        }

                        if (int.TryParse(input, out int number))
                        {
                            numbers.Add(number);
                            Console.WriteLine($"Number {number} is number {numbers.Count} in the list!");
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number or type 'calculate' to perform the operation.");
                        }
                    }

                    int sum = 0;   
                    if(operation.Trim() == "+")
                    {
                        sum = Calculator.Add(numbers.ToArray());
                    }
                    else if (operation.Trim() == "-")
                    {
                        sum = Calculator.Substract(numbers.ToArray());
                    }
                   

                    Console.WriteLine($"the sum is {sum}");
                    numbers.Clear();


                }
          
                else if (operation.Trim() == "*" || operation.Trim() == "/")
                {
                    Console.WriteLine("please enter the first number");
                    string input1 = Console.ReadLine();
                    Console.WriteLine("please enter the second number");
                    string input2 = Console.ReadLine();

                    float result = 0;
                    if (int.TryParse(input1, out int num1) && int.TryParse(input2, out int num2))
                    {
                      result =  operation.Trim() == "*" ? result = Calculator.Multiply(num1, num2)
                        : result = Calculator.Divide(num1, num2);
                    }
                    else
                    {
                        Console.WriteLine("Invalid inputs. Please enter a valid number.");
                    }
                    Console.WriteLine($"the sum is {result}");
                }
                else
                {
                    Console.WriteLine("Invalid operation. Please choose a valid operation.");

                }

                if (operation.Trim() == "-1")
                {
                    break;
                }


            }
        }
    }
}