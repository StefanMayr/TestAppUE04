using System;

namespace ArrayTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int arraySize = 0;
            int age = 0;
            string emptyStr = "";
            int[] myFirstArray = { 1, 2, 3, 5 };
            bool isNotTextOnly = false;

            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Console.WriteLine("Good morning dear students!");

            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("today we will talk about arrays!");

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;

            Console.Write("Bitte geben Sie einen Text ein ");
            emptyStr = Console.ReadLine();

            // check for text only
            for (int i = 0; i < emptyStr.Length; i++)
            {
                if(int.TryParse(emptyStr[i].ToString(), out age))
                {
                    isNotTextOnly = true;
                    Console.WriteLine($"Ist eine Zahl {emptyStr[i]}");
                }
                else
                {
                    Console.WriteLine($"Ist keine Zahl {emptyStr[i]}");
                }
            }

            do
            {
                Console.WriteLine("Bitte geben Sie eine Zahl ein");
            } while (!int.TryParse(Console.ReadLine(), out arraySize));

            int[] myArray = new int[arraySize];

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = i + 24;
            }

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine($"Inhalt von {myArray[i]}");
            }
        }
    }
}
