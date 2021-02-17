using System;

using ShoppingSpree.Common;

namespace ShoppingSpree.Models
{
    public class Product
    {
        private string name;
        private decimal cost;

        public Product(string name, decimal cost)
        {
            this.Name = name;
            this.Cost = cost;
        }

        public string Name 
        { 
            get => name;
            set 
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(GlobalConstatnts.EmptyNameExcMsg);
                }
                name = value;
            }
        }

        public decimal Cost 
        { 
            get => cost;

            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException(GlobalConstatnts.NegativeValueMsg);

                }

                cost = value;
            }
        }
    }
}
