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
        protected List<string> firstNameList = new List<string> { "Gary", "John", "Dean", "Wayne", "Juan", "Fritz", "Ronald", "Mikhail", "Earle", "Patrick", "William", "Larry", "Paul", "Randall", "Jeffrey", "Randy", "Robert", "Charles", "Robert" };
        protected List<string> middleNameList = new List<string> { "Wayne", "Vallejo", "John", "Steven", "Lee", "Ray", "Joseph", "", "", "", "", "", "", "" };
        protected List<string> lastNameList = new List<string> { "Ridgway", "Gacy", "Corll", "Williams", "Corona", "Haarmann", "Dominique", "Popkov", "Nelson", "Kearney", "Bohnin", "Eyler", "Knowles", "Woodfield", "Dahmer", "Kraft", "Yates", "Hatcher", "Hansen" };
        protected List<string> nationalityList = new List<string> { "Denmark", "Canada", "Sweden", "USA", "Russia", "China", "Norway", "Germany", "Great Britain", "France", "Spain", "Italy", "Ukraine", "Romania", "Hungary", "Korea", "Egypt", "Saudi Arabia", "Mexico", "Brazil", "Argentina", "Chile", "Colombia", "Somalia", "Netherlands", "Poland", "Finland", "Greenland", "Japan", "South Africa" };

        protected List<string> genderList = new List<string> {/*"Female",*/"Male" };

        protected List<DateTime> dateOfBirthList = new List<DateTime> { new DateTime(1977, 1, 2), new DateTime(1945, 1, 2), new DateTime(1946, 2, 3), new DateTime(1985, 5, 2), new DateTime(1955, 4, 7), new DateTime(1999, 1, 1), new DateTime(1988, 5, 8), new DateTime(1978, 3, 9), new DateTime(1965, 12, 12), new DateTime(1969, 11, 11), new DateTime(1981, 5, 10), new DateTime(1973, 6, 9) };


        protected string fullName;
        private Random random = new Random(Guid.NewGuid().GetHashCode());
        public Person()
        {

        }
        public Person(string gender)
        {
            

            if (gender == "Male")
            {
                firstName = firstNameList[random.Next(0, firstNameList.Count)];
                middleName = middleNameList[random.Next(0, middleNameList.Count)];
                lastName = lastNameList[random.Next(0, lastNameList.Count)];
                nationality = nationalityList[random.Next(0, nationalityList.Count)];
                this.gender = gender;//genderList[random.Next(0, genderList.Count)];
                dateOfBirth = dateOfBirthList[random.Next(0, dateOfBirthList.Count)];
            }
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
