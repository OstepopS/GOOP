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
        private int stadion = 2;
        private Random random = new Random();
        protected DateTime datetime;
        protected string tournamentName;
        protected string gameFormat;
        protected int numberOfPlayers;
        public SuperTennisMatch()
        {

        }
        public SuperTennisMatch(string tournamentname, DateTime datetime, string gameFormat, int numberOfPlayers)
        {
            this.datetime = datetime;
            this.tournamentName = tournamentname;
            this.gameFormat = gameFormat;
            this.numberOfPlayers = numberOfPlayers;

            for (int i = 0; i < numberOfPlayers; i++)
            {
                //en Tennisplayer bliver genereraet
                var tennismand = new Tennisplayer();
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
            if(IsPowerOfTwo(numberOfPlayers) == true)
            {
            Tournament tournament = new Tournament(tennisPlayer, tournamentName, stadion);
            tournament.Start();
            }
        }
       
        }
    }

