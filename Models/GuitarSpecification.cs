using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarApp.Models
{
    internal class GuitarSpecification
    {
        public Builder Builder { get; set; }
        public string Model { get; set; }
        public GuitarType Type { get; set; }
        public Wood BackWood { get; set; }
        public Wood TopWood { get; set; }
        public int NumStrings { get; set; }
        public GuitarSpecification(int numString, Builder builder, string model, GuitarType type, Wood backwood, Wood topwood)
        {
            NumStrings = numString;
            Builder = builder;
            Model = model;
            Type = type;
            BackWood = backwood;
            TopWood = topwood;
        }

        public bool IsMatching(GuitarSpecification specs)
        {
            if ((specs.NumStrings == NumStrings) &&
                   (specs.Model.ToLower() == Model.ToLower()) &&
                   (specs.TopWood == TopWood) &&
                   (specs.BackWood == BackWood) &&
                   (specs.Type == Type))
            {
                return true;
            }
            return false;
        }
    }
}
