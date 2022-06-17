using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class Equiptment
    {
        [Key]

        public Guid Id { get; set; }
        public string Itemname { get; set; }
    }
}
