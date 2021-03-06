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
        public double TimeToProduce { get; set; }
        public int TotalCreated { get; set; } // The number of this type of item that are created when it is crafted.
        public List<Ingredient> Ingredients { get; set; }
        public Factory Producer { get; set; }
        public string ImageString { get; set; }

        public Product (string name, double timeToProduce, int totalCreated, Factory producer)
        {
            Name = name;
            TimeToProduce = timeToProduce;
            TotalCreated = totalCreated;
            Producer = producer;
            Ingredients = new List<Ingredient>();
        }

        public Product(string name)
        {
            Name = name;
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
    /// An object to track data needed to built a visual representation of what to build.
    /// </summary>
    class GraphicalNeed
    {
        public Product Product { get; set; }
        public double BeltLoad { get; set; }
        public int RoundedFacs { get; set; }
        public List<GraphicalNeed> ChildNeeds { get; set; }
        public GraphicalNeed Parent { get; set; }
        public int Copies { get; set; }

        public GraphicalNeed(Product product)
        {
            ChildNeeds = new List<GraphicalNeed>();
            Copies = 1;
            BeltLoad = 0;
            Product = product;
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
        public string ImageString { get; set; }
        public bool MainList { get; }

        public Factory(string name, bool usesBelt, double craftSpeed, bool mainList)
        {
            Name = name;
            UsesBelt = usesBelt;
            CraftSpeed = craftSpeed;
            MainList = mainList;
        }
    }

    /// <summary>
    /// Object to track the stats we generate.
    /// So, those stats can be sorted before they are displayed.
    /// </summary>
    class IngredientStats
    {
        public Product Ingredient { get; }
        public double ExactFactories { get; }
        public int RoundedFactories { get; }
        public double BeltLoad { get; set; }
        public string ParentName { get; }

        public IngredientStats(Product ingredient, double exactFactories, string parentName)
        {
            Ingredient = ingredient;
            ExactFactories = exactFactories;
            ParentName = parentName;

            RoundedFactories = (int)Math.Ceiling(exactFactories);
        }
    }

    /// <summary>
    /// Object to track the total oil refinery needs.
    /// </summary>
    class OilNeeds
    {
        public double LightOilNeeded { get; set; }
        public double HeavyOilNeeded { get; set; }
        public double PetroleumGasNeeded { get; set; }
        public double SolidFuelIngredientsNeeded { get; set; }

        public OilNeeds()
        {
            LightOilNeeded = 0;
            HeavyOilNeeded = 0;
            PetroleumGasNeeded = 0;
            SolidFuelIngredientsNeeded = 0;
        }
    }

    /// <summary>
    /// Object to track the total mining needs.
    /// </summary>
    class MiningNeeds
    {
        public double IronOre { get; set; }
        public double CopperOre { get; set; }
        public double Stone { get; set; }
        public double Coal { get; set; }

        public MiningNeeds()
        {
            IronOre = 0;
            CopperOre = 0;
            Stone = 0;
            Coal = 0;
        }
    }


}
