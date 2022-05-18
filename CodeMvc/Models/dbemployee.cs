using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace CodeMvc.Models
{
    public class dbemployee:DbContext
    {
        public dbemployee() : base("Data Source=CHETUIWK1356\\SQLEXPRESS;Initial Catalog=CodeMvcNirbhay;Integrated Security=True;Pooling=False") { }
        public DbSet<Employee> Employees { get; set; }
    }
}