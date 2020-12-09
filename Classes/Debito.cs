using System;
namespace abstracao.Classes
{
    public class Debito : Cartao
    {
        private float saldo = 600;
        public float Saldo{
            get {return saldo;}
        }

        public void Pagar(float valor){
            if (valor < saldo)
            {
                Console.WriteLine($"Saldo insuficiente para completar o pagamento.");
            }
            else
            {
                saldo = saldo - valor;
            }
        }
    }
}