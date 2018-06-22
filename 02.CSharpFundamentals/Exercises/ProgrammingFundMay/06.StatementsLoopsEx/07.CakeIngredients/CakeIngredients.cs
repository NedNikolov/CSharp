using System;

namespace _07.CakeIngredients
{
    class CakeIngredients
    {
        static void Main(string[] args)
        {
            string ingredient = Console.ReadLine();
            int ingredientsNumber = 0;

            while (ingredient != "Bake!")
            {
                Console.WriteLine("Adding ingredient {0}.", ingredient);
                ingredient = Console.ReadLine();
                ingredientsNumber++;
            }
            Console.WriteLine("Preparing cake with {0} ingredients.", ingredientsNumber);

        }
    }
}
