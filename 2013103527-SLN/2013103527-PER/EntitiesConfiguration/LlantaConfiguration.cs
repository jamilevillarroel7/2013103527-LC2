using _2013220746_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013220746_PER.Migrations
{
    public class LlantaConfiguration:EntityTypeConfiguration<Llanta>
    {
        public LlantaConfiguration()
        {
            ToTable("Llantas")
                .HasKey(c => c.LlantaId);

            HasRequired(c => c.Carro)
                .WithMany(c => c.Llantas);
        }
    }
}
