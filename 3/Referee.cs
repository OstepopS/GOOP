﻿using System;
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
        private bool GM;

        public Referee(DateTime licAQ, DateTime licRe)
            : base()
        {
            licenseAcquired = licAQ;
            licenseRenewed = licRe;
        }
    }
}
