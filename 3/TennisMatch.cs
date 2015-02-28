﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Tennis
{
    class TennisMatch : Tournament
    {
        protected Tennisplayer tennisPlayer1;
        protected Tennisplayer tennisPlayer2;
        protected Referee referee;
        private Random random = new Random();
        private DateTime matchTime;
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
        private int gameWon1;
        private int gameWon2;
        private int numberOfSets;
        private string dateFrom;
        private string dateTo;
        private string timeFrom;
        private string timeTo;


        public TennisMatch()
        {

        }
        public TennisMatch(Tennisplayer tennisplayer1, Tennisplayer tennisplayer2, Referee referee, DateTime matchTime)
        {
            tennisPlayer1 = tennisplayer1;
            tennisPlayer2 = tennisplayer2;
            this.referee = referee;
            this.matchTime = matchTime;
        }

        public TennisMatch(Tennisplayer tennisplayer1, Tennisplayer tennisplayer2)
        {
            tennisPlayer1 = tennisplayer1;
            tennisPlayer2 = tennisplayer2;
        }
        public TennisMatch(Tennisplayer tennisplayer1, Tennisplayer tennisplayer2, DateTime datetime)
        {
            tennisPlayer1 = tennisplayer1;
            tennisPlayer2 = tennisplayer2;
            this.datetime = datetime;
        }
        public TennisMatch(Tennisplayer tennisplayer1, Tennisplayer tennisplayer2, DateTime datetime, Referee referee)
        {
            tennisPlayer1 = tennisplayer1;
            tennisPlayer2 = tennisplayer2;
            this.datetime = datetime;
            this.referee = referee;
        }

        public void Start()
        {
            Console.WriteLine("Referee er: " + referee);
            if (tennisPlayer1.Gender == tennisPlayer2.Gender && tennisPlayer1.Gender == "Male")
            {
                Console.WriteLine("Both players are male\n");
                numberOfSets = 5;
                Match();
            }
            if (tennisPlayer1.Gender == tennisPlayer2.Gender && tennisPlayer1.Gender == "Female")
            {
                Console.WriteLine("Both players are female\n");
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

                }
                if (playerPoints2 >= playerPoints1 - 2 && playerPoints2 >= 6)
                {
                    gameWon2++;
                    playerPoints1 = 0;
                    playerPoints2 = 0;
                    MatchTime();

                    //Console.WriteLine("Set " + setsWon2 + " took: " + randomTimeMin + ":" + randomTimeSec + ".");
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
                Console.WriteLine("" + tennisPlayer1.FullNameForMatchWinner + "has won " + setsWon1 + " set.");
            }
            if (gameWon2 == 6)
            {
                setsWon2++;
                gameWon1 = 0;
                gameWon2 = 0;
                playerPoints1 = 0;
                playerPoints2 = 0;
                Console.WriteLine("" + tennisPlayer2.FullNameForMatchWinner + "has won " + setsWon2 + " set.");
            }

        }
        private void Sets()
        {

            do
            {//sets = min 5
                // s
                if ((setsWon1 <= numberOfSets && setsWon1 <= setsWon2 + 2) || (setsWon2 <= numberOfSets && setsWon2 <= setsWon1 + 2))
                {
                    //har ikke den fjerneste ide om hvad jeg skal her det er nok bar en operator der sejler
                    numberOfSets++;
                }
                GamesAndSets();
                
            } while ((setsWon1 <= numberOfSets && setsWon1 <= setsWon2 + 2) || (setsWon2 <= numberOfSets && setsWon2 <= setsWon1 + 2));
            Console.WriteLine("wat" + setsWon1 + setsWon2);
            /*if (setsWon1 > setsWon2)
            {
                setsWon1++;
                Console.WriteLine("" + tennisPlayer1.FullNameForMatchWinner + "has won " + setsWon1 + " set.");
            }
            if (setsWon2 > setsWon1)
            {

                Console.WriteLine("" + tennisPlayer2.FullNameForMatchWinner + "has won " + setsWon2 + " set.");
            }*/

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
            datetime.AddHours(matchTimeHour);
            datetime.AddMinutes(matchTimeMin);
            datetime.AddSeconds(matchTimeSec);
        }

        public string MatchTimeTotal
        {
            get { return "" + matchTimeHour + ":" + matchTimeMin + ":" + matchTimeSec; }
        }
        public Tennisplayer TennisPlayerWinner
        {
            get
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
        }
        public override string ToString()
        {
            if (setsWon1 > setsWon2)
            {

                return "\nThe Match ended with " + tennisPlayer1.FullNameForMatchWinner + " winning over " + tennisPlayer2.FullNameForMatchWinner + ". \nThe Score ended: " + setsWon1 + " - " + setsWon2 + ".\nThe total duration for the match is: " + "0" + matchTimeHour + ":" + matchTimeMin + ":" + matchTimeSec + ".\n" + "The match was played from " + dateFrom + " " + timeFrom + " to " + dateTo + " " + timeTo + ".";
            }
            if (setsWon1 < setsWon2)
            {
                return "\nThe Match ended with " + tennisPlayer2.FullNameForMatchWinner + " winning over " + tennisPlayer1.FullNameForMatchWinner + ". \nThe Score ended: " + setsWon2 + " - " + setsWon1 + ".\nThe total duration for the match is: "/* + "0" + matchTimeHour + ":" + matchTimeMin + ":" + matchTimeSec + ".\n" */ + datetime + "The match was played from " + dateFrom + " " + timeFrom + " to " + dateTo + " " + timeTo + ".";
            }
            else
            {
                return "The match was not played.";
            }
        }
    }
}
