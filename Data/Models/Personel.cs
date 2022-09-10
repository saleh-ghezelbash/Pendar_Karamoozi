using Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Personel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string NameKhanevadegi { get; set; }
        public string Aks { get; set; }
        public string KodeMelli { get; set; }
        public long KodePersonelli { get; set; }
        public DateTime TarikhTavallod { get; set; }
        public string Address { get; set; }
        public NezamVazifehSatus NezamVazifehSatus { get; set; }

        public virtual ICollection<Tahsil> Tahsils { get; set; }
        public virtual ICollection<Farzand> Farzands { get; set; }
        public virtual ICollection<JaigahSazmani> JaigahSazmanies { get; set; }
    }
}
