using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Code_First_with_Repository_Pattern.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public ICollection<Product> Peoducts { get; set; }
    }
}