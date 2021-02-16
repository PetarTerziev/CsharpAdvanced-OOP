using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    public class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {Name}, Age: {Age}");

            return sb.ToString().Trim();
        }
    }
}
