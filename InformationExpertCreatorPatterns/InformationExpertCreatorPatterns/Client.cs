using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationExpertCreatorPatterns
{
    public class Client
    {
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual int Age { get; set; }
        
        public Client(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
        public Client()
        {
            FirstName = "Ivan";
            LastName = "Ivanov";
            Age = 18;
        }

        public virtual string GetData()
        {
            return string.Format("Client data: \n" +
                                 "-FirstName: {0}\n" +
                                 "-LastName: {1}\n" +
                                 "-Age: {2}\n", FirstName, LastName, Age);
        }

    }
}
