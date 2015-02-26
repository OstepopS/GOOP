using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Tennis
{
    class Tournament : SuperTennisMatch
    {
        
        private List<Tennisplayer> tennisPlayer;
        private List<Tennisplayer> tennisPlayerQueue = new List<Tennisplayer>();
        private List<TennisMatch> tennisMatch = new List<TennisMatch>();
        private DateTime tournamentDateTo;
        private DateTime tournamentDateFrom;
        private DateTime matchTime = new DateTime(2008, 1, 1, 12, 30, 0);
        private List<Referee> referee = new List<Referee>();
        private Random random = new Random();
        private string tournamentName;
        private int randomNumber;
        
        private TennisMatch match;
        private Tennisplayer winningTennisPlayer;
        private int stadion;

        public Tournament()
        {

        }

        public Tournament(List<Tennisplayer> tennisPlayer, string tournamentname, DateTime TDT, DateTime TDF)
        {
            this.tennisPlayer = tennisPlayer;
            tournamentName = tournamentname;
            tournamentDateFrom = TDF;
            tournamentDateTo = TDT;
        }
        public Tournament(List<Tennisplayer> tennisPlayer, string tournamentname, DateTime TDF, int stadions)
        {
            this.tennisPlayer = tennisPlayer;
            tournamentName = tournamentname;
            this.stadion = stadions;
            tournamentDateFrom = TDF;
        }
        public void Start()
        {
            do{
            Queue1();
            } while (tennisPlayer.Count > 2);
        }
        public void Queue()
        {

        }
        public void Queue1(){
               do
                {
                    //første spiller
                    randomNumber = random.Next(0, tennisPlayer.Count);
                    Console.WriteLine("" + randomNumber);
                    tennisPlayerQueue.Add(tennisPlayer[randomNumber]);
                    tennisPlayer.RemoveAt(randomNumber);
                    //foreach (Tennisplayer str in tennisPlayerQueue)
                    //   Console.WriteLine(str); 
                   //ingen grund til at sortere de sidste 2 da de alligevel kommer op med hinanden
                } while (tennisPlayer.Count > 2);
                Matching();
            
            

        }
        private int stadions()
        {
            var i = tennisPlayer.Count / 2;
            return i / stadion;
            
        }
        private void Matching()
        {
            tennisPlayer.AddRange(tennisPlayerQueue);
            tennisPlayerQueue.Clear();
            do
            {
                if (tennisPlayer.Count > 1)
                {
                   /* if (referee.Count == 0)
                    {
                        var referee1 = new Referee();
                        referee.Add(referee1);
                        Console.WriteLine("referee added");
                    }*/
                    Console.WriteLine("Ny runde");
                    matchTime = tournamentDateFrom.Date + matchTime.TimeOfDay;
                    var matches = tennisPlayer.Count/2;
                    do
                    {   
                        match = new TennisMatch(tennisPlayer[0], tennisPlayer[1], referee[0], matchTime);
                        tennisPlayer.RemoveAt(1);
                        tennisPlayer.RemoveAt(0);
                        tennisMatch.Add(match);
                        matches--;
                    }while(matches/2 > 0);

                        }
                        
                        
                       // match.Match();
                        //Console.WriteLine(match);
                        //winningTennisPlayer = match.TennisPlayerWinner;
                        Console.WriteLine(winningTennisPlayer);

                        tennisPlayerQueue.Add(winningTennisPlayer);
                 
                    
           
                if (tennisPlayer.Count == 0)
                {                    
                    tennisPlayer.AddRange(tennisPlayerQueue);
                    tennisPlayerQueue.Clear();                   
                }
                if (tennisPlayer.Count == 1)
                {
                    tennisPlayer.Clear();
                    
                }
            } while (tennisPlayer.Count > 0);
            MatchWinner();
           /* foreach (Tennisplayer str in tennisPlayerQueue)
                    Console.WriteLine(str);*/
            
            
            
        }
        private void MatchWinner()
        {

        }
        public void Gender(int tp1, int tp2)
            {
                if (tennisPlayer[tp1].Gender == tennisPlayer[tp2].Gender && tennisPlayer[tp1].Gender == "Male")
                    {
                        Console.WriteLine("Both players are male\n");
                        //MaleMatch();
                    }
                if (tennisPlayer[tp1].Gender == tennisPlayer[tp2].Gender && tennisPlayer[tp1].Gender == "Female")
                    {
                        Console.WriteLine("Both players are female\n");
                        //FemaleMatch();
                    }
            }
        }

         
    }

