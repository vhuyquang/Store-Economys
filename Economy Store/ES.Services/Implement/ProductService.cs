using ES.Core.Model;
using ES.Core.ShareModel;
using ES.Repository.Interface;

namespace ES.Services.Interface
{
    public class ProductService : IProductService
    {
        private IProductRepository _productRepository;
        public ProductService (IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public PagedResult<ProductModel> GetAll(SearchWithPaging param)
        {
            PagedResult<ProductModel> Product = _productRepository.GetAll(param);
            return Product;
        }
    }
}
