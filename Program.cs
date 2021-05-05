using System;

namespace ConsoleApp1
{

   class Program
    {
        const int MinSideLength = 2;

        public static void Main(string[] args)
        {
            int UserNumber = GetNumberFromUser();
            try
            {
                DoMagic(UserNumber);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            
        }

        public static void DoMagic(int UserNumber)
        {
            //int MinSideLength = 2;
            Console.WriteLine(GenerateNumbersSequence(UserNumber));
            Console.WriteLine(BuildSquare(UserNumber, MinSideLength));
        }

        public static int GetNumberFromUser(string SendMessage = "Введи число")
        {
            int UserNumber;

            Console.WriteLine(SendMessage);
            string UserMessage = Console.ReadLine();
            while(!Int32.TryParse(UserMessage, out UserNumber))
            {
                Console.WriteLine("Не удалось преобразовать в число");
                Console.WriteLine(SendMessage);
                UserMessage = Console.ReadLine();
            }
            return UserNumber;            
        }

        public static string GenerateNumbersSequence(int sequenceLastNumber)
        {
            string numberSequence = "";

            for(int number = 1; number <= sequenceLastNumber; number++)
            {
                numberSequence += (number == sequenceLastNumber)
                ? number
                : number + ", ";
            }

            return numberSequence;
        }

        public static string BuildSquare(int sideLength, int MinSideLength)
        {
            string square = string.Empty;

            if (sideLength < MinSideLength || sideLength % 2 == 0)
            {
                throw new ArgumentException(
                    $"Длина стороны не может быть меньше или равна {MinSideLength} и не может быть чётной");
            }

            int centerSide = sideLength / 2 + 1;

            for (int height = 1; height <= sideLength; height++)
            {
                for (int width = 1; width <= sideLength; width++)
                {
                    square += (height == centerSide && width == centerSide)
                    ? " "
                    : "*";                    
                }
                square += "\n";
            }
            return square;
        }
        
    }
    
}

