using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfumery
{
    public class Perfumery
    {
        private string name;
        private List<Perfume> listOfPerfume;

        public Perfumery(string name)
        {
            this.listOfPerfume = new List<Perfume>();
            this.Name = name;
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length < 6)
                {
                    throw new ArgumentException("Invalid perfumery name!");
                }
                name = value;
            }
        }
        public IReadOnlyCollection<Perfume> ListOfPerfume
        {
            get { return this.listOfPerfume.AsReadOnly(); }
        }
        public void AddPerfume(Perfume perfume)
        {
            this.listOfPerfume.Add(perfume);
        }
        public List<Perfume> GetPerfumes()
        {
            return listOfPerfume;
        }
        public bool SellPerfume(Perfume perfume)
        {
            bool flag = false;
            for (int i = 0; i < this.ListOfPerfume.Count; i++)
            {
                if (this.listOfPerfume[i].Brand == perfume.Brand)
                {
                    listOfPerfume.RemoveAt(i);
                    flag = true;
                    break;
                }
            }
            //foreach (Perfume item in this.listOfPerfume)
            //{
            //    if (item.Brand.Equals(perfume.Brand))
            //    {
            //        listOfPerfume.Remove(item);
            //        flag = true;
            //        break;
            //    }
            //}
            return flag;
        }
        public double CalculateTotalPrice()
        {
            double totalPrice = 0.0;
            for (int i = 0; i < this.listOfPerfume.Count; i++)
            {
                totalPrice += this.listOfPerfume[i].Price;
            }
            return totalPrice;
        }
        public void RenamePerfumery(string newName)
        {
            this.Name = newName;
        }
        public void SellAllPerfumes()
        {
            listOfPerfume.Clear();
        }
        public Perfume GetPerfumeWithHighestPrice()
        {
            Perfume perfumeWithHighestPrice = null;
            double highestPrice = 0;

            foreach (Perfume perfume in ListOfPerfume)
            {
                if (perfume.Price > highestPrice)
                {
                    highestPrice = perfume.Price;
                    perfumeWithHighestPrice = perfume;
                }
            }

            return perfumeWithHighestPrice;
        }

        public Perfume GetPerfumeWithLowestPrice()
        {
            Perfume perfumeWithLowestPrice = null;
            double lowestPrice = double.MaxValue;

            foreach (Perfume perfume in ListOfPerfume)
            {
                if (perfume.Price < lowestPrice)
                {
                    lowestPrice = perfume.Price;
                    perfumeWithLowestPrice = perfume;
                }
            }

            return perfumeWithLowestPrice;
        }

        public override string ToString()
        {
            string result = "";
            if (this.ListOfPerfume.Count > 0)
            {
                result = $"Perfumery {this.Name} has {this.ListOfPerfume.Count} perfume/s:";

                foreach (var item in this.ListOfPerfume)
                {
                    result = result + "\n" + item.ToString();
                }
            }
            else
            {
                result = $"Perfumery {this.Name} has no available perfumes.";
            }
            return result;
        }
    }
}
