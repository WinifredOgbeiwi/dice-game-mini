using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dice_game_mini
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int roll1 = random.Next(1, 7);
            int roll2 = random.Next(1, 7);
            int roll3 = random.Next(1, 7);
            int total = roll1 + roll2 + roll3 ;
            Console.WriteLine($"DICE: {roll1} + {roll2} + {roll3} = {total}");
            if ( roll1 == roll2 || roll2 == roll3 || roll1 == roll3 )
            {
                if (roll1 == roll2 || roll2 == roll3)
                {
                    Console.WriteLine("You rolled doubles! Bonus(+2) added to total");
                    total += 2;
                }
                else
                {
                    Console.WriteLine("You rolled doubles! Bonus(+6) added to total");
                    total += 6;
                }
                Console.WriteLine($"Total + bonus = {total}");
            }

            if(total >=16) Console.WriteLine("You win 3 sticker");
          
            else if (total >= 10) Console.WriteLine("You win 2 sticker");
            else if (total == 7)  Console.WriteLine("You win 1 sticker");
            else Console.WriteLine("You lose");
        }
    }
}
