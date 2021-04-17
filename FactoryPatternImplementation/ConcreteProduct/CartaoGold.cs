using FactoryPatternImplementation.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternImplementation.ConcreteProduct
{
    public class CartaoGold : CartaoCredito
    {
        private readonly string _tipoCartao;
        private int _limiteCredito;
        private int _cobrancaAnual;

        public CartaoGold(int limiteCredito, int cobrancaAnual)
        {
            _tipoCartao = "Gold";
            _limiteCredito = limiteCredito;
            _cobrancaAnual = cobrancaAnual;
        }


        public override string TipoCartao
        {
            get { return _tipoCartao; }
        }
        public override int LimiteCredito
        {
            get { return _limiteCredito; }
            set { _limiteCredito = value; }
        }
        public override int CobrancaAnual
        {
            get { return _cobrancaAnual; }
            set { _cobrancaAnual = value; }
        }
    }
}
