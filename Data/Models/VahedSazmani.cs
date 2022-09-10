using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class VahedSazmani
    {
        [Key]
        public int Id { get; set; }
        public string OnvanVahed { get; set; }


        [ForeignKey("vahedSazmani")]
        public int ParentId { get; set; }
        public virtual VahedSazmani vahedSazmani { get; set; }
        public virtual ICollection<VahedSazmani> VahedSazmanies { get; set; }
    }
}
