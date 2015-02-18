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
            TennisMatch2();
            
        }
        public static void TennisMatch1()
        {
            var Caroline = new Tennisplayer("Caroline", "", "Wozniacki", "1990-06-11", "Denmark", "Female");
            var Serena = new Tennisplayer("Serena", "Jameka", "Williams", "1981-09-26", "USA", "Female");
            var CaroVSSerena = new TennisMatch(Caroline, Serena);
            Console.WriteLine(Caroline);
            Console.WriteLine(Serena);
            CaroVSSerena.Match();
            Console.WriteLine(CaroVSSerena);
        }

        public static void TennisMatch2()
        {
            var Roger = new Tennisplayer("Roger", "", "Federer", "1981-07-08", "Switzerland", "Male");
            var Nedal = new Tennisplayer("Rafael", "Nadal", "Parera", "1986-06-03", "Spain", "Male");
            var RogerVSNedal = new TennisMatch(Roger, Nedal);
            Console.WriteLine(Roger);
            Console.WriteLine(Nedal);
            RogerVSNedal.Match();
            Console.WriteLine(RogerVSNedal);
        }
    }
}
