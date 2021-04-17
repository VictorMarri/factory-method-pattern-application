using FactoryPatternImplementation.ConcreteProduct;
using FactoryPatternImplementation.Creator;
using FactoryPatternImplementation.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternImplementation.ConcreteCreator
{
    public class GoldFactory : CartaoFactory
    {
        private int _limiteCredito;
        private int _cobrancaAnual;

        public GoldFactory(int limiteCredito, int cobrancaAnual)
        {
            _limiteCredito = limiteCredito;
            _cobrancaAnual = cobrancaAnual;
        }

        public override CartaoCredito BuscarCartaoCredito()
        {
            return new CartaoGold(_limiteCredito, _cobrancaAnual);
        }
    }
}
