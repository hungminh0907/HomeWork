using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                ShowFunction(); 
               // int Number = EnterANumber();
                int NumberFunction;
                Console.Write("Enter a number in Function: ");
                NumberFunction = int.Parse(Console.ReadLine());
                // update nhập vào dự liệu INT
               // Console.WriteLine(Number);
                switch (NumberFunction)
                {
                    case 1:
                        FunctionOne();
                        break;
                    case 2:
                        FunctionTwo();
                        break;
                    case 3:
                        FunctionThree();
                        break;
                    case 4:
                        FunctionFour();
                        break;
                    case 5:
                        FunctionFive();
                        break;
                    case 6:
                        FunctionSix();
                        break;
                    case 7:
                        FunctionSeven();
                        break;
                    case 8:
                        FunctionEight();
                        break;
                    case 9:
                        FunctionNine();
                        break;
                    case 10:
                        FunctionTen();
                        break;

                    default:
                        Console.WriteLine("");
                        break;
                }
                bool Stop = Escape();
                if (Stop) 
                { 
                  break;
                }    
            }
        }
        //Nhập vào N để xử lý 
        private static int EnterANumber()
        {
            int number;
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());
           return number;
        }

        // Show hiện thị chức năng
        private static void ShowFunction()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Function 1:");
            Console.WriteLine("Function 2:");
            Console.WriteLine("Function 3:"); 
            Console.WriteLine("Function 4:");
            Console.WriteLine("Function 5:");
            Console.WriteLine("Function 6:");
            Console.WriteLine("Function 7:");
            Console.WriteLine("Function 8:");
            Console.WriteLine("Function 9:");
            Console.WriteLine("Function 10:");
            Console.WriteLine("----------------------");
            Console.WriteLine("Please enter to function:");

        }
        
        //Chia het cho 3 
        private static void FunctionOne()
        {
            int Number = EnterANumber();
            if (Number % 3 == 0)
            {
                Console.WriteLine("Number {0} % 3 == 0",Number);
            }
            else
            {
                Console.WriteLine("Nuber {0} % 3 != 0",Number);
            }
        }
        //Bang cuu chuong so N
        private static void FunctionTwo()
        {
            int Number = EnterANumber();
            for(int i = 0; i <= Number; i++)
            {
                for(int j = 0; j <= Number; j++)
                {
                    Console.WriteLine(i * j + " ");
                }
               Console.WriteLine();
            }
        }

        //
        private static void FunctionThree()
        {
            int Number = EnterANumber();
            int Sum = 0;
            for (int i = 1;i <= Number; i++)
            {
                    Sum +=i;
            }    
            Console.WriteLine("The sum of the factors of " + Number + " is " + Sum);
        }
        //
        private static void FunctionFour()
        {
            int Number = EnterANumber();
            if (Number < 1)
            {
                Console.WriteLine("A perfect square cannot be a negative integer");
            }
            int Sqr = (int)Math.Sqrt(Number);
            if (Sqr*Sqr==Number)
            {
                Console.WriteLine("A perfect square can be a negative integer");
            }
        }

        private static void FunctionFive()
        {
            int Number = EnterANumber();
            if (Number > 0 && Number < 13)
            {
                switch (Number)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        Console.WriteLine("Months with 31 days are January, March, May, July, August, October and December");
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        Console.WriteLine("Months with 30 days are April, June, September, and November");
                        break;
                    default:
                        Console.WriteLine("February is a month with 28 or 29 depending on whether it is a leap year or a non-leap year");
                        break;
                }
            }
            else { Console.WriteLine("the number you entered is not available for 12 months sorry please choose another month number"); }
        }
        //
        private static void FunctionSix()
        {
            int Number = EnterANumber();
            int Sum = 0;
            for (int i = 1; i <= Number; i++)
            {
                int q = 1;
                for (int j = 1; j <= i; j++)
                    { q = q * i; }
                Sum = Sum + q;
            }
            Console.WriteLine("S =1^1 + 2^2 + ... {0} ",Sum);
           

        }
        //
        private static void FunctionSeven()
        {
            int Number = EnterANumber();
            int Sum = 0;
            int i;
            for ( i = 1; i <= Number; i++)
            {
                if (Number % 2 != 0)
                {
                    Sum += i;
                }
            }
            Console.Write("Sum = {0}",Sum);

        }

        //
        private static void FunctionEight()
        {
            int Number = EnterANumber();
           if (Number >= 1)
            {
                for (int i = 2;i <= Number; i++)
                {
                    int Count = 0;
                    for(int j = 2;j <= i/2; j++)
                    {
                        if(i % j == 0)
                        { 
                            Count++; 
                        }    
                    }  
                    if(Count == 0)
                    {
                        Console.Write("{0},",i);
                    }    
                }
           }
        }
        //
        private static void FunctionNine()
        {
            int Number = EnterANumber();
            for(int i = 0; i < Number; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write("*");
                }   
                Console.WriteLine();
            }  
        }
        //
        private static void FunctionTen()
        {
            int Number = EnterANumber();
            int NumberOne = 0; 
            int NumberTwo = 1;
            int Sum = 1;

            if (Number <= 0)
            {
                Console.WriteLine("Không phải số dương");
            }
            else if(Number == 1 || Number == 2)
            {
                Console.WriteLine(Number);
            }
            else 
            {
                for(int i = 0;i < Number; i++) 
                {
                    NumberOne = NumberTwo;
                    NumberTwo = Sum;
                    Sum = NumberOne + NumberTwo;
                    Console.Write(" {0}  ", NumberOne);
                }
                
            }
                
        }

        //Stop progam
        private static bool Escape()
        { 
            Console.Write("");
            Console.WriteLine("--------------------");
            Console.WriteLine("Do you want continue");
            Console.WriteLine("Press ESC to exit");
            
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.Escape)
                {
                    Console.WriteLine("Exiting program");
                    return true;
                }
                return false;
        }
    }
}
