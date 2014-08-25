using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.DAO
{
    interface ProductDao
    {
        IEnumerable<Product> findAllProducts();

        Product findProductById(long idToLookUp);
    }
}
