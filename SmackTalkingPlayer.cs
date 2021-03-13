using System;

namespace ShootingDice
{
    // A Player who shouts a taunt every time they roll dice
    public class SmackTalkingPlayer : Player
    {
        public string Taunt { get; } = "Here comes the winning roll!";

        public override void Play(Player other)
        {
            Console.WriteLine(Taunt);
            base.Play(other);
        }
    }
}