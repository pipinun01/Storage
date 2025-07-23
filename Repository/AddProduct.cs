using Entity;
using RepositoryContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class AddProduct: IAddProduct
    {
        private readonly StorageContext storageContext;
        public AddProduct(StorageContext storageContext)
        {
            this.storageContext = storageContext;
        }
        public void Add(Product product)
        {
            storageContext.Add(product);
            storageContext.SaveChanges();
        }
    }
}
