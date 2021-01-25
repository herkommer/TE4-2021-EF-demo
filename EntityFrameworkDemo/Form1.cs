using EntityFrameworkDemo.Abstract;
using EntityFrameworkDemo.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkDemo
{
    public partial class Form1 : Form
    {
        private IRepository _repo;
        public Form1()
        {
            InitializeComponent();

            _repo = new DataStorage();

            listBox1.DataSource = _repo.Customers.ToList();
        }
    }
}
