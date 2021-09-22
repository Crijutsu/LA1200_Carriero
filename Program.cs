using System;

namespace RandomnumberGameEXE
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = @"
   ___               __             _  __           __             _____              
  / _ \___ ____  ___/ /__  __ _    / |/ /_ ____ _  / /  ___ ____  / ___/__ ___ _  ___ 
 / , _/ _ `/ _ \/ _  / _ \/  ' \  /    / // /  ' \/ _ \/ -_) __/ / (_ / _ `/  ' \/ -_)
/_/|_|\_,_/_//_/\_,_/\___/_/_/_/ /_/|_/\_,_/_/_/_/_.__/\__/_/    \___/\_,_/_/_/_/\__/ 
                                                                                      
 ";

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(title);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Welcome to the Random Number Game");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Guide: enter ONLY numbers between 1 and 100! ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Random rd = new Random();

            int rand_um = rd.Next(1, 100);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(rand_um);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Random number got genarated");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Choose a number between 1 and 100");
            Console.ForegroundColor = ConsoleColor.Gray;
            int UserGuesser = Convert.ToInt32(Console.ReadLine());
            int UserAttempt = 1;

            if (UserGuesser > rand_um)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Your number is larger, try typing a smaller one");

                UserAttempt++;
            }
            else if (UserGuesser == rand_um)
            {​​​​​
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("You got it right!");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("It took you " + UserAttempt + " tries");
            }​​​​​
        }
    }
}
