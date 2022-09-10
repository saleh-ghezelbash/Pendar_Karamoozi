using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Farzand
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string NameKhanevadegi { get; set; }
        public DateTime TarikhTavallod { get; set; }

        public virtual Personel Personel { get; set; }
    }
}
