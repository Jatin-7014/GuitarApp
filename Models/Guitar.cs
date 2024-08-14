using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarApp.Models
{
    internal class Guitar
    {
        public string SerialNumber {  get; set; }
        public double Price { get; set; }
        public GuitarSpecification Specifications { get; set; }
        public Guitar(string id, double price, GuitarSpecification specs)
        {
            SerialNumber = id;
            Price = price;
            Specifications = specs;
        }
        public override string ToString()
        {
            return $"Serial Number: {SerialNumber} \n" +
                $"Price: {Price} \n" +
                $"Number Strings: {Specifications.NumStrings}\n" +
                $"Builder: {Specifications.Builder} \n" +
                $"Model: {Specifications.Model} \n" +
                $"Type: {Specifications.Type} \n" +
                $"Backwood: {Specifications.BackWood} \n" +
                $"Topwood: {Specifications.TopWood}";
        }

    }
}
