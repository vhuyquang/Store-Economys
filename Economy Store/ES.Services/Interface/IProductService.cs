using ES.Core.Model;
using ES.Core.ShareModel;

namespace ES.Services.Interface
{
    public interface IProductService
    {
        PagedResult<ProductModel> GetAll(SearchWithPaging param);
    }
}
