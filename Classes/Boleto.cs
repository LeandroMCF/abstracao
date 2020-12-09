using System;

namespace abstracao.Classes
{
    public class Boleto : Pagamento
    {
        private string codigoDeBarras;

        public string CodigoDeBarras{
            get{return codigoDeBarras;}
        }

        public string valorBoleto;

        public void Registar(){
            Console.WriteLine($"Registrado");
        }

        public override void Desconto(float valor)
        {
           valor = valor - (valor / 0.12f); 
        }
    }
}