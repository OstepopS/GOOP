using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Tennis
{
    class Referee : Person
    {
        private DateTime licenseAcquired;
        private DateTime licenseRenewed;
        public bool GM { get; set; }

        public Referee(DateTime licAQ, DateTime licRe)
            : base("Male")
        {
            licenseAcquired = licAQ;
            licenseRenewed = licRe;
        }
    }
}
