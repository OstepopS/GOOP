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
            DateTime tournamentdate = new DateTime(2015,02,25);
            string tournamentName = "Wimbledon";
            //Referee referee = new Referee()
            SuperTennisMatch Wimbledon = new SuperTennisMatch(tournamentName, tournamentdate,2);
            Wimbledon.GameSetAndMatch();
        }
    }
}
