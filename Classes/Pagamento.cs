using System;

namespace abstracao.Classes
{
    public abstract class Pagamento
    {
        private DateTime data;
        protected float valor;

        //Métodos

        public string Cancelar(){
            return "";
        }  

        //obrigatorio
        public abstract void Desconto(float valor);
    }
}