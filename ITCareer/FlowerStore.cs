using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegularExam
{
    internal class FlowerStore
    {
        private string name;
        private List<Flower> listOfFlowers;
        public FlowerStore(string name)
        {
            this.listOfFlowers = new List<Flower>();
            this.Name = name;
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length < 6)
                {
                    throw new ArgumentException("Invalid flower store name!");
                }
                name = value;
            }
        }
        public IReadOnlyCollection<Flower> ListOfFlowers
        {
            get { return this.listOfFlowers.AsReadOnly(); }
        }
        //AddFlower method
        public void AddFlower(Flower flower)
        {
            this.listOfFlowers.Add(flower);
        }
        public bool SellFlower(Flower flower)
        {
            bool flag = false;
            for (int i = 0; i < this.ListOfFlowers.Count; i++)
            {
                if (this.listOfFlowers[i].Type == flower.Type)
                {
                    listOfFlowers.RemoveAt(i);
                    flag = true;
                    break;
                }
            }
            return flag;
        }
        public double CalculateTotalPrice()
        {
            double totalPrice = 0.0;
            for (int i = 0; i < this.listOfFlowers.Count; i++)
            {
                totalPrice += this.listOfFlowers[i].Price;
            }
            return totalPrice;
        }
        public override string ToString()
        {
            string result = "";
            if (this.ListOfFlowers.Count > 0)
            {
                result = $"Flower store {this.Name} has {this.ListOfFlowers.Count} flower/s:";

                foreach (var item in this.ListOfFlowers)
                {
                    //result += $"\nFlower {item.Type} with color {item.Color} costs {item.Price}";
                    result = result + "\n" + item.ToString();
                }
            }
            else
            {
                result = $"Flower store {this.Name} has no available flowers.";
            }
            return result;
        }
        public void RenameFlowerStore(string newName)
        {
            this.Name = newName;
        }
        public void SellAllFlowers()
        {
            listOfFlowers.Clear();
        }
        public Flower GetFlowerWithHighestPrice()
        {
            Flower flowerWithHighestPrice = null;
            double highestPrice = 0;

            foreach (Flower flower in ListOfFlowers)
            {
                if (flower.Price > highestPrice)
                {
                    highestPrice = flower.Price;
                    flowerWithHighestPrice = flower;
                }
            }

            return flowerWithHighestPrice;
        }

        public Flower GetFlowerWithLowestPrice()
        {
            Flower flowerWithLowestPrice = null;
            double lowestPrice = double.MaxValue;

            foreach (Flower flower in ListOfFlowers)
            {
                if (flower.Price < lowestPrice)
                {
                    lowestPrice = flower.Price;
                    flowerWithLowestPrice = flower;
                }
            }

            return flowerWithLowestPrice;
        }
    }
}
