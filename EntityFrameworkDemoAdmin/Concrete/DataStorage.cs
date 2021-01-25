using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameworkDemoAdmin.Abstract;

namespace EntityFrameworkDemoAdmin.Concrete
{
    public class DataStorage : IRepository
    {
        private SwanEntities _repo;

        public DataStorage()
        {
            _repo = new SwanEntities();
        }

        public List<Customer> Customers
        {
            get
            { 
                return _repo.Customers.ToList(); 
            }
        }



    }
}
