using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Person
    {
        int id;
        string firstName;
        string lastName;
        string adress;
        int age;
        string gender;

        public Person()     //Konstruktor nr 1
        {
            id = 1;
            firstName = "Imię";
            lastName = "Nazwisko";
            age = 14;
        }

        public Person(int id, string firstname, string lastname, string address, int age, string gender)        //Konstruktor nr 2
        {
            this.id = id;
            this.firstName = firstname;
            this.lastName = lastname;
            this.adress = address;
            this.age = age;
            this.gender = gender;
        }

        public Person(int id, string firstname, string lastname)        //Konstruktor nr 3
        {
            this.id = id;
            this.firstName = firstname;
            this.lastName = lastname;
        }

        public Person(int id, string firstname)         //Konstruktor nr 4
        {
            this.id = id;
            this.firstName = firstname;
        }

    }
}
