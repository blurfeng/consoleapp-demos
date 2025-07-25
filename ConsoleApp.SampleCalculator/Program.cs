﻿namespace ConsoleApp.SampleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 变量声明。
            // Variable Declarations
            int choice = 0;
            int num1, num2 = 0;

            while (choice != -1)
            {
                try
                {
                    PrintMenu();

                    choice = Convert.ToInt32(Console.ReadLine());

                    if (choice == -1)
                    {
                        break;
                    }

                    Console.Write("Please enter the first number: ");
                    num1 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Please enter the second number: ");
                    num2 = Convert.ToInt32(Console.ReadLine());

                    // 根据用户选择的操作执行相应的计算。
                    // Decide which operation is needed based on selected option

                    // 使用 if 语句选择操作。
                    /*If statements */
                    //if (choice == 1)
                    //{
                    //    /* do addition */
                    //}
                    //else if (choice == 2)
                    //{
                    //    /* subtraction*/
                    //}
                    //else if (choice == 3)
                    //{
                    //    /*Multiplication*/
                    //}
                    //else if (choice == 4)
                    //{
                    //    /*Division*/
                    //}
                    //else
                    //{
                    //    Console.WriteLine("Invalid choice");
                    //}
                    // Prompt for user input

                    // 使用 switch 语句选择操作。
                    /* Switch statement */
                    int answer = 0;
                    switch (choice)
                    {
                        case 1:
                            answer = AddNumbers(num1, num2);
                            break;
                        case 2:
                            answer = SubtractNumbers(num1, num2);
                            break;
                        case 3:
                            answer = Product(num1, num2);
                            break;
                        case 4:
                            answer = Quotient(num1, num2);
                            break;
                        case 5:
                            answer = Fibonnaci(num1, num2);
                            break;
                        default:
                            throw new Exception("Invalid Menu Item Selected.");
                    }

                    // print output 
                    Console.WriteLine($"The result is: {answer}");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Cannot divide by zero");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadLine();
                }
            }

            Console.WriteLine("******** - Thank you for using the sample calculator! - ********");

            // 方法声明。
            // Method Definitions.
            int AddNumbers(int num1, int num2)
            {
                return num1 + num2;
            }

            int SubtractNumbers(int num1, int num2)
            {
                return num1 - num2;
            }

            int Product(int num1, int num2)
            {
                return num1 * num2;
            }

            int Quotient(int num1, int num2)
            {
                return num1 / num2;
            }

            int Fibonnaci(int num1, int num2)
            {
                var answer = 0;
                for (int i = num1; i <= num2; i++)
                {
                    answer += i;
                }
                return answer;
            }

            void PrintMenu()
            {
                // 在 while 循环开始时清除控制台并显示欢迎消息。
                // Clear the console and show welcome message at the start of while loop
                Console.Clear();
                Console.WriteLine("******** - Welcome to the sample calculator! - ********");

                // 提示用户输入操作。
                // Show calculator options / Show menu
                Console.WriteLine("Please select an operation (-1 to exit program) ");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Fibonacci sequence");
            }
        }
    }
}
