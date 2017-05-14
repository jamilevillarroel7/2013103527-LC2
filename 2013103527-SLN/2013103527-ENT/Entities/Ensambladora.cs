using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013220746_ENT
{
    [Table("Ensamblados")]
    public class Ensambladora
    {
        [Key]
        public int EnsambladoId { get; set; }
        public List<Carro> Carros { get; set; }

        public Ensambladora()
        {
            Carros = new List<Carro>();
        }

        public void Agregar(Carro carro)
        {
            Carros.Add(carro);
        }

        public void Eliminar(Carro carro)
        {
            Carros.Remove(carro);
        }

        public Carro EnsamblarCarro(TipoCarro tipoCarro, TipoAuto tipoAuto, TipoBus tipoBus)
        {
            Carro carro;

            if (tipoCarro == TipoCarro.Automovil)
                carro = new Automovil(new Volante(), new Parabrisas(), 4, 5, null, TipoCarro.Automovil, tipoAuto);
            else
                carro = new Bus(new Volante(), new Parabrisas(), 4, 10, null, TipoCarro.Bus, tipoBus);

            return carro;
        }

        public bool IniciarPersonalizacion()
        {
            foreach (var carro in Carros)
            {
                if (carro.TipoCarro == TipoCarro.Automovil)
                    carro.NumSerieChasis = "AUTO-CHASIS" + Carros.IndexOf(carro);
                else
                    carro.NumSerieChasis = "BUS*-CHASIS" + Carros.IndexOf(carro);
            }

            return true;
        }

        public bool FinalizarPersonalizacion()
        {
            Console.WriteLine("TIPO CARRO / CHASIS");
            Console.WriteLine("----------------------------------------");

            foreach (var carro in Carros)
            {
                Console.WriteLine("{0}/{1}", carro.TipoCarro, carro.NumSerieChasis);
            }

            Console.WriteLine("----------------------------------------");

            return true;
        }
    }
}
