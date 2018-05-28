﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorioSolver
{
    /// <summary>
    /// Data about an item that can be crafted.
    /// </summary>
    class Product
    {
        public string Name { get; }
        public double TimeToProduce { get; }
        public int TotalCreated { get; } // The number of this type of item that are created when it is crafted.
        public List<Ingredient> Ingredients { get; set; }
        public Factory Producer { get; }

        public Product (string name, double timeToProduce, int totalCreated, Factory producer)
        {
            Name = name;
            TimeToProduce = timeToProduce;
            TotalCreated = totalCreated;
            Producer = producer;
            Ingredients = new List<Ingredient>();
        }

    }

    /// <summary>
    /// Item to track an ingredient of crafting.
    /// </summary>
    class Ingredient
    {
        public Product Product { get; }
        public int Amount { get; }

        public Ingredient(Product product, int amount)
        {
            Product = product;
            Amount = amount;
        }
    }

    /// <summary>
    /// Used to track the building that is used to craft a product.
    /// </summary>
    class Factory
    {
        public string Name { get; }
        public bool UsesBelt { get; }
        public double CraftSpeed { get; }

        public Factory(string name, bool usesBelt, double craftSpeed)
        {
            Name = name;
            UsesBelt = usesBelt;
            CraftSpeed = craftSpeed;
        }
    }
}
