using System;

namespace PizzaCalories.Models
{
    public class Dough
    {
        private const int defaultCaloriesPerGram = 2;
        private string type;
        private string technique;
        private int weight;

        internal Dough(string flourType, string bakingTechnique, int weight)
        {
            Type = flourType;
            Technique = bakingTechnique;
            Weight = weight;
        }

        private string Type 
        { 
            get => type;

            set 
            {
                if (!isCorrectType(value))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                type = value;
            }
        }
        private string Technique 
        {
            get => technique;

            set
            {
                if (!isCorrectTechnique(value))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                technique = value;
            }
        }
        public int Weight 
        {
            get => weight;

            set
            {
                if (value < 0 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range[1..200].");
                }

                weight = value;
            }
        }

        public double CaloriesPerGram => defaultCaloriesPerGram * Modifier(Type) * Modifier(Technique);

        private bool isCorrectType(string type) 
        {
            switch (type.ToLower())
            {
                case "white":
                case "wholegrain":
                    return true;
                default:
                    return false;
                    
            }
        }

        private bool isCorrectTechnique(string type)
        {
            switch (type.ToLower())
            {
                case "crispy":
                case "chewy":
                case "homemade":
                    return true;
                default:
                    return false;

            }
        }

        private double Modifier(string type) 
        {
            switch (type.ToLower())
            {
                case "white":
                return 1.5;
                case "crispy":
                    return 0.9;
                case "chewy":
                    return 1.1;
                default:
                    return 1.0;
            }
        }
    }
}
