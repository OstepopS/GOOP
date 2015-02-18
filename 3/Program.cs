using System;
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
            Wimbledon8();
        }
        public static void TennisMatch1()
        {
            var Caroline = new Tennisplayer("Caroline", "", "Wozniacki", "1990-06-11", "Denmark", "Female");
            var Serena = new Tennisplayer("Serena", "Jameka", "Williams", "1981-09-26", "USA", "Female");
            var CaroVSSerena = new TennisMatch(Caroline, Serena, "2011-04-03", "2011-04-03", "12:00", "15:00");
            Console.WriteLine(Caroline);
            Console.WriteLine(Serena);
            CaroVSSerena.Match();
            Console.WriteLine(CaroVSSerena);
        }

        public static void TennisMatch2()
        {
            var Roger = new Tennisplayer("Roger", "", "Federer", "1981-07-08", "Switzerland", "Male");
            var Nadal = new Tennisplayer("Rafael", "Nadal", "Parera", "1986-06-03", "Spain", "Male");
            var RogerVSNadal = new TennisMatch(Roger, Nadal, "2011-04-03","2011-04-03","12:00","15:00");
            Console.WriteLine(Roger);
            Console.WriteLine(Nadal);
            RogerVSNadal.Match();
            Console.WriteLine(RogerVSNadal);
            //Console.WriteLine(RogerVSNadal.MatchTimeTotal);
        }
        public static void Wimbledon8()
        {
            var Peter = new Tennisplayer("Peter", "", "Woodcock", "1981-07-08", "Canada", "Male");
            var Moot = new Tennisplayer("Moot", "", "Mootson", "1981-07-08", "USA", "Male");
            var Henrik = new Tennisplayer("Henrik", "", "Prins", "1981-07-08", "Danmark", "Male");
            var Frederik = new Tennisplayer("Frederik", "", "Kronprins", "1981-07-08", "Danmark", "Male");
            var Joachim = new Tennisplayer("Joachim", "", "prins", "1981-07-08", "Danmark", "Male");
            var Jacob = new Tennisplayer("Jacob", "", "Fedoriksen", "1981-07-08", "Germany", "Male");
            var John = new Tennisplayer("John", "", "Hitler", "1981-07-08", "Germany", "Male");
            var Anders = new Tennisplayer("Anders", "Behring", "Breivik", "1981-07-08", "Sweeden", "Male");
            Tennisplayer[] array = {Peter, Moot,Henrik,Frederik};
            DateTime dateFrom = new DateTime (2011,01,02);
            DateTime dateTo = new DateTime(2011, 01, 05);
            var Wimbledon = new Tournament(array, "Wimbledon", dateFrom, dateTo);
            Wimbledon.Matching();
        }
    }
}
