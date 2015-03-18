using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Tennis
{
    class SuperTennisMatch
    {
        protected List<Tennisplayer> tennisPlayer = new List<Tennisplayer> { };
        protected static int stadion = 2;
        protected Random random = new Random();
        protected DateTime datetime;
        protected string tournamentName;
        protected static string gameFormat;
        public string gender { get; set; }

        protected int numberOfPlayers;
        public SuperTennisMatch()
        {

        }
        public SuperTennisMatch(string tournamentname, DateTime datetime, string gameFormat1, string gender, int numberOfPlayers)
        {
            this.datetime = datetime;
            this.tournamentName = tournamentname;
            gameFormat = gameFormat1;
            this.numberOfPlayers = numberOfPlayers;
            this.gender = gender;

            for (int i = 0; i < numberOfPlayers; i++)
            {
                // Tennisplayers bliver genereret
                var tennismand = new Tennisplayer(this.gender);
                tennisPlayer.Add(tennismand);
            }
        }
        public bool IsPowerOfTwo(int x)
        {
            return (x != 0) && (x & (x - 1)) == 0;
        }
        public void GameSetAndMatch()
        {
            if (IsPowerOfTwo(numberOfPlayers) == false)
            {
                Console.WriteLine("The tennis tournament can not be played with that amount of people");
            }
            if (IsPowerOfTwo(numberOfPlayers) == true)
            {
                Tournament tournament = new Tournament(tennisPlayer, tournamentName);
                
                tournament.Start();
            }
        }

    }
}

