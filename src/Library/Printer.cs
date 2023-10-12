
namespace Full_GRASP_And_SOLID
{
    //clase Printer para instanciar impresora por consola o por archivo de texto
    public class Printer
    {
        public void PrintRecipe(Recipe recipe)
        {
            System.Console.WriteLine(recipe.GetTextToPrint());
        }
    }
}