using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public  class Shape
    {
        public string Name { get; set; }
        public Shape()
        {
                
        }
        public Shape(string name)
        {
            Name = name;
        }
        public string GetShapeName()
        {
            return Name;
        }
    }
}
