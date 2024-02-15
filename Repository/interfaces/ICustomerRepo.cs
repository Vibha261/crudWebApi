using WebApplication1.Models;

namespace WebApplication1.Repository.interfaces
{
    public interface ICustomerRepo
    {
        List<Customer> GetCustomers();
        Customer GetCustomerById(string id);
        Customer CreateCustomer(Customer customer);
        Customer UpdateCustomer(Customer customer);
        bool DeleteCustomer(string id);
    }
}