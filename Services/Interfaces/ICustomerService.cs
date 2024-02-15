using WebApplication1.Models;

namespace WebApplication1.Services.Interfaces
{
    public interface ICustomerService
    {
        List<Customer> GetCustomers();
        Customer GetCustomerById(string id);
        Customer CreateCustomer(string id, string companyName, string contactName);
        Customer UpdateCustomer(string id, string companyName, string contactName);
        bool DeleteCustomer(string id);
    }
}