﻿using System;
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

            //TennisMatch1();
            //TennisMatch2();
            //Wimbledon8();
            var Wimbledon = new SuperTennisMatch();
            Wimbledon.Players(16);
           
        }
        public static void TennisMatch1()
        {
            DateTime birthday = new DateTime(2011, 01, 02);
            var Caroline = new Tennisplayer("Caroline", "", "Wozniacki", birthday, "Denmark", "Female");
            birthday = new DateTime(2010, 5, 4);
            var Serena = new Tennisplayer("Serena", "Jameka", "Williams", birthday, "USA", "Female");
            DateTime datetime = new DateTime(2011, 01, 02,12,0,0);
            var CaroVSSerena = new TennisMatch(Caroline, Serena, datetime);
            Console.WriteLine(Caroline);
            Console.WriteLine(Serena);
            CaroVSSerena.Match();
            
            Console.WriteLine(CaroVSSerena);
            
        }

        /*public static void TennisMatch2()
        {
            var Roger = new Tennisplayer("Roger", "", "Federer", "1981-07-08", "Switzerland", "Male");
            var Nadal = new Tennisplayer("Rafael", "Nadal", "Parera", "1986-06-03", "Spain", "Male");
            DateTime datetime = new DateTime(2011, 01, 02, 12, 0, 0);
            var RogerVSNadal = new TennisMatch(Roger, Nadal, datetime);
            Console.WriteLine(Roger);
            Console.WriteLine(Nadal);
            RogerVSNadal.Match();
            Console.WriteLine(RogerVSNadal);
            //Console.WriteLine(RogerVSNadal.MatchTimeTotal);
        }*/
        public static void Wimbledon8()
        {
            
            DateTime dateFrom = new DateTime (2011,01,02);
            DateTime dateTo = new DateTime(2011, 01, 05);
            //var Wimbledon = new Tournament(tennisplayer, "Wimbledon", dateFrom, dateTo);
            //Wimbledon.Start();
            
        }
    }
}
