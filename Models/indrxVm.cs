using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SouqStore.Models
{
    
    public class indrxVm
    {
        public indrxVm()
        {
            Categories = new List<Category>();
            products = new List<Product>();
            Reviews = new List<Review>();
            LatestProduct = new List<Product>();

        }
        public List<Category> Categories { get; set; }
        public List<Product> products { get; set; }
        public List<Review> Reviews { get; set; }
        public List<Product> LatestProduct { get; set; }


    }
}
