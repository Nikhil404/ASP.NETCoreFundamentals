using ASP.NETCoreFundamentals.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ASP.NETCoreFundamentals.Data
{
    public interface IResturantData
    {
        IEnumerable<Resturant> GetAll();
    }

    public class InMemoryRestaurantData : IResturantData
    {
        List<Resturant> resturants;
        public InMemoryRestaurantData()
        {
            resturants = new List<Resturant>()
            {
                new Resturant{ Id = 1 , Name = "Dominos", Location = "Madhapur" , Cuisine = CuisineType.Italian },
                new Resturant{Id =2 , Name = "Burger King" , Location = "Hitech city" , Cuisine = CuisineType.Indian},
                new Resturant{Id =3 , Name = "McDonolds" , Location = "Kukatpally" , Cuisine = CuisineType.Mexican},
                new Resturant{Id =4 , Name = "Something" , Location = "Someware" , Cuisine = CuisineType.None}
            };
        }
        public IEnumerable<Resturant> GetAll()
        {
            return from r in resturants
                   orderby r.Name
                   select r;
        }
    }
}
