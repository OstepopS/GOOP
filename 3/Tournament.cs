using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Tennis
{
    class Tournament
    {
        private TennisMatch match;
        private Tennisplayer[] tennisPlayer;
        private string tournamentName;
        private DateTime tournamentYear;
        private DateTime tournamentDateTo;
        private DateTime tournamentDateFrom;
        private Random random = new Random();
        private int randomNumber;
        private int gg = 2;
        private int penis;

        public Tournament(Tennisplayer[] tennisplayer, string tournamentname, DateTime TDT, DateTime TDF)
        {
            tennisPlayer = tennisplayer;
            tournamentName = tournamentname;
            tournamentDateFrom = TDF;
            tournamentDateTo = TDT;
        }
        public void Matching(){
            do
            {
                randomNumber = random.Next(0, tennisPlayer.Length);
                //Console.WriteLine("" + randomNumber);
               
                tennisPlayer = tennisPlayer.Where(val => val != gg).ToArray();
            } while (tennisPlayer.Length > 1);
            

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

