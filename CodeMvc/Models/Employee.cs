using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeMvc.Models
{
    public class Employee
    {
        public int id { set; get; }
        public string Name { set; get; }
        public string Contact { set; get; }
        public string Adress { set; get; }
        public string Email { set; get; }
    }
}