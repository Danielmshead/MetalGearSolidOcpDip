using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalGearSolidOcpDip
{
    public class Compra
    {
        public Compra(double valor, string cidade)
        {
            valor = Valor;
            cidade = Cidade;
        }

        public string Cidade { get; set; }
        public double Valor { get; set; }
    }
}
