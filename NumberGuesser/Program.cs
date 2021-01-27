using System; //sekcja dyrektyw -> przestrzeń nazw system
using System.Collections.Generic;

namespace NumberGuesser //kontener na klasy i metody
{
    class Program
    {
        static void Main(string[] args)
        {
           
            GetAppInfo();
            string userName = GetUserName();
            GreatUser(userName);
            Random random = new Random();
            int correctNumber = random.Next(1,11);
            bool correctAnswer = false;
            Console.WriteLine("Zgadnij wylosowaną liczbę z przedziału od 1 do 10.");
            while(correctAnswer == false)
            {
                string input = Console.ReadLine();
                int guess;
                bool isNumber = int.TryParse(input,out guess);

                if(isNumber == false)
                {
                    PrintColorMessage(ConsoleColor.Red, $"{input} nie jest liczbą! Proszę wprowadzić liczbę");
                    continue;
                }
                if (guess < 1 || guess >10)
                {
                    PrintColorMessage(ConsoleColor.Red, $"{input} jest z poza zakresu! Proszę wprowadzić liczbę z zakresu od 1 do 10");
                    continue;
                }

                if(guess < correctNumber)
                {
                    PrintColorMessage(ConsoleColor.Red, $"szukana liczba jest większa od {guess}");
                    continue;
                } else if (guess > correctNumber)
                {
                    PrintColorMessage(ConsoleColor.Red, $"szukana liczba jest mniejsza od {guess}");
                    continue;
                }

                else
                {
                    PrintColorMessage(ConsoleColor.Green, $"brawo zgadłeś! szukana liczba to {guess}");
                    correctAnswer = true;
                    //break;
                }

            }
                    }
    static void GetAppInfo()
        {
            string appName = "Zgaduj Zgadula";
            int appVersion = 1;
            string appAuthor = "Krzysztof Koszykowski";
            string info = $"{appName} w wersji: 0.0.{appVersion}, autor: {appAuthor}";

            PrintColorMessage(ConsoleColor.Magenta, info);
            
        }
    static string GetUserName()
        {
            Console.WriteLine("Jak masz na imię?");
            string inputUserName = Console.ReadLine();
            return (inputUserName);
        }
    static void GreatUser(string userName)
        {
           string info = $"Powodzenia {userName}, odgadnij liczbę";
           PrintColorMessage(ConsoleColor.Yellow,info);
                      
        }
    static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }

}
