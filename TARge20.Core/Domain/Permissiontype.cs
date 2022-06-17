using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class Permissiontype
    {
        [Key]

        public Guid Id { get; set; }
        public string PermissionTypeName { get; set; }
        //public List<Employee> Employees { get; set; }
    }
}
