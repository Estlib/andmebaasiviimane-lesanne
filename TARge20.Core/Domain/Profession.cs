using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class Profession
    {
        [Key]

        public Guid Id { get; set; }
        public string Positiontitle { get; set; }
        public DateTime Start { get; set; }
        public DateTime? End { get; set; }
    }
}
