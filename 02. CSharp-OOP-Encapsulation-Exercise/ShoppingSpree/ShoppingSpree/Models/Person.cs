using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ShoppingSpree.Common;

namespace ShoppingSpree.Models
{
    public class Person
    {
        private string name;
        private decimal money;
        private List<Product> products;

        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            products = new List<Product>();
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

        public decimal Money
        {
            get => money;
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException(GlobalConstatnts.NegativeValueMsg);

                }
                money = value;
            }
        }

        public bool CanBuyProduct(Product product) 
        {
            if (product.Cost <= money)
            {
                products.Add(product);
                money -= product.Cost;
                return true;
            }

            return false;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (products.Count == 0)
            {
                sb.Append($"{Name} - Nothing bought ");
            }
            else
            {
                sb.Append($"{Name} - ");
                sb.Append($"{string.Join(", ", products.Select(p => p.Name).ToArray())}");
            }
                
            return sb.ToString().TrimEnd(); 
        }

    }
}
