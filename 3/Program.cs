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
            DateTime tournamentdate = new DateTime(1999, 12, 12);
            string tournamentName = "Wimbledon";
            string gameFormat = "Single";
            //Referee referee = new Referee()
            SuperTennisMatch Wimbledon = new SuperTennisMatch(tournamentName, tournamentdate, gameFormat, 2);
            Wimbledon.GameSetAndMatch();
        }
    }
}
