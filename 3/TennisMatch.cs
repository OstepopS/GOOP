using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Tennis
{
    class TennisMatch : SuperTennisMatch
    {
        protected Tennisplayer tennisPlayer1;
        protected Tennisplayer tennisPlayer2;
        
        private Random random = new Random();
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
        private string dateFrom;
        private string dateTo;
        private string timeFrom;
        private string timeTo;


        public TennisMatch()
        {

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


        
        public void Match()
            {
                Console.WriteLine("dfdf");
                if (tennisPlayer1.Gender == tennisPlayer2.Gender && tennisPlayer1.Gender == "Male")
                    {
                        Console.WriteLine("Both players are male\n");
                        MaleMatch();
                    }
                if (tennisPlayer1.Gender == tennisPlayer2.Gender && tennisPlayer1.Gender == "Female")
                    {
                        Console.WriteLine("Both players are female\n");
                        FemaleMatch();
                    }
            }

        private void PointsAndSets(int numberofsets)
        {
            do
            {
                do
                {
                    randomNumber = random.Next(1, 3);
                    
                    if (randomNumber == 1)
                        {
                            playerPoints1++;
                            //Console.WriteLine("Player 1 has " + playerPoints1 + " points.");
                        }
                    if (randomNumber == 2)
                        {
                            playerPoints2++;
                            //Console.WriteLine("Player 2 has " + playerPoints2 + " points.");
                        }
                }while (playerPoints1 < 6 && playerPoints2 < 6);
                          
            if (playerPoints1 == 6)
            {
                setsWon1++;
                playerPoints1 = 0;
                playerPoints2 = 0;
                MatchTime();
                Console.WriteLine("" + tennisPlayer1.FullNameForMatchWinner + " has won " + setsWon1 + " sets.");
                Console.WriteLine("Set " + setsWon1 + " took: " + randomTimeMin + ":" + randomTimeSec + ".");
            }
            if (playerPoints2 == 6)
            {
                setsWon2++;
                playerPoints1 = 0;
                playerPoints2 = 0;
                MatchTime();
                Console.WriteLine("" + tennisPlayer2.FullNameForMatchWinner + " has won " + setsWon2 + " sets.");
                Console.WriteLine("Set " + setsWon2 + " took: " + randomTimeMin + ":" + randomTimeSec + ".");
            }
            }while  (setsWon1 < numberofsets && setsWon2 < numberofsets);
        }

        private void MaleMatch()
            {
                PointsAndSets(5);
            }
        private void FemaleMatch()
            {
                PointsAndSets(3);    
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
        
        public string MatchTimeTotal{
            get{ return "" +  matchTimeHour + ":" + matchTimeMin + ":" + matchTimeSec;}
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
                return "\nThe Match ended with " + tennisPlayer2.FullNameForMatchWinner + " winning over " + tennisPlayer1.FullNameForMatchWinner + ". \nThe Score ended: " + setsWon2 + " - " + setsWon1 + ".\nThe total duration for the match is: "/* + "0" + matchTimeHour + ":" + matchTimeMin + ":" + matchTimeSec + ".\n" */ + datetime +  "The match was played from " + dateFrom + " " + timeFrom + " to " + dateTo + " " + timeTo + ".";
            }
            else
            {
                return "The match was not played.";
            }
            
        }
            
    }

}
