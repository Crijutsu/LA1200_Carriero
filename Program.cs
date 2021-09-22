using System;

namespace NumberGameEXE
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
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine(rand_um);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Random number got generated");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Choose a number between 1 and 100 ");
                Console.ForegroundColor = ConsoleColor.Gray;
            int UserGuesser = 0;
            int UserAttempt = 0;

            while(UserGuesser != rand_um)
            {
                UserGuesser = Convert.ToInt32(Console.ReadLine());
                if (UserGuesser > rand_um)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Your number is larger, try typing a smaller one －O－");
                    UserAttempt++;
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("You have another try, GOOD LUCK <(＿　＿)>");
                }

            else if (UserGuesser == rand_um)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("You got it right! ;P");
                Console.ForegroundColor = ConsoleColor.Cyan;
                    UserAttempt++;
                    Console.WriteLine("It took you " + UserAttempt + " tries");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            else if (UserGuesser < rand_um)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Your number is smaller, try tipping a larger one ^_~");
                    UserAttempt++;
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("You have another try, GOOD LUCK <(＿　＿)>");
                }



            }
            }
            
            
    }
}
