using scrapapp.business.Abstract;
using scrapapp.data.Abstract;
using scrapapp.entity;

namespace scrapapp.business.Concrete
{
    public class ProductManager : IProductService
    {
        public string ErrorMessage { get; set; }
        private readonly IUnitOfWork _unitofwork;
        public ProductManager(IUnitOfWork unitofwork) => _unitofwork = unitofwork;

        public async Task<Product> CreateAsync(Product entity)
        {
            await _unitofwork.Products.CreateAsync(entity);
            await _unitofwork.SaveAsync();
            return entity;
        }

        public async Task<List<Product>> GetAllProductsAsync()
        {
            return await _unitofwork.Products.GetAllProductsAsync();
        }
        public async Task<Product> GetByIdAsync(int id)
        {
            return await _unitofwork.Products.GetByIdAsync(id);
        }
        public async Task<int>  GetProductsCount(string q)
        {
            return await _unitofwork.Products.GetProductsCount(q);
        }
        public async Task<List<Product>>  GetProducts(string q, int page, int pageSize)
        {
            return await _unitofwork.Products.GetProducts(q, page, pageSize);
        }
        public async Task UpdateAsync(Product update, Product entity)
        {
            if (Validation(entity) && Validation(update))
            {
                update.Brand = entity.Brand;
                update.Price = entity.Price;
                await _unitofwork.SaveAsync();
            }
        }
        public async Task DeleteAsync(Product entity)
        {
            _unitofwork.Products.Delete(entity);
            await _unitofwork.SaveAsync();
        }
        public bool Validation(Product entity)
        {
            var isValid = true;
            if (string.IsNullOrEmpty(entity.Brand))
            {
                ErrorMessage += "ürün ismi girmelisiniz.\n";
                isValid = false;
            }
            if (entity.Price < 0)
            {
                ErrorMessage += "ürün fiyatı negatif olamaz.\n";
                isValid = false;
            }
            return isValid;
        }
    }
}