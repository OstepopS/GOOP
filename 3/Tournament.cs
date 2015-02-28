using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Tennis
{
    class Tournament : SuperTennisMatch
    {
        private int counter = 1;
        private List<Tennisplayer> tennisPlayerQueue = new List<Tennisplayer>();
        private List<TennisMatch> tennisMatch = new List<TennisMatch>();
        private DateTime tournamentDateFrom;
        private DateTime matchTime = new DateTime(2008, 1, 1, 12, 30, 0);
        private List<Referee> referee = new List<Referee>();
        private Random random = new Random();
        private int randomNumber;
        private TennisMatch match;
        private Tennisplayer winningTennisPlayer;
        private int stadion;

        public Tournament()
        {

        }

        public Tournament(List<Tennisplayer> tennisPlayer, string tournamentname, DateTime TDF, int stadions)
        {
            this.tennisPlayer = tennisPlayer;
            tournamentName = tournamentname;
            this.stadion = stadions;
            tournamentDateFrom = TDF;
            for (int hest = 0; hest < stadions; hest++)
            {
                var referee1 = new Referee(new DateTime(1589, 12, 12), new DateTime(1420, 12, 11));
                referee.Add(referee1);
            }
        }
        public void Start()
        {
            do
            {
                QueueRandomPlayers();
            } while (tennisPlayer.Count > 2);
        }

        public void QueueRandomPlayers()
        {
            do
            {
                //Random spiller der bliver tilføjet til tennisPlayerQueue og bliver fjernet fra tennisPlayer
                randomNumber = random.Next(0, tennisPlayer.Count);
                Console.WriteLine("" + randomNumber);
                tennisPlayerQueue.Add(tennisPlayer[randomNumber]);
                tennisPlayer.RemoveAt(randomNumber);
                //ingen grund til at sortere de sidste 2 da de alligevel kommer op med hinanden
            } while (tennisPlayer.Count > 2);
            QueueMatches();
        }

        private void QueueMatches()
        {
            tennisPlayer.AddRange(tennisPlayerQueue);
            tennisPlayerQueue.Clear();
            do
            {
                if (tennisPlayer.Count > 1)
                {
                    Console.WriteLine("Ny runde");
                    //time of day bliver tilføjet til matchTime sammen med datoen der er blevet parset via constucteren.

                    matchTime = tournamentDateFrom.Date + matchTime.TimeOfDay;
                    var matches = tennisPlayer.Count / 2;
                    do
                    {
                        Console.WriteLine("Spillere tilbage " + tennisPlayer.Count);
                        Console.WriteLine("Kampe tilbage " + matches);
                        Console.WriteLine("kamp " + counter++);
                        //alle matches der skal laves bliver tilføjet til listen tennisMatch sådan at de kan spilles.
                        match = new TennisMatch(tennisPlayer[0], tennisPlayer[1], referee[random.Next(0, referee.Count)], matchTime);
                        tennisMatch.Add(match);
                        match.Start();
                        winningTennisPlayer = match.TennisPlayerWinner;
                        tennisPlayerQueue.Add(winningTennisPlayer);
                        //tennisPlayerQueue.Add(winningTennisPlayer);
                        //de 2 tennisspillere der er er tilføjet til tennisMatch bliver nu fjernet fra listen med tennisspillere
                        tennisPlayer.RemoveAt(1);
                        tennisPlayer.RemoveAt(0);
                        //matches tælles nu en ned.
                        matches--;
                    } while (matches > 0);
                }
                if (tennisPlayer.Count == 0)
                {
                    tennisPlayer.AddRange(tennisPlayerQueue);
                    tennisPlayerQueue.Clear();
                }
                if (tennisPlayer.Count == 1)
                {
                    winningTennisPlayer = tennisPlayer[0];
                    tennisPlayer.Clear();
                }
            } while (tennisPlayer.Count > 0);
            Console.WriteLine("the winner is: " + winningTennisPlayer);
        }
    }
}

