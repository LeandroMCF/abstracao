using System;

namespace abstracao.Classes
{
    public class Boleto : Pagamento
    {
        private string codigoDeBarras = "12345.12345.12345.12345";
        public string CodigoDeBarras{
            get{return codigoDeBarras;}
        }

        public string valorBoleto;      

        public void Registar(float valor, DateTime dataEmissao, string codigoDeBarras, int dias){
            Console.WriteLine($"O vlaor da compra fica em R$ {this.Valor * 0.88f} com o desconto");
            Console.WriteLine($"A data de emissão: {dataEmissao}");
            Console.WriteLine($"Data de vencimento: {dataEmissao.AddDays(dias)}");
            Console.WriteLine($"Códigos de barras: {codigoDeBarras}");
            
        }

        public override void Desconto(float valor)
        {
           valor = valor - (valor / 0.12f); 
        }
    }
}