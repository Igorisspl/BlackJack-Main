using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_Main
{
    internal class Program
    {

        public static int total ;
        public static int dealerTotal;
        static void Main(string[] args)
        {
            //get 2 player cards
            Random rnd = new Random();
            int player1 = rnd.Next(1, 12);
            int player2 = rnd.Next(1, 12);
            total = player1 + player2;
            Console.WriteLine("Players Card dealt is: " + player1);
            Console.WriteLine("");
            Console.WriteLine("Players Card dealt is: " + player2);
            Console.WriteLine("");
            Console.WriteLine("Total: " + total);
            Console.WriteLine("");
            Check();
            //if (total == 21)
            //{
            //    Console.WriteLine("You win");
            //    Console.ReadLine();
            //}


            //repeat
            bool playAgain = true;
            Console.Write("Do you want another card? (y/n): ");
            string input = Console.ReadLine();
            if (input.ToLower() != "y")
            {
                playAgain = false;
            }

            while (playAgain)
            {
                int player3 = rnd.Next(1, 12);
                Console.WriteLine("Players Card dealt is " + player3);
                total += player3;
                Console.WriteLine("Total: " + total);
                Check();
                //if (total == 21)
                //{
                //    Console.WriteLine("You win");
                //    Console.ReadLine();
                //}

                Console.Write("Do you want another card? (y/n): ");
                input = Console.ReadLine();
                if (input.ToLower() != "y")
                {
                    playAgain = false;
                }


            }


            //dealer section
            int dealer1 = rnd.Next(1, 12);
            int dealer2 = rnd.Next(1, 12);
            dealerTotal = dealer1 + dealer2;
            Console.WriteLine("Dealers card dealt is " + dealer1);
            Console.WriteLine("");
            Console.WriteLine("Dealers card dealt is " + dealer2);
            Console.WriteLine("");
            Console.WriteLine("Dealers total: " + dealerTotal);
            Console.WriteLine("");
            Check();
            //if (dealerTotal == 21)
            //{
            //    Console.WriteLine("Dealer wins");
            //    Console.ReadLine();
            //}



            while (dealerTotal <= 17)
            {
                int dealer3 = rnd.Next(1, 12);
                Console.WriteLine("Dealers Card dealt is " + dealer3);
                dealerTotal += dealer3;
                Console.WriteLine("Total: " + dealerTotal);
                
                
            }
            Check();

            ////compare results

            //if (dealerTotal == 21)
            //{
            //    Console.WriteLine("Dealer wins");
            //    Console.ReadLine();
            //}
            //if (dealerTotal > 21)
            //{
            //    Console.WriteLine("Dealer busts");
            //}
            //else if (total > 21)
            //{
            //    Console.WriteLine("You bust");
            //}
            //else if (dealerTotal > total)
            //{
            //    Console.WriteLine("Dealer wins");
            //}
            //else if (total > dealerTotal)
            //{
            //    Console.WriteLine("You win");
            //}
            //else
            //{
            //    Console.WriteLine("Its a tie");
            //}


        }
        static void Check()
        {
            
            if (total == 21)
            {
                Console.WriteLine("You win");
                Console.ReadLine();
            }
            if (dealerTotal == 21)
            {
                Console.WriteLine("Dealer wins");
                Console.ReadLine();
            }
            if (dealerTotal > 21)
            {
                Console.WriteLine("Dealer busts");
            }
            else if (total > 21)
            {
                Console.WriteLine("You bust");
            }
            else if (dealerTotal > total)
            {
                Console.WriteLine("Dealer wins");
            }
            else if (total > dealerTotal)
            {
                Console.WriteLine("You win");
            }
            else
            {
                Console.WriteLine("Its a tie");
            }
        }

    }
}
