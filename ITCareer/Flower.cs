﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegularExam
{
    internal class Flower
    {
        private string type;
        private string color;
        private double price;
        public Flower(string type, string color, double price)
        {
            Type = type;
            Color = color;
            Price = price;
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public double Price
        {
            get { return price; }
            set
            {
                if (value > 100)
                {
                    throw new ArgumentException("Invalid flower price!");
                }
                price = value;
            }
        }

        public override string ToString()
        {
            return $"Flower {Type} with color {Color} costs {Price:f2}";
        }
    }
}
