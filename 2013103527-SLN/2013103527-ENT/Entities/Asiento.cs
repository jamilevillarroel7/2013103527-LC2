using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _2013220746_ENT
{
    [Table("Asientos")]
    public class Asiento
    {
        public Cinturon Cinturon { get; set; }
        [Key]
        public int AsientoId { get; set; }
        public string NumSerie { get; set; }

        public int CarroId { get; set; }
        public Carro Carro { get; set; }

        public Asiento()
        {
            Cinturon = new Cinturon();
        }

    }
}
