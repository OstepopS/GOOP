using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Tennis
{
    class Tennisplayer : Person
    {

        public Tennisplayer(string gender)
        {
            this.gender = gender;
            Console.WriteLine("sssssssssssssssssssss" + gender);
        }

        public Tennisplayer(): base()
        { 
            Console.WriteLine("sssssssssssssssssssss" + gender);
            gender = "Male";
            Console.WriteLine("sssssssssssssssssssss" + gender);
        }

        public Tennisplayer(string fN, string mN, string lN, DateTime dob, string nat, string gen)
        {
            firstName = fN;
            middleName = mN;
            lastName = lN;
            dateOfBirth = dob;
            nationality = nat;
            gender = gen;
        }
                
        public Tennisplayer(string fN, string mN, string lN)
        {
            firstName = fN;
            middleName = mN;
            lastName = lN;            
        }
    }
}
