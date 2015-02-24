using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Tennis
{
    class Tennisplayer : Person
    {



        public Tennisplayer(string fN, string mN, string lN, DateTime dob, string nat, string gen)
        {
            firstName = fN;
            middleName = mN;
            lastName = lN;
            DOB = dob;
            nationality = nat;
            gender = gen;
            
        }
        
        private string name(string firstName, string middleName, string lastName)
        {
            if (middleName == "")
            {
                fullName = "Name: " + firstName + " " + lastName + "\n";
            }
            else
            {
                fullName = "Name: " + firstName + " " + middleName + " " + lastName + "\n";
            }
            return fullName;
        }
        public override string ToString()
        {
            return name(firstName, middleName, lastName) + "Date of Birth: " + DOB + "\n" + "Nationality: " + nationality + "\n" + "Gender: " + gender + "\n";
        }

        public string Gender
        {
            get { return gender; }
        }
        public string FullName
        {
            get { return name( firstName,  middleName, lastName); }
        }
        public string FullNameForMatchWinner
        {
            get { return NameForMatchWinner(firstName, middleName, lastName); }
        }
        private string NameForMatchWinner(string firstName, string middleName, string lastName)
        {
            if (middleName == "")
            {
                fullName = "" + firstName + " " + lastName;
            }
            else
            {
                fullName = "" + firstName + " " + middleName + " " + lastName;
            }
            return fullName;
        }

    }
}
