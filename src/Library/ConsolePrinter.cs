using System;

namespace Full_GRASP_And_SOLID
{
    public class ConsolePrinter : Printer
    {
        public static new void PrintRecipe(Recipe recipe)
        {
            Console.WriteLine(recipe.GetTextToPrint());
        }
    }
}