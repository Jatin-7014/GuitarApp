using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarApp.Models
{
    internal class Inventory
    {
        private List<Guitar> Guitars { get; set; }

        public Inventory()
        {
            Guitars= new List<Guitar>();
        }
        public void AddGuitar(string serialNo,double price,GuitarSpecification specs)
        {
            Guitar guitar = new Guitar(serialNo,price,specs);
            Guitars.Add(guitar);
        }

        public Guitar GetGuitar(string serialNo)
        {
            foreach(var guitar in Guitars)
            {
                if(guitar.SerialNumber == serialNo)
                    return guitar;
            }
            return null;
        }
        public List<Guitar> SearchGuitar(GuitarSpecification searchGuitar)
        {
            List<Guitar> searchGuitars = new List<Guitar>();
            foreach (Guitar guitar in Guitars)
            {
                if ((guitar != null) && guitar.Specifications.IsMatching(searchGuitar))
                {
                    searchGuitars.Add(guitar);
                }
            }
            if (searchGuitars.Count > 0)
                return searchGuitars;
            return null;
        }

    }
}
