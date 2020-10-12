using System.Collections.Generic;

namespace NorthWindApp.DBLayer
{
    public interface INorthWindRepository
    {
        List<Employee> GetEmployees();
        Employee GetEmployee(int id);
        List<Category> GetCategories();
        List<Order> GetOrders();
        Order GetOrder(int orderID);
    }
}