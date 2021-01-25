using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemoAdmin.Abstract
{
    public interface IRepository
    {
        List<Customer> Customers { get; }
    }
}
