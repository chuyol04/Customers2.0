using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customers2._0
{
    internal interface ICustomerDataProvider
    {
        List<Customer> GetCustomerList();
        List<Customer> GetCustomerListByAgeRange(int minAge, int maxAge);
        void SaveCustomer(Customer customer);
        void SaveCustomerList(List<Customer> customers);
    }
}
