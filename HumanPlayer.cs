using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A player that prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
        public override int Roll()
        {
            Console.WriteLine("What number would you like to roll?");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}