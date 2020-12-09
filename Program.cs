using System;
using abstracao.Classes;

namespace abstracao
{
    class Program
    {
        static void Main(string[] args)
        {
            Boleto boleto = new Boleto();
            Cartao cartao = new Cartao();
            Credito credito = new Credito();
            Debito debito = new Debito();
        }
    }
}
