using FactoryPatternImplementation.ConcreteCreator;
using FactoryPatternImplementation.Creator;
using FactoryPatternImplementation.Product;
using System;

namespace FactoryPatternImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            CartaoFactory cartaoFactory = null;

            Console.Write("Digite o tipo de cartao que gostaria de obter: ");
            string cartaoEscolhido = Console.ReadLine();

            switch (cartaoEscolhido.ToLower())
            {
                case "black":
                    cartaoFactory = new BlackFactory(500000, 0);
                    break;
                case "titanum":
                    cartaoFactory = new TitaniumFactory(100000, 600);
                    break;
                case "gold":
                    cartaoFactory = new GoldFactory(10000, 100);
                    break;
                case "platinum":
                    cartaoFactory = new PlatinumFactory(75000, 300);
                    break;
                default:
                    break;
            }

            CartaoCredito cartaoCredito = cartaoFactory.BuscarCartaoCredito();
            Console.WriteLine("\nOs detalhes do seu cartao estao abaixo: \n");
            Console.WriteLine("Tipo do Cartao: {0}\nLimite de Crédito: {1}\n Cobrança Anual do Cartão: {2}", cartaoCredito.TipoCartao, cartaoCredito.LimiteCredito, cartaoCredito.CobrancaAnual);
            Console.ReadKey();
        }
    }
}
