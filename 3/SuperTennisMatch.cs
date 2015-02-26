using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Tennis
{
    class SuperTennisMatch
    {
        protected List<Tennisplayer> tennisplayer = new List<Tennisplayer> { };
        
        protected DateTime datetime;
        protected string tournamentName;

        public SuperTennisMatch()
        {


        }
        public SuperTennisMatch(string tournamentname, DateTime datetime)
        {
            this.datetime = datetime;
            this.tournamentName = tournamentname;

        }
        public void Players(int numberOfPlayers)
        {
            DateTime birthday = new DateTime(2011, 01, 02);
            var Peter = new Tennisplayer("Peter", "ff", "Woodcock", birthday, "Canada", "Male");
            birthday = new DateTime(2010, 5, 4);
            var Moot = new Tennisplayer("Moot", "", "Mootson", birthday, "USA", "Male");

            for (int i = 0; i <= numberOfPlayers; i++)
            {
                //hvordan med forskellige spillere?
                tennisplayer.Add(Peter);            
            }     
            GameSetAndMatch();
        }
          

        private void GameSetAndMatch()
        {
            Tournament tournament = new Tournament(tennisplayer, tournamentName, datetime, 2);
            tournament.Start();
        }
    }
}
