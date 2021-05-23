using ES.Core.Model;
using ES.Core.ShareModel;

namespace ES.Repository.Interface
{
    public interface IProductRepository
    {
        PagedResult<ProductModel> GetAll(SearchWithPaging param);
    }
}
