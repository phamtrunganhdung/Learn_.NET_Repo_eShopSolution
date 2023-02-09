using eShopSolution.ApplicationService.Catalog.Products.Dots;
using eShopSolution.ApplicationService.Dots;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.ApplicationService.Catalog.Products
{
    public interface IPublicProductService
    {

        public PagedResult<ProductViewModel> GetAllByCategoryId(int categoryId, int pageIndex, int pageSize);
    }
}
