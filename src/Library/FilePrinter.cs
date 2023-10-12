using System.IO;

namespace Full_GRASP_And_SOLID
{
    public class FilePrinter : Printer
    {
        public static new void PrintRecipe(Recipe recipe)
        {
            File.WriteAllText("Recipe.txt", recipe.GetTextToPrint());
        }
    }
}