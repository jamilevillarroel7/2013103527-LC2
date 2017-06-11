using _2013103527_ENT.Entities;
using _2013103527_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013103527_PER.Repositories
{
    public class AsientoRepository : Repository <Asiento>, IAsientoRepository
    {
        public AsientoRepository(EnsambladoraDbContext context) : base(context)
        {

        }

    }
}
