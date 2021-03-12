using System;
using System.Collections.Generic;

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {
        public List<string> SmackLines { get; } = new List<string>()
        {
            "Yaaaaaaaaa boy! In YO FACE!",
            "Ready to lose?",
            "HAHAHAHAHAH!",
            "GET OUT OF HERE!",
            "You're straight up trash!",
            "LOL Look at this guy!",
        };

        public override void Play(Player other)
        {
            int x = new Random().Next(6) + 1;
            Console.WriteLine(SmackLines[x]);
            base.Play(other);
        }
    }
}