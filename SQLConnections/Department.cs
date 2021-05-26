using System;
using System.Collections.Generic;
using System.Text;

namespace SQL_PROJECT1.SQLConnections
{
    public class Department
    {
        public int id { get; set; }
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public List<Employ> Employs { get; set; }
        public int HeadId { get; set; }
        public int ParentDepartmentId { get; set; }
        public string Status { get; set; }
    }
}
