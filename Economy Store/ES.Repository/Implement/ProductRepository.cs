using ES.Core.Model;
using ES.Core.ShareModel;

namespace ES.Repository.Interface
{
    public class ProductService : IProductRepository
    {
        public PagedResult<ProductModel> GetAll(SearchWithPaging param)
        {
            throw new System.NotImplementedException();
        }
    }
}
