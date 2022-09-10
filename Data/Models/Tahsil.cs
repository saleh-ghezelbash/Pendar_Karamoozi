using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Tahsil
    {
        [Key]
        public int Id { get; set; }
        public DateTime? TarikheFaregh { get; set; }
        public float? Moadel { get; set; }

        public virtual Daneshgah Daneshgah { get; set; }
        public virtual Personel Personel { get; set; }
    }
}
