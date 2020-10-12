using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWindApp.DBLayer
{
    public class NorthWindRepository:INorthWindRepository
    {
        public List<Employee> GetEmployees()
        {
            using (NorthWindModel context = new NorthWindModel())
            {
                return context.Employees.ToList();
            }
        }

        public Employee GetEmployee(int id)
        {
            using (NorthWindModel context = new NorthWindModel())
            {
                return context.Employees.Where(emp => emp.EmployeeID == id).FirstOrDefault();
            }
        }

        public List<Category> GetCategories()
        {
            using (NorthWindModel context = new NorthWindModel())
            {
                return context.Categories.ToList();
            }
        }

        public List<Order> GetOrders()
        {
            using (NorthWindModel context = new NorthWindModel())
            {
                return context.Orders.ToList();
            }
        }

        public Order GetOrder(int orderID)
        {
            using (NorthWindModel context = new NorthWindModel())
            {
                return context.Orders.Where(o=> o.OrderID == orderID).FirstOrDefault();
            }
        }

    }
}
