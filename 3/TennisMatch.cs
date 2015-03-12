using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Tennis
{
    class TennisMatch : Tournament
    {
        public Tennisplayer tennisPlayer1 { get; set; }
        public Tennisplayer tennisPlayer2 { get; set; }
        public Tennisplayer tennisPlayer3 { get; set; }
        public Tennisplayer tennisPlayer4 { get; set; }

        protected Referee referee;

        private int randomTimeMin;
        private int randomTimeSec;
        private int matchTimeHour;
        private int matchTimeMin;
        private int matchTimeSec;
        private int matchTimeTotal;
        private int randomNumber;
        private int playerPoints1;
        private int playerPoints2;
        private int setsWon1;
        private int setsWon2;
        public int Winner1 { get; set; }
        public int Winner2 { get; set; }
        private int gameWon1;
        private int gameWon2;
        private int numberOfSets;
        private string dateFrom;
        private string dateTo;
        private string timeFrom;
        private string timeTo;
        private DateTime matchTime1;


        public TennisMatch()
        {

        }
        public TennisMatch(Tennisplayer tennisplayer1, Tennisplayer tennisplayer2, Referee referee, DateTime matchTime)
        {
            tennisPlayer1 = tennisplayer1;
            tennisPlayer2 = tennisplayer2;
            this.referee = referee;
            this.matchTime1 = matchTime;

        }
        public TennisMatch(Tennisplayer tennisplayer1, Tennisplayer tennisplayer2, Tennisplayer tennisplayer3, Tennisplayer tennisplayer4, Referee referee, DateTime matchTime)
        {
            tennisPlayer1 = tennisplayer1;
            tennisPlayer2 = tennisplayer2;
            tennisPlayer3 = tennisplayer3;
            tennisPlayer4 = tennisplayer4;
            this.referee = referee;
            this.matchTime1 = matchTime;

        }

        public TennisMatch(Tennisplayer tennisplayer1, Tennisplayer tennisplayer2)
        {
            tennisPlayer1 = tennisplayer1;
            tennisPlayer2 = tennisplayer2;
        }
        /*public TennisMatch(Tennisplayer tennisplayer1, Tennisplayer tennisplayer2, DateTime datetime)
        {
            tennisPlayer1 = tennisplayer1;
            tennisPlayer2 = tennisplayer2;
            this.datetime = datetime;
        }*/
        public TennisMatch(Tennisplayer tennisplayer1, Tennisplayer tennisplayer2, DateTime datetime, Referee referee)
        {
            tennisPlayer1 = tennisplayer1;
            tennisPlayer2 = tennisplayer2;
            this.datetime = datetime;
            this.referee = referee;
        }

        public override void Start()
        {
            Console.WriteLine("Referee er: " + referee);
            if (tennisPlayer1.Gender == tennisPlayer2.Gender && tennisPlayer1.Gender == "Male")
            {
                Console.WriteLine("All players are male\n");
                numberOfSets = 5;

                Match();
            }
            if (tennisPlayer1.Gender == tennisPlayer2.Gender && tennisPlayer1.Gender == "Female")
            {
                Console.WriteLine("All players are female\n");
                numberOfSets = 3;
                Match();
            }
        }
        private void PointToPlayer()
        {

            randomNumber = random.Next(1, 3);
            if (randomNumber == 1)
            {
                playerPoints1++;
            }
            if (randomNumber == 2)
            {
                playerPoints2++;
            }
            //Console.WriteLine("The Score is " + playerPoints1 + " - " + playerPoints2);
        }
        private void Match()
        {
            GamesAndSets();
            Sets();
        }
        private void GamesAndSets()
        {

            int numberOfGames = 6;
            do
            {
                PointToPlayer();
                if (playerPoints1 == 3 && playerPoints2 == 3)
                {
                    //Deuce
                    do
                    {
                        PointToPlayer();
                    } while ((playerPoints1 == playerPoints2 + 2) || (playerPoints2 == playerPoints1 + 2));
                }
                if (playerPoints1 >= playerPoints2 - 2 && playerPoints1 >= 6)
                {
                    //player 1 vinder et game
                    gameWon1++;
                    playerPoints1 = 0;
                    playerPoints2 = 0;
                    MatchTime();

                    Console.WriteLine("Set " + setsWon1 + " took: " + matchTime.TimeOfDay);
                }
                if (playerPoints2 >= playerPoints1 - 2 && playerPoints2 >= 6)
                {
                    gameWon2++;
                    playerPoints1 = 0;
                    playerPoints2 = 0;
                    MatchTime();

                    Console.WriteLine("Set " + setsWon2 + " took: " + matchTime.TimeOfDay);
                }


            } while (gameWon1 < numberOfGames && gameWon2 < numberOfGames);
            Console.WriteLine("");
            if (gameWon1 == 6)
            {
                setsWon1++;
                gameWon1 = 0;
                gameWon2 = 0;
                playerPoints1 = 0;
                playerPoints2 = 0;
                Console.WriteLine("" + tennisPlayer1.FullNameForMatchWinner + " has won " + setsWon1 + " set.");
            }
            if (gameWon2 == 6)
            {
                setsWon2++;
                gameWon1 = 0;
                gameWon2 = 0;
                playerPoints1 = 0;
                playerPoints2 = 0;
                Console.WriteLine("" + tennisPlayer2.FullNameForMatchWinner + " has won " + setsWon2 + " set.");
            }

        }
        private void Sets()
        {
            do
            {


                GamesAndSets();
                    
                if ((setsWon1 >= setsWon2 + 2) && (setsWon1 >= numberOfSets))
                {
                    Winner1 = 1;
                }

                if ((setsWon2 >= setsWon1 + 2) && (setsWon2 >= numberOfSets))
                {
                    Winner2 = 1;
                }
            } while (Winner1 == 0 && Winner2 == 0);
            Console.WriteLine("The Match ended: " + setsWon1 + " - " + setsWon2);

        }
        private void MatchTime()
        {

            randomTimeMin = random.Next(1, 31);
            randomTimeSec = random.Next(1, 60);
            matchTimeMin = matchTimeMin + randomTimeMin;
            matchTimeSec = matchTimeSec + randomTimeSec;

            if (matchTimeSec >= 60)
            {
                matchTimeMin = matchTimeMin + 1;
                matchTimeSec = matchTimeSec - 60;
            }
            if (matchTimeMin >= 60)
            {
                matchTimeHour = matchTimeHour + 1;
                matchTimeMin = matchTimeMin - 60;
            }
           matchTime = matchTime.AddHours(matchTimeHour);
           matchTime = matchTime.AddMinutes(matchTimeMin);
           matchTime = matchTime.AddSeconds(matchTimeSec);
           //Console.WriteLine("gg " + matchTime.TimeOfDay);

        }

        public string MatchTimeTotal
        {
            get { return "" + matchTimeHour + ":" + matchTimeMin + ":" + matchTimeSec; }
        }
        /* public Tennisplayer TennisPlayerWinner
         {
             get
             {
                 if (singleOrDouble == 2)
                 {
                     if (setsWon1 > setsWon2)
                     {

                         return tennisPlayer1;
                     }

                     else
                     {
                         return tennisPlayer2;
                     }
                 }
                 else
                 {
                     if (setsWon1 > setsWon2)
                     {

                         return tennisPlayer1 + tennisPlayer3;
                     }

                     else
                     {
                         return tennisPlayer2 + tennisPlayer4;
                     }
                 }
             }
         }*/
        public string ToString()
        {
            Console.WriteLine("" + singleOrDouble);
            if (singleOrDouble == 2)
            {
                if (Winner1 == 1)
                {
                    return "\nThe Match ended with " + tennisPlayer1.FullNameForMatchWinner + " winning over " + tennisPlayer2.FullNameForMatchWinner + ". \nThe Score ended: " + setsWon1 + " - " + setsWon2 + ".\nThe total duration for the match is: "/* + "0" + matchTimeHour + ":" + matchTimeMin + ":" + matchTimeSec + ".\n"*/ + matchTime + "The match was played from " + datetime + " " + timeFrom + " to " + dateTo + " " + timeTo + ".";
                }
                if (Winner2 == 1)
                {
                    return "\nThe Match ended with " + tennisPlayer2.FullNameForMatchWinner + " winning over " + tennisPlayer1.FullNameForMatchWinner + ". \nThe Score ended: " + setsWon2 + " - " + setsWon1 + ".\nThe total duration for the match is: "/* + "0" + matchTimeHour + ":" + matchTimeMin + ":" + matchTimeSec + ".\n" */ + matchTime + "The match was played from " + datetime + " " + timeFrom + " to " + dateTo + " " + timeTo + ".";
                }
                else
                {
                    return "The match was not played.";
                }
            }
            if( singleOrDouble == 4)
            {
                if (Winner1 == 1)
                {
                    return "\nThe Match ended with " + tennisPlayer1.FullNameForMatchWinner + " and " + tennisPlayer3.FullNameForMatchWinner + " winning over " + tennisPlayer2.FullNameForMatchWinner + " and " + tennisPlayer4.FullNameForMatchWinner + ". \nThe Score ended: " + setsWon1 + " - " + setsWon2 + ".\nThe total duration for the match is: "/* + "0" + matchTimeHour + ":" + matchTimeMin + ":" + matchTimeSec + ".\n"*/ + matchTime + "The match was played from " + datetime + " " + timeFrom + " to " + dateTo + " " + timeTo + ".";
                }
                if (Winner2 == 1)
                {
                    return "\nThe Match ended with " + tennisPlayer2.FullNameForMatchWinner + " and " + tennisPlayer4.FullNameForMatchWinner + " winning over " + tennisPlayer1.FullNameForMatchWinner + " and " + tennisPlayer3.FullNameForMatchWinner + ". \nThe Score ended: " + setsWon2 + " - " + setsWon1 + ".\nThe total duration for the match is: "/* + "0" + matchTimeHour + ":" + matchTimeMin + ":" + matchTimeSec + ".\n" */ + "{0:dddd}" + matchTime + "The match was played from " + datetime + " " + timeFrom + " to " + dateTo + " " + timeTo + ".";
                }
                else
                {
                    return "The match was not played.";
                }
            }
            else
            {
                return "The match was not played.";
            }

        }
    }
}
