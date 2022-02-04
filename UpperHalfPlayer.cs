using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player whose role will always be in the upper half of their possible rolls
    public class UpperHalfPlayer : Player
    {
        public override int Roll()
        {
            // int upperDice = 1;
            // while (upperDice < DiceSize/2) {
            //     upperDice = new Random().Next(DiceSize);
            // }

            // return upperDice + 1;


            return new Random().Next(DiceSize/2,DiceSize) + 1;

        }
    }
}