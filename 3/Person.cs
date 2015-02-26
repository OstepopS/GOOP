using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Tennis
{
    class Person
    {
        protected string firstName;
        protected string middleName;
        protected string lastName;
        protected string nationality;
        protected string gender;
        protected DateTime dateOfBirth;
        protected List<string> firstNameList = new List<string> { "Henning", "Flemming", "Bo", "Ib", "John", "pind", "hest", "lars" };
        protected List<string> middleNameList = new List<string> { "Henning", "Flemming", "KimLarsen", "Hitler", "John", "BQsen", "Sral", "kurd" };
        protected List<string> lastNameList = new List<string> { "Johnson", "Berdiin", "Boris", "Bqqsen", "TheG", "Underskov", "Lund", "Otte" };
        protected List<string> nationalityList = new List<string> { "Denmark", "Canada", "Sweden", "Murrica" };
        protected List<string> genderList = new List<string> {/*"Female",*/"Male" };
        protected List<DateTime> dateOfBirthList = new List<DateTime> { new DateTime(1977, 1, 2), new DateTime(1945, 1, 2) };
        protected string fullName;
        private Random random = new Random(Guid.NewGuid().GetHashCode());

        public Person()
        {
            firstName = firstNameList[random.Next(0, firstNameList.Count)];
            middleName = middleNameList[random.Next(0, middleNameList.Count)];
            lastName = lastNameList[random.Next(0, lastNameList.Count)];
            nationality = nationalityList[random.Next(0, nationalityList.Count)];
            gender = genderList[random.Next(0, genderList.Count)];
            dateOfBirth = dateOfBirthList[random.Next(0, dateOfBirthList.Count)];
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
        public string Gender
        {
            get { return gender; }
        }
        public string FullName
        {
            get { return name(firstName, middleName, lastName); }
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
        public override string ToString()
        {
            return name(firstName, middleName, lastName) + "Date of Birth: " + dateOfBirth + "\n" + "Nationality: " + nationality + "\n" + "Gender: " + gender + "\n";
        }
    }
}
