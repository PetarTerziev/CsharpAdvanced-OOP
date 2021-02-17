using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaCalories.Models
{
    public class Pizza
    {
        private string name;
        private Dough dough;
        private List<Topping> toppings;

        public Pizza(string name)
        {
            Name = name;
        }
        public Pizza(string name, Dough dough)
        {
            Name = name;
            Dough = dough;
            Toppings = new List<Topping>();
        }

        public string Name 
        { 
            get => name;
            set 
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }

                name = value;
            }
        }

        private Dough Dough {  get => dough; set => dough = value; }

        public int CountToppings => Toppings.Count;

        public string TotalCalories => $"{CalculateTotalCalories():f2}";
        private List<Topping> Toppings { get => toppings; set => toppings = value; }

        public void AddTopping(Topping topping) 
        {
            if (Toppings.Count >= 10)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }
            else
            {
                Toppings.Add(topping);
            }
        
        }

        private double CalculateTotalCalories() 
        {
            double doughCalories = dough.Weight * dough.CaloriesPerGram;
            double toppingsCalories = Toppings.Sum(t => t.Weight * t.CaloriesPerGram);
            return doughCalories + toppingsCalories;
        }

        public override string ToString()
        {
            return $"{Name} - {TotalCalories} Calories.";
        }
    }
}
