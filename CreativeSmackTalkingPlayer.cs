using System;
using System.Collections.Generic;

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {
        public override int Roll()
        {
        //Make a list of strings which is similar to an array in JS

        List<string> insults = new List<string>{ 
        "You roll worse than a flat tire.",
        "If I rolled as bad as you I'd be a joint full of hot sauce.",
        "I'd rather kiss my sister than roll like you.",
        "You think you're so special...and you are. The fact of your existence is nearly impossible to believe",
        "Compared to you I roll like a dog with no legs rolling down a hill",
        "I'd pay a million dollars to roll against you because I'd win it back in an hour"
        };

        //Create a random number to pull insult from list
        int index = new Random().Next(insults.Count);

        //Pull the insult generated and print it
        Console.WriteLine($"Super Smacker says {insults[index]}");
        return base.Roll();

        }
        
    }
}