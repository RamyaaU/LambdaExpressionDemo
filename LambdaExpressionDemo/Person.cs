using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace LambdaExpressionDemo
{
    public class Person
    {
        public string SSN;
        public string Name;
        public string Address;
        public int Age;
        public Person(string ssn, string name, string address, int age)
        {
            this.SSN = ssn;
            this.Name = name;
            this.Address = address;
            this.Age = age;
        }
    }
}
