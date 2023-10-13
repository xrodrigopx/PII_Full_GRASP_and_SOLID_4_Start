//--------------------------------------------------------------------------------------
// <copyright file="Product.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//---------------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;

namespace Full_GRASP_And_SOLID
{
    public class Product
    {
        public static List<Product> productCatalog = new List<Product>();
        public string Description { get; set; }

        public double UnitCost { get; set; }

        public Product(string description, double unitCost)
        {
            this.Description = description;
            this.UnitCost = unitCost;
        }


        private static List<Product> AddProductToCatalog(string description, double unitCost)
        {
            AddProductToCatalog("Café", 100);
            AddProductToCatalog("Leche", 200);
            AddProductToCatalog("Café con leche", 300);
            productCatalog.Add(new Product(description, unitCost));
            return productCatalog;
        }

    }
}