using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013220746_ENT
{
    [Table("Cinturones")]
    public class Cinturon
    {
        [Key]
        public int CinturonId { get; set; }
        public string NumSerie { get; set; }
        public int Metraje { get; set; }
        public int AsientoId { get; set; }
        public Asiento Asiento { get; set; }

    }
}
