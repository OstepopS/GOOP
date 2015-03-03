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
        private DateTime matchTime = new DateTime(2023, 11, 3, 15, 34, 23);
        private List<Referee> referee = new List<Referee>();
        private Random random = new Random();
        private int randomNumber;
        private TennisMatch match;
        private Tennisplayer winningTennisPlayer;
        private int stadion;
        protected int singleOrDouble;

        public Tournament()
        {

        }

        public Tournament(List<Tennisplayer> tennisPlayer, string tournamentname, int stadions)
        {
            this.tennisPlayer = tennisPlayer;
            tournamentName = tournamentname;
            this.stadion = stadions;
            //Laver en game master og fjerner ham fra listen af referees. Der er lige så mange referees som der er stations+1 fordi der skal være en game master Kappa
            for (int i = 0; i < stadion + 1; i++)
            {
                var referee1 = new Referee(new DateTime(1589, 12, 12), new DateTime(1420, 12, 11));
                referee.Add(referee1);
            }
            referee[stadion].GM = true;
            Console.WriteLine("The game master for this turnament is: " + referee[stadion]);
            //Her kan game master hentes hvis han skal bruges Keepo
            referee.RemoveAt(stadion);

        }
        public virtual void Start()
        {
            if (gameFormat == "Single")
            {
                do
                {
                    singleOrDouble = 2;
                    QueueRandomPlayers();
                } while (tennisPlayer.Count > 2);

            }
            else
            {

                do
                {
                    singleOrDouble = 4;
                    QueueRandomPlayers();
                } while (tennisPlayer.Count > 4);

            }
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
            } while (tennisPlayer.Count > singleOrDouble);
            QueueMatches();
        }

        private void QueueMatches()
        {
            tennisPlayer.AddRange(tennisPlayerQueue);
            tennisPlayerQueue.Clear();
            do
            {             //Koden herunder skal laves om så der er 4 personer 
                if (tennisPlayer.Count > 1)
                {
                    Console.WriteLine("Ny runde");
                    //time of day bliver tilføjet til matchTime sammen med datoen der er blevet parset via constucteren.

                    datetime = datetime.Date + matchTime.TimeOfDay;
                    var matches = tennisPlayer.Count / 2;
                    do
                    {
                        Console.WriteLine("Spillere tilbage " + tennisPlayer.Count);
                        Console.WriteLine("Kampe tilbage " + matches);
                        Console.WriteLine("kamp " + counter++);
                        //alle matches der skal laves bliver tilføjet til listen tennisMatch sådan at de kan spilles.
                        match = new TennisMatch(tennisPlayer[0], tennisPlayer[1], referee[random.Next(0, referee.Count)], datetime);
                        tennisMatch.Add(match);
                        match.Start();
                        Console.WriteLine("Match" + match.KingKappaHD());
                        match.KingKappaHD();
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

