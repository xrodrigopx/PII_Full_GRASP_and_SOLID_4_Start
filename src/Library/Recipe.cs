//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Full_GRASP_And_SOLID
{
    public class Recipe
    {
        private IList<Step> steps = new List<Step>();


        public void AddStep(Step step)
        {
            recipe.AddStep(new Step(GetProduct("Café"), 100, GetEquipment("Cafetera"), 120));
            recipe.AddStep(new Step(GetProduct("Leche"), 200, GetEquipment("Hervidor"), 60));
        }

        private Equipment GetEquipment(string v)
        {
            throw new NotImplementedException();
        }

        private Product GetProduct(string v)
        {
            throw new NotImplementedException();
        }

        public void RemoveStep(Step step)
        {
            this.steps.Remove(step);
        }

        // Agregado por SRP
        public string GetTextToPrint()
        {
            FinalProduct finalProduct = new FinalProduct("Café con leche", 0);
            string result = $"Receta de {finalProduct.Description}:\n";
            foreach (Step step in this.steps)
            {
                result = result + step.GetTextToPrint() + "\n";
            }

            // Agregado por Expert
            result = result + $"Costo de producción: {this.GetProductionCost()}";

            return result;
        }

        // Agregado por Expert
        public double GetProductionCost()
        {
            double result = 0;

            foreach (Step step in this.steps)
            {
                result = result + step.GetStepCost();
            }

            return result;
        }

        Recipe recipe = new Recipe();

        private class FinalProduct : Product
        {
            public FinalProduct(string description, double unitCost)
                : base(description, unitCost)
            {
                this.Description = description;
            }

            
        }
    }
}