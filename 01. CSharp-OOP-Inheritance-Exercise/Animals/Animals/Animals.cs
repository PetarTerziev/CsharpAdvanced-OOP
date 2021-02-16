using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Animal
    {
        private string name;
        private int age;
        private string gender;
        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }
        public string Name
        {
            get => name;

            private set 
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    name = value;
                }
                else
                {
                    throw new ArgumentException("Invalid input!");
                }
            
            }
        }
        public int Age 
        { 
            get => age;

            private set 
            {
                if (value > 0)
                {
                    age = value;
                }
                else
                {
                    throw new ArgumentException("Invalid input!");
                }
            } 
        
        }
        public string Gender 
        { 
            get => gender;

            private set 
            {
                if (value == "Male" || value == "Female")
                {
                    gender = value;
                }
                else
                {
                    throw new ArgumentException("Invalid input!");
                }
            
            } 
        }

        public virtual string ProduceSound() 
        {
            return "";
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{GetType().Name}");
            sb.AppendLine($"{Name} {Age} {Gender}");
            sb.AppendLine($"{ProduceSound()}");
            return sb.ToString().TrimEnd();
        }
    }
}
