using System;
using System.Collections.Generic;
using System.Text;

namespace ASP.NETCoreFundamentals.Core
{
    public class Resturant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public CuisineType Cuisine { get; set; }

    }
}
