using _2013220746_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013220746_PER.Migrations
{
    public class EnsambladoraConfiguration:EntityTypeConfiguration<Ensambladora>
    {
        public EnsambladoraConfiguration()
        {
            ToTable("Ensamblados")
                .HasKey(c=>c.EnsambladoId);


        }
    }
}
