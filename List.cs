using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListAndList
{
    class Person
    {
        public int age;
        public string fname;
        public string lname;
        public string city;

        public Person()
        {

        }
        public Person(int _age, string _fname, string _lname, string _city)
        {
            age = _age;
            fname = _fname;
            lname = _lname;
            city = _city;
        }
        public void DisplayPerson()
        {
            Console.WriteLine("The age of the person:{0} the name of the person :{1}" +
                " the last name of the person :{2} and the city where the Person lives:{3}", age, fname, lname, city);
        }

    }
    class List
    {
        static void Main()
        {
            List<Person> person = new List<Person>(5);
            Person person1 = new Person(11, "shrinidhi", "nair", "bhopal");
            Person person2 = new Person(21, "satakshi", "dubey", "jabalpur");
            Person person3 = new Person(23, "shriya", "nair", "bhopal");
            Person person4 = new Person(45, "Vaibhavi", "singh", "bhopal");
            Person person5 = new Person(67, "shantha", "nair", "bhopal");

            person.Add(person1);
            person.Add(person2);
            person.Add(person3);
            person.Add(person4);
            person.Add(person5);

            foreach (Person p in person)
            {
                p.DisplayPerson();
            }
        }
    }

}