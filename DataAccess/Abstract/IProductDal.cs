using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    //veritabanında product tablosunda yapılacak işlemler
    public interface IProductDal:IEntityRepository<Product>
    {
        
    
    }
}
