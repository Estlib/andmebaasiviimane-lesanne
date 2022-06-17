using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class Branch
    {
        [Key]

        public Guid Id { get; set; }
        public string? Address { get; set; }
        public string? PhoneNR { get; set; }
    }
}
