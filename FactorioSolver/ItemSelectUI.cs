﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactorioSolver
{
    public partial class ItemSelectUI : Form
    {
        private AllProducts products;

        public ItemSelectUI()
        {


            InitializeComponent();
        }

        private void ItemSelectUI_Load(object sender, EventArgs e)
        {
            products = new AllProducts();
            products.CreateDefaultProducts();


            foreach (Product product in products.Products)
            {   
                
            }
        }
    }
}
