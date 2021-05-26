using System;
using System.Collections.Generic;
using System.Text;

namespace SQL_PROJECT1.SQLConnections
{
    public class Employ
    {
        public int id { get; set; }
        public int EmployId { get; set; }
        public string Status { get; set; }
        public string Telephone { get; set; }
        public Post Job { get; set; }
        public List<Department> DepartmentsId { get; set; }
        public User User { get; set; }
    }
}
