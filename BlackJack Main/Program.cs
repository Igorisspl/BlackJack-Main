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
            //get 2 player cards
            Random rnd = new Random();
            int player1 = rnd.Next(1, 22);
            int player2 = rnd.Next(1, 22);
            int total = player1 + player2;
            Console.WriteLine(" Players Card dealt is " + player1);
            Console.WriteLine(" Players Card dealt is " + player2);
            Console.WriteLine("total " + total);


            //repeat
            bool playAgain = true;
            //Console.Write("Do you want to play again? (y/n): ");
            //string input = Console.ReadLine();
            //if (input.ToLower() != "y")
            //{
            //    playAgain = false;
            //}

            while (playAgain)
            {
                int player3 = rnd.Next(1, 22);
                Console.WriteLine(" Players Card dealt is " + player3);
                total += player3;
                Console.WriteLine("total " + total);

                Console.Write("Do you want to play again? (y/n): ");
                 string input = Console.ReadLine();
                if (input.ToLower() != "y")
                {
                    playAgain = false;
                }


            }


            //dealer section
            int dealer1 = rnd.Next(1, 22);
            int dealer2 = rnd.Next(1, 22);
            int dealerTotal = dealer1 + dealer2;
            Console.WriteLine(" Players Card dealt is " + dealer1);
            
            

            if (dealer1 >= 17)
            {
                Console.WriteLine(" Players Card dealt is " + dealer2);
                Console.WriteLine("total " + dealerTotal);
            }
            else
            {
                Console.WriteLine("dealers stays");
            }

            ////compare results
            //if (total > 21)
            //{
            //    Console.WriteLine("U lose");
            //}
            //else if (total1 > 21)
            //{
            //    Console.WriteLine("dealer lose");
            //}
            //else if (total > total1)
            //{
            //    Console.WriteLine("player wins");
            //}
            //else if (total1 > total)
            //{
            //    Console.WriteLine("dealer wins");
            //}
            //else
            //{
            //    Console.WriteLine("Its a tie");
            //}


        }

    }
}
