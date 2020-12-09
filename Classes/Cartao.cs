using System;
namespace abstracao.Classes
{
    public class Cartao : Pagamento
    {
        public string[] bandeira;
        public string[] numero;
        public string[] titular;
        public string[] cvv;
        
        public string SalvarCartao(){
            return "";
        }
        
        public override void Desconto(float valor)
        {
            
        }
    }
}