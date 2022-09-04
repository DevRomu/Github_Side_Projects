using System;

namespace Dice_Game_RO
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int playerRandomNum;
            int enemyRandomNum;

            int playerPoints = 0;
            int enemyPoints = 0;

            Random random = new Random();
            
            /// Random dice rolls for player and
            /// enemy ai is also in this partion of code.
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Press Any Key to continue");
                
                Console.ReadKey();

                playerRandomNum = random.Next(1, 7);
                Console.WriteLine("You rolled a " + playerRandomNum);

                Console.WriteLine("...");

                ///Makes a delay for an Ai and Player to
                ///Generate number.
                System.Threading.Thread.Sleep(1000);

                enemyRandomNum = random.Next(1, 7);
                Console.WriteLine("Enemy AI rolled a " + enemyRandomNum);

                if(playerRandomNum > enemyRandomNum)
                {
                    playerPoints++;
                    Console.WriteLine("Player wins this round.");
                }
                else if(playerRandomNum < enemyRandomNum)
                {
                    enemyPoints++;
                    Console.WriteLine("Enemey wins this round");
                }
                else
                {
                    Console.WriteLine("Draw");
                }

                Console.WriteLine("The score is now - Player : " + playerPoints + ". Enemy :" + enemyPoints); 
            }
            
            if(playerPoints > enemyPoints)
            {
                Console.WriteLine("You win!");
            }
            else if(playerPoints < enemyPoints)
            {
                Console.WriteLine("You lose!");
            }
            else
            {
                Console.WriteLine("Its a draw!");
            }

            Console.ReadKey();
        }

    }

   
}