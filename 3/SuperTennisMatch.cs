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
        protected int numberOfPlayers;
        public SuperTennisMatch()
        {

        }
        public SuperTennisMatch(string tournamentname, DateTime datetime, int numberOfPlayers)
        {
            this.datetime = datetime;
            this.tournamentName = tournamentname;
            this.numberOfPlayers = numberOfPlayers;

            for (int i = 0; i < numberOfPlayers; i++)
            {
                //en Tennisplayer bliver genereraet
                var tennismand = new Tennisplayer();
                tennisPlayer.Add(tennismand);
            }
        }
        public void GameSetAndMatch()
        {
            Tournament tournament = new Tournament(tennisPlayer, tournamentName, datetime, stadion);
            tournament.Start();

        }
       
        }
    }

