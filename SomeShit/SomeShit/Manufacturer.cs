using System;
using System.Collections.Generic;
using System.Text;

namespace SomeShit
{
    public class Manufacturer
    {
        public string Name { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
