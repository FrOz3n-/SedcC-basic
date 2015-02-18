using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Human
    {
        public Human()
        {

        }

        public Human(string Name, String Surname)
        {
            FirstName = Name;
            LastName = Surname;
        }

        public Human(string Name, string MiddleName, String Surname)
        {
            FirstName = Name;
            LastName = Surname;
            this.MiddleName = MiddleName;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }

        public string WelcomeMessage(string message)
        {
            if(String.IsNullOrEmpty(MiddleName))
                return message + ", " + FirstName + " " + LastName;
            else
                return message + ", " + FirstName + " " + MiddleName + " " + LastName;
        }

        public string WelcomeMessage(string msg1, string msg2)
        {
            return msg1 + msg2;
        }

        public bool IsFullNameLongerThanMaxLength(int maxLength)
        {
            return maxLength < (FirstName + " " + LastName).Length;
        }
    }
}
