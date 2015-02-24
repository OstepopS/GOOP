using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Tennis
{
    class SuperTennisMatch
    {
        protected List<Tennisplayer> tennisplayer = new List<Tennisplayer> { };
        protected Referee referee;
        protected DateTime datetime;
        
        public SuperTennisMatch()
        {

        }
        public void Players(int numberOfPlayers)
        {
            DateTime birthday = new DateTime(2011, 01, 02);
            var Peter = new Tennisplayer("Peter", "", "Woodcock", birthday, "Canada", "Male");
            birthday = new DateTime(2010, 5, 4);
            var Moot = new Tennisplayer("Moot", "", "Mootson", birthday, "USA", "Male");
            tennisplayer.Add(Peter); tennisplayer.Add(Moot);
            if (numberOfPlayers == 2)
            {
                var twoplayers = new TennisMatch(tennisplayer);
                twoplayers.Match();
            }
            if (numberOfPlayers == 8)
            {
                EightPlayers();
            }
            if (numberOfPlayers == 16)
            {
                SixteenPlayers();
            }
            if (numberOfPlayers == 32)
            {
                ThirtyTwoPlayers();
            }
            if (numberOfPlayers == 64)
            {
                SixtyFourPlayers();
            }
            GameSetAndMatch();
        }
        private void EightPlayers()
        {

        }
        private void SixteenPlayers()
        {

        }
        private void ThirtyTwoPlayers()
        {

        }
        private void SixtyFourPlayers()
        {

        }
        private void GameSetAndMatch()
        {

        }
    }
}
