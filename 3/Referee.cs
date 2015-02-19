using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Tennis
{
    class Referee
    {
        
        private string refereeFirst;
        private string refereeMiddle;
        private string refereeLast;
        private DateTime dOB;
        private string nationality;
        private string gender;
        private DateTime licenseAcquired;
        private DateTime licenseRenewed;
        private bool GM;

        public Referee(string firstname, string middlename, string lastname, string nationality, string gender, DateTime dateofbirth, DateTime licenseacquired, DateTime licenserenewed)
        {
            refereeFirst = firstname;
            refereeMiddle = middlename;
            refereeLast= lastname;
            this.nationality = nationality;
            this.gender = gender;
            dOB = dateofbirth;
            licenseAcquired = licenseacquired;
            licenseRenewed = licenserenewed;
        }

}
}
