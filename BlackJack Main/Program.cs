using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_Main
{
    internal class Program
    {
        private static Cards card = new Cards();
        static void Main(string[] args)
        {
            Random rnd = new Random();

            bool playAgain = true;
            while (playAgain)
            {

                int player1 = rnd.Next(1, 22);
                int player2 = rnd.Next(1, 22);
                int dealer1 = rnd.Next(1, 22);
                int dealer2 = rnd.Next(1, 22);
                int total = player1 + player2;
                int total1 = dealer1 + dealer2;


                Console.WriteLine(" Players Card dealt is " + player1);
                Console.WriteLine(" Players Card dealt is " + player2);
                Console.WriteLine("total " + total);

                Console.WriteLine(" Dealers Card dealt is " + dealer1);
                Console.WriteLine(" Dealers Card dealt is " + dealer2);
                Console.WriteLine("total " + total1);

                if (total > 21)
                {
                    Console.WriteLine("U lose");
                }
                else if (total1 > 21)
                {
                    Console.WriteLine("dealer lose");
                }
                else if (total > total1)
                {
                    Console.WriteLine("player wins");
                }
                else if (total1 > total)
                {
                    Console.WriteLine("dealer wins");
                }
                else
                {
                    Console.WriteLine("Its a tie");
                }
                Console.Write("Do you want to play again? (y/n): ");
                string input = Console.ReadLine();
                if (input.ToLower() != "y")
                {
                    playAgain = false;
                }
            }





        }



    }
}
