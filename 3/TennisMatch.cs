using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Tennis
{
    class TennisMatch
    {
        private Tennisplayer tennisPlayer1;
        private Tennisplayer tennisPlayer2;
        private Random random = new Random();
        private int randomTimeMin;
        private int randomTimeSec;
        private int MatchTimeHour;
        private int MatchTimeMin;
        private int MatchTimeSec;
        private int randomNumber;
        private int playerPoints1;
        private int playerPoints2;
        private int setsWon1;
        private int setsWon2;



        public TennisMatch( Tennisplayer tennisplayer1, Tennisplayer tennisplayer2)
        {
            tennisPlayer1 = tennisplayer1;
            tennisPlayer2 = tennisplayer2;
        }
        
        public void Match()
            {
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
            MatchTimeMin = MatchTimeMin + randomTimeMin;
            MatchTimeSec = MatchTimeSec + randomTimeSec;

             if (MatchTimeSec >= 60)
            {
                
                MatchTimeMin = MatchTimeMin + 1;
                MatchTimeSec = MatchTimeSec - 60;
            }
            if (MatchTimeMin >= 60)
            {
                MatchTimeHour = MatchTimeHour + 1;
                MatchTimeMin = MatchTimeMin - 60;
            }
           
        }
        public override string ToString()
        {
            if (setsWon1 > setsWon2)
            {
                return "\nThe Match ended with " + tennisPlayer1.FullNameForMatchWinner + " winning over " + tennisPlayer2.FullNameForMatchWinner + ". \nThe Score ended: " + setsWon1 + " - " + setsWon2 + ".\nThe total duration for the match is: " + "0" + MatchTimeHour + ":" + MatchTimeMin + ":" + MatchTimeSec + ".";
            }
            if (setsWon1 < setsWon2)
            {
                return "\nThe Match ended with " + tennisPlayer2.FullNameForMatchWinner + " winning over " + tennisPlayer1.FullNameForMatchWinner + ". \nThe Score ended: " + setsWon2 + " - " + setsWon1 + ".\nThe total duration for the match is: " + "0" + MatchTimeHour + ":" + MatchTimeMin + ":" + MatchTimeSec + ".";
            }
            else
            {
                return "The match was not played.";
            }
            
        }
            
    }

}
