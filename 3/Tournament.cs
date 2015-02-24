using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Tennis
{
    class Tournament
    {
        
        private List<Tennisplayer> tennisPlayer;
        private List<Tennisplayer> tennisPlayerQueue = new List<Tennisplayer>();
        private DateTime tournamentDateTo;
        private DateTime tournamentDateFrom;
        private Random random = new Random();
        private string tournamentName;
        private int randomNumber;
        private TennisMatch match;
        private Tennisplayer winningTennisPlayer;



        public Tournament(List<Tennisplayer> tennisplayer, string tournamentname, DateTime TDT, DateTime TDF)
        {
            tennisPlayer = tennisplayer;
            tournamentName = tournamentname;
            tournamentDateFrom = TDF;
            tournamentDateTo = TDT;
        }
        public Tournament(List<Tennisplayer> tennisplayer, string tournamentname, DateTime TDF)
        {
            tennisPlayer = tennisplayer;
            tournamentName = tournamentname;
            tournamentDateFrom = TDF;
        }
        public void Start()
        {
            do{
            Queue();
            } while (tennisPlayer.Count > 2);
        }
        public void Queue(){
               do
                {
                    //første spiller
                    randomNumber = random.Next(0, tennisPlayer.Count);
                    //Console.WriteLine("" + randomNumber);
                    //var tennisPlayerToQueue = new List<Tennisplayer> { };
                    tennisPlayerQueue.Add(tennisPlayer[randomNumber]);
                    tennisPlayer.RemoveAt(randomNumber);
                    //foreach (Tennisplayer str in tennisPlayerQueue)
                    //   Console.WriteLine(str); 


                    //anden spiller
                    randomNumber = random.Next(0, tennisPlayer.Count);
                    //Console.WriteLine("" + randomNumber);
                    tennisPlayerQueue.Add(tennisPlayer[randomNumber]);
                    tennisPlayer.RemoveAt(randomNumber);
                    //foreach (Tennisplayer str in tennisPlayerQueue)
                    //  Console.WriteLine(str);

                } while (tennisPlayer.Count > 2);
                Matching();
            
            

        }
        private void Matching()
        {
            tennisPlayer.AddRange(tennisPlayerQueue);
            tennisPlayerQueue.Clear();
            do
            {
                if (tennisPlayer.Count > 1)
                {
                    Console.WriteLine("Ny runde");
                    match = new TennisMatch(tennisPlayer[0], tennisPlayer[1]);
                    match.Match();
                    //Console.WriteLine(match);
                    winningTennisPlayer = match.TennisPlayerWinner;
                    Console.WriteLine(winningTennisPlayer);

                    tennisPlayerQueue.Add(winningTennisPlayer);
                    tennisPlayer.RemoveAt(1);
                    tennisPlayer.RemoveAt(0);

                }
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
           /* foreach (Tennisplayer str in tennisPlayerQueue)
                    Console.WriteLine(str);*/
            
            
            
        }
        private void MatchWinners()
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

