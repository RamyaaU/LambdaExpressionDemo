﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExpressionDemo
{
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            //declaring list 
            List<Person> listPersonInCity = new List<Person>();
            AddPersonInfo(listPersonInCity);
            Retrieving_TopTwoRecord_Where_AgeLessThanSixty(listPersonInCity);
            Checking_TeenAge_Person(listPersonInCity);
        }
        /// <summary>
        /// Adds the person information to list
        /// </summary>
        /// <param name="listPersonInCity">The list person in city.</param>
        public static void AddPersonInfo(List<Person> listPersonInCity)
        {
            listPersonInCity.Add(new Person("123", "Alexis", "Schitts Creek", 21));
            listPersonInCity.Add(new Person("456", "David", "Schitts Creek", 65));
            listPersonInCity.Add(new Person("956", "Patrick", "Schitts Creek", 23));
            listPersonInCity.Add(new Person("789", "Ted", "Schitts Creek", 70));
            listPersonInCity.Add(new Person("760", "Johnny", "Schitts Creek", 55));
            listPersonInCity.Add(new Person("729", "Roland", "Schitts Creek", 95));
            listPersonInCity.Add(new Person("729", "Moira", "Schitts Creek", 16));
        }
        /// <summary>
        /// Retrievings the top two record where age of person less than sixty.
        /// </summary>
        /// <param name="listPersonInCity">The list person in city.</param>
        public static void Retrieving_TopTwoRecord_Where_AgeLessThanSixty(List<Person> listPersonInCity)
        {
            foreach (Person person in listPersonInCity.FindAll(e => (e.Age < 60)).Take(2).ToList())
            {
                Console.WriteLine("Name: " + person.Name + " Age: " + person.Age);
            }
        }
        /// <summary>
        /// Checkings the teenage person in the list 
        /// </summary>
        /// <param name="listPersonInCity">The list person in city.</param>
        public static void Checking_TeenAge_Person(List<Person> listPersonInCity)
        {

            if (listPersonInCity.Any(e => e.Age >= 13 && e.Age <= 19))
            {
                Console.WriteLine("A Teenager found");
            }
            else
            {
                Console.WriteLine("No teenager found");
            }
        }
    }
}