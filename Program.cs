using System;
using System.Collections.Generic;
using System.Linq;

namespace ShootingDice
{
    class Program
    {
        static void Main(string[] args)
        {

            Player player1 = new Player();
            player1.Name = "Bob";

            Player player2 = new Player();
            player2.Name = "Sue";

            SmackTalkingPlayer smackTalker = new SmackTalkingPlayer();
            smackTalker.Name = "Joe";

            OneHigherPlayer higherRoller = new OneHigherPlayer();
            higherRoller.Name = "Cheater";

            HumanPlayer human = new HumanPlayer();
            human.Name = "Ryan";

            CreativeSmackTalkingPlayer haha = new CreativeSmackTalkingPlayer();
            haha.Name = "Ronald";

            SoreLoserPlayer madchad = new SoreLoserPlayer();
            madchad.Name = "Chad";

            Player player3 = new Player();
            player3.Name = "Wilma";


            Player large = new LargeDicePlayer();
            large.Name = "Bigun Rollsalot";

            UpperHalfPlayer lucky = new UpperHalfPlayer();
            lucky.Name = "Lucy";

            SoreLoserUpperHalfPlayer sorecheater = new SoreLoserUpperHalfPlayer();
            sorecheater.Name = "Walter";

            List<Player> players = new List<Player>() {
                player1, player2, player3, large, smackTalker, higherRoller, haha, madchad, sorecheater, lucky
            };

            PlayMany(players);
        }

        static void PlayMany(List<Player> players)
        {
            Console.WriteLine();
            Console.WriteLine("Let's play a bunch of times, shall we?");

            // We "order" the players by a random number
            // This has the effect of shuffling them randomly
            Random randomNumberGenerator = new Random();
            List<Player> shuffledPlayers = players.OrderBy(p => randomNumberGenerator.Next()).ToList();

            // We are going to match players against each other
            // This means we need an even number of players
            int maxIndex = shuffledPlayers.Count;
            if (maxIndex % 2 != 0)
            {
                maxIndex = maxIndex - 1;
            }

            // Loop over the players 2 at a time
            for (int i = 0; i < maxIndex; i += 2)
            {
                Console.WriteLine("-------------------");


                // Make adjacent players play noe another
                Player player1 = shuffledPlayers[i];
                Player player2 = shuffledPlayers[i + 1];

                try
                {
                    player1.Play(player2);
                }
                catch (Exception ex)
                {
                    if (ex.Message == "angry")
                    {
                        Console.WriteLine(@"
                (( _______
     _______     /\O    O\
    /O     /\   /  \      \
   /   O  /O \ / O  \O____O\ ))
((/_____O/    \\    /O     /
  \O    O\    / \  /   O  /
   \O    O\ O/   \/_____O/
    \O____O\/ ))          ))
  ((
                ");
                        Console.WriteLine("I CAN'T STAND LOSING!!!");
                        continue;
                    }

                    if (ex.Message == "cheater angry")
                    {
                        Console.WriteLine("NOOOOOOOOOOOOOOOO! I NEVER LOSE!");
                        continue;
                    }
                }

            }
        }
    }
}