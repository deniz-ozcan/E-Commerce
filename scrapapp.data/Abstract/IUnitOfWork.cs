namespace scrapapp.data.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        ICartRepository Carts { get; }
        IOrderRepository Orders { get; }
        IProductRepository Products { get; }
        void Save();
        Task<int> SaveAsync();
    }
}