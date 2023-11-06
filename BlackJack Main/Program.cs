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
            int player = rnd.Next(1, 22);
            int dealer = rnd.Next(1, 22);

            Console.WriteLine("player " + player);
            Console.WriteLine("dealer " + dealer);

            if (player > dealer)
            {
                Console.WriteLine("player wins");
            }
            else if (dealer > player)
            {
                Console.WriteLine("dealer wins");
            }
            else
            { 
                Console.WriteLine("Its a tie");
            }
            
        }
       

        
    }
}
