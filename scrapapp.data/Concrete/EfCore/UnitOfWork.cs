using scrapapp.data.Abstract;

namespace scrapapp.data.Concrete.EfCore
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ShopContext _context;
        private EfCoreCartRepository _cartRepository;
        private EfCoreOrderRepository _orderRepository;
        private EfCoreProductRepository _productRepository;
        public UnitOfWork(ShopContext context)
        {
            _context = context;
        }
        public ICartRepository Carts => _cartRepository = _cartRepository ?? new EfCoreCartRepository(_context);
        public IOrderRepository Orders => _orderRepository = _orderRepository ?? new EfCoreOrderRepository(_context);
        public IProductRepository Products => _productRepository = _productRepository ?? new EfCoreProductRepository(_context);
        public void Dispose()
        {
            _context.Dispose();
        }
        public void Save()
        {
            _context.SaveChanges();
        }
        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}