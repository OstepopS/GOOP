using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Tennis
{
    class Stadion
    {
        private bool isPlayed = false;

        public bool takeStadion()
        {
            if(isPlayed == false)
            {
                isPlayed = true;
                Console.WriteLine("sæbe"); 
             return isPlayed; 
            }
            else
            {
                Console.WriteLine("fukmeinass");
                return isPlayed;
                // returner  at den er optaget
            }
        }
        public bool releaseStadion()
        {
            isPlayed = false;
            return true;
        }

        public DateTime reScheduleMatch(DateTime oldtime)
        {
            // var newdate = oldtime + nyt delay
            // if tidspunkt  er helt ude og skide
            // forsøg at håndter det ved at ligge det en anden dag.
            // return newdate;
            return oldtime;
            // eventuelt have en class med en form for skema i hvor at du kan checke både stadions og tidspunkter
        }

    }
}
