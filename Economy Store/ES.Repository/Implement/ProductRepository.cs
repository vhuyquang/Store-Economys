using ES.Core.Model;
using ES.Core.ShareModel;

namespace ES.Repository.Interface
{
    public class ProductRepository : IProductRepository
    {
        public PagedResult<ProductModel> GetAll(SearchWithPaging param)
        {
            PagedResult<ProductModel> product = new PagedResult<ProductModel>();
            return product;
        }
    }
}
