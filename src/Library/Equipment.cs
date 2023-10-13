//-------------------------------------------------------------------------------
// <copyright file="Equipment.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;

namespace Full_GRASP_And_SOLID
{
    public class Equipment
    {
        public static List<Equipment> equipmentCatalog = new List<Equipment>();

        public string Description { get; set; }

        public double HourlyCost { get; set; }

        public Equipment(string description, double hourlyCost)
        {
            this.Description = description;
            this.HourlyCost = hourlyCost;
        }

        private static List<Equipment> AddEquipmentToCatalog(string description, double hourlyCost)
        {
            AddEquipmentToCatalog("Cafetera", 1000);
            AddEquipmentToCatalog("Hervidor", 2000);
            equipmentCatalog.Add(new Equipment(description, hourlyCost));
            return equipmentCatalog;
        }
    }
    
}