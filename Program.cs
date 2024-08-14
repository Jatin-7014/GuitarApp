using GuitarApp.Models;

namespace GuitarApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            GuitarSpecification spec1 = new GuitarSpecification(101, Builder.Gibson, "Model1", GuitarType.Electric, Wood.Maple, Wood.Alder);
            GuitarSpecification spec2 = new GuitarSpecification(102, Builder.Fender, "Model2", GuitarType.Acoustic, Wood.Sitka, Wood.Mahoganyt);

            inventory.AddGuitar("101", 10000, spec1);
            inventory.AddGuitar("102", 15000, spec1);
            inventory.AddGuitar("103", 25000, spec2);


            Guitar guitar2 = inventory.GetGuitar("101");
            Console.WriteLine(guitar2);
            Console.WriteLine();


            GuitarSpecification guitarsearch = new GuitarSpecification(101, Builder.Gibson, "Model1", GuitarType.Electric, Wood.Maple, Wood.Alder);

            List<Guitar> foundGuitars = inventory.SearchGuitar(guitarsearch);
            PrintAvailableGuitars(foundGuitars);

        }

        static void PrintAvailableGuitars(List<Guitar> list)
        {
            if (list != null && list.Count > 0)
            {
                Console.WriteLine("Found the following guitars:");
                foreach (Guitar guitar in list)
                {
                    Console.WriteLine(guitar);
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("No guitars found matching the criteria.");
            }
        }
    }
}
