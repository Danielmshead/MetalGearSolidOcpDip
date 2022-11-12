using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalGearSolidOcpDip
{
    class Frete : IServicoEntrega
    {
        public double Para(string cidade)
        {

            if ("LONDRINA".Equals(cidade.ToUpper()))
            {
                return 15;
            }
            return 30;
        }
    }
}
