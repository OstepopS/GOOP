using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Tennis
{
    class Program
    {
        
        public static void Main(string[] args)
        {

            SuperTennisMatch();
        }

        private static void SuperTennisMatch()
        {
            DateTime tournamentdate = new DateTime(2015, 3, 25, 17, 0, 0);
            string tournamentName = "Wimbledon";
            string gameFormat = "Single";
            string gender1 = "Male";
            int players = 8;
            //Referee referee = new Referee()
            SuperTennisMatch Wimbledon = new SuperTennisMatch(tournamentName, tournamentdate, gameFormat, gender1, players);
            Wimbledon.GameSetAndMatch();

        }
    }
}
