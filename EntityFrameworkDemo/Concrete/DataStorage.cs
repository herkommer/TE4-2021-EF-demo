using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameworkDemo.Abstract;

namespace EntityFrameworkDemo.Concrete
{
    public class DataStorage : IRepository
    {
        private Model1Container _repo;

        public DataStorage()
        {
            _repo = new Model1Container();
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
