using System;
using System.Threading;
using static System.Console;


namespace NumberCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool on = true;

            while(on)
            {
                Write("*** Choose one operation below ***");
                WriteLine("\n\n\t[1] Addition");
                WriteLine("\t[2] Subtraction");
                WriteLine("\t[3] Multiplication");
                WriteLine("\t[4] Division");
                WriteLine("\t[5] Modulus");
                WriteLine("\t[E]xit");

                var userPick = ReadKey(true);

                if (userPick.Key == ConsoleKey.E)
                {
                    ForegroundColor = ConsoleColor.Blue;
                    Write("Thanks for playing");
                    
                    Thread.Sleep(2000);
                    on = false;

                    break;
                }

                else if (userPick.Key != ConsoleKey.D1 & userPick.Key != ConsoleKey.NumPad1 &
                        userPick.Key != ConsoleKey.D2 & userPick.Key != ConsoleKey.NumPad2 &
                        userPick.Key != ConsoleKey.D3 & userPick.Key != ConsoleKey.NumPad3 &
                    userPick.Key != ConsoleKey.D4 & userPick.Key != ConsoleKey.NumPad4 &
                    userPick.Key != ConsoleKey.D5 & userPick.Key != ConsoleKey.NumPad5 &
                    userPick.Key != ConsoleKey.E)
                {
                    ForegroundColor = ConsoleColor.Red;
                    Write("\nInvalid choice. Try again!");

                    Thread.Sleep(3000);
                    ForegroundColor = ConsoleColor.Black;
                    Clear();

                    continue;
                }



                Clear();
                
                Write("Write first number: ");
                int firstNr = Convert.ToInt32(ReadLine());
                Write("Write second number: ");
                int secondNr = Convert.ToInt32(ReadLine());

                Clear();
                switch (userPick.Key)
                { 
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:


                        int resultAdd = firstNr + secondNr;
                        Write($"{firstNr} + {secondNr} = {resultAdd}");
                        ReadLine();

                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:

                        int resultSub = firstNr - secondNr;
                        Write($"{firstNr} - {secondNr} = {resultSub}");
                        ReadLine();

                        break;

                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:

                        int resultMulti = firstNr * secondNr;
                        Write($"{firstNr} * {secondNr} = {resultMulti}");
                        ReadLine();

                        break;

                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:

                        int resultDiv = firstNr / secondNr;
                        Write($"{firstNr} / {secondNr} = {resultDiv}");
                        ReadLine();

                        break;

                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:

                        int resultMod = firstNr % secondNr;
                        Write($"{firstNr} % {secondNr} = {resultMod}");
                        ReadLine();

                        break;

                    default:
                        Write("Invalid choice. Choose again!");
                        Thread.Sleep(2000);
                        break;


                }
                Clear();





                


            }
        }
    }
}
