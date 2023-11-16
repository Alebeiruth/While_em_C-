using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace WhileIteration
{
    class Program
    {
        static void Main(string[] args) 
        {
            bool displayMenu = true;
            while (displayMenu) 
            {
                displayMenu = MainMenu();
            }
        
        }

        private static bool MainMenu()
        {
            Console.Clear();//limpa o console 
            Console.WriteLine("Chooose an option:");
            Console.WriteLine("1) Print Numbers");
            Console.WriteLine("2) Guessing Name");
            Console.WriteLine("3) Exit");
            string result = Console.ReadLine();

            if(result == "1")
            {
                PrintNumbers();
                return true;
            }
            else if (result == "2")
            {
                GuessingGame();
                return true;
            }
            else if (result == "3")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private static void PrintNumbers()
        {
            Console.Clear();//limpa o console
            Console.WriteLine("Print numbers!");
            Console.Write("Type a number: ");
            int result = int.Parse(Console.ReadLine()); //int.Parse transforma String e Int de 32 bits
            int counter = 1;
            while(counter < result + 1)
            {
                Console.Write(counter);
                Console.Write('-');
                counter++;
            }
            Console.ReadLine();
        }
        private static void GuessingGame()
        {
            Console.WriteLine("Guessing game!");
            Console.ReadLine();

            Random myRandom = new Random();
            int randomNumber = myRandom.Next(1, 11);

            int guesses = 0;
            bool incorrect = true;

            do
            {
                Console.WriteLine("Guess a number between 1 and 10: ");
                string result = Console.ReadLine();
                guesses++;

                if (result == randomNumber.ToString())
                    incorrect = false;
                else
                    Console.WriteLine("Wrong!");

            } while (incorrect);

            Console.WriteLine("Correct! It took {0} guesses", guesses);

            Console.ReadLine();
            
        }
    }
}