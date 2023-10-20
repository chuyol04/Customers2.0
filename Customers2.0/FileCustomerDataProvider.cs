using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customers2._0
{
    public class FileCustomerDataProvider : ICustomerDataProvider
    {
        private List<Customer> customerList = new List<Customer>();

        public List<Customer> GetCustomerList()
        {
            return customerList;
        }

        public List<Customer> GetCustomerListByAgeRange(int minAge, int maxAge)
        {
            return customerList.Where(customer => customer.Age >= minAge && customer.Age <= maxAge).ToList();
        }

        public void SaveCustomer(Customer customer)
        {
            customerList.Add(customer);
        }

        public void SaveCustomerList(List<Customer> customers)
        {
            customerList.AddRange(customers);
        }
    }
}
