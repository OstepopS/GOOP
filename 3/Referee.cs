using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Tennis
{
    class Referee : Person
    {
        
        /*private string refereeFirst;
        private string refereeMiddle;
        private string refereeLast;
        private DateTime dOB;
        private string nationality;
        private string gender;*/
        private DateTime licenseAcquired;
        private DateTime licenseRenewed;
        private bool GM;

        public Referee(string firstname, string middlename, string lastname, string nationality, string gender, DateTime dateofbirth, DateTime licenseacquired, DateTime licenserenewed)
        {
            firstName = firstname;
            middleName = middlename;
            lastName = lastname;
            this.nationality = nationality;
            this.gender = gender;
            DOB = dateofbirth;
            licenseAcquired = licenseacquired;
            licenseRenewed = licenserenewed;
        }

}
}
