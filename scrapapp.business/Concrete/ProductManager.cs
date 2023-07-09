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

        public bool Create(Product entity)
        {
            if (Validation(entity))
            {
                _unitofwork.Products.Create(entity);
                _unitofwork.Save();
                return true;
            }
            return false;
        }
        public async Task<Product> CreateAsync(Product entity)
        {
            await _unitofwork.Products.CreateAsync(entity);
            await _unitofwork.SaveAsync();
            return entity;
        }
        public void Delete(Product entity)
        {
            // iş kuralları
            _unitofwork.Products.Delete(entity);
            _unitofwork.Save();
        }
        public async Task<List<Product>> GetAll()
        {
            return await _unitofwork.Products.GetAll();
        }

        public async Task<List<Product>> GetAllProducts()
        {
            return await _unitofwork.Products.GetAllProducts();
        }
        public async Task<Product> GetBySlug(string slug)
        {
            return await _unitofwork.Products.GetBySlug(slug);
        }
        public Product GetBySlugWithCategories(string slug)
        {
            return _unitofwork.Products.GetBySlugWithCategories(slug);
        }
        public int GetCountByCategory(string category)
        {
            return _unitofwork.Products.GetCountByCategory(category);
        }
        public Product GetProductDetails(string url)
        {
            return _unitofwork.Products.GetProductDetails(url);
        }
        public List<Product> GetProductsByCategory(string name, int page, int pageSize)
        {
            return _unitofwork.Products.GetProductsByCategory(name, page, pageSize);
        }
        public List<Product> GetSearchResult(string searchString)
        {
            return _unitofwork.Products.GetSearchResult(searchString);
        }
        public void Update(Product entity)
        {
            _unitofwork.Products.Update(entity);
            _unitofwork.Save();
        }
        public bool Update(Product entity, int[] categoryIds)
        {
            if (Validation(entity))
            {
                if (categoryIds.Length == 0)
                {
                    ErrorMessage += "Ürün için en az bir kategori seçmelisiniz.";
                    return false;
                }
                _unitofwork.Products.Update(entity, categoryIds);
                _unitofwork.Save();
                return true;
            }
            return false;
        }
        public bool Validation(Product entity)
        {
            var isValid = true;
            if (string.IsNullOrEmpty(entity.Detail.Name))
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
        public async Task UpdateAsync(Product entityToUpdate, Product entity)
        {
            entityToUpdate.Detail.Name = entity.Detail.Name;
            entityToUpdate.Price = entity.Price;
            await _unitofwork.SaveAsync();
        }
        public async Task DeleteAsync(Product entity)
        {
            _unitofwork.Products.Delete(entity);
            await _unitofwork.SaveAsync();
        }
    }
}