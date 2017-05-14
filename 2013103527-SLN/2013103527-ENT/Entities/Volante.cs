﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013220746_ENT
{
    [Table("Volantes")]
    public class Volante
    {
        [Key]
        public int VolanteId { get; set; }
        public string NumSerie { get; set; }
    }
}
