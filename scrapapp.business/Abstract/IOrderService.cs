using System.Collections.Generic;
using scrapapp.entity;

namespace scrapapp.business.Abstract
{
    public interface IOrderService
    {
        void Create(Order entity);
        List<Order> GetOrders(string userId);
    }
}