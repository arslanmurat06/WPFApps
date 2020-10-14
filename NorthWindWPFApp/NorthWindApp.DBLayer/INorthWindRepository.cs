using System.Collections.Generic;

namespace NorthWindApp.DBLayer
{
    public interface INorthWindRepository
    {
        List<Employee> GetEmployees();
        Employee GetEmployee(int id);
        List<Category> GetCategories();
        List<Order> GetOrders();
        List<Customer> GetCustomers();
        Order GetOrder(int orderID);
    }
}