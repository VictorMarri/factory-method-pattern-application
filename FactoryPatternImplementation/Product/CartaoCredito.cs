using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternImplementation.Product
{
    public abstract class CartaoCredito
    {
        public abstract string TipoCartao { get;}
        public abstract int LimiteCredito { get; set; }
        public abstract int CobrancaAnual { get; set; }
    }
}
