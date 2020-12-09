using System;

namespace abstracao.Classes
{
    public abstract class Pagamento
    {
        private DateTime data;
        protected float valor;
        public float Valor{
            get{return valor;}
            set{valor = value;}
        }

        //Métodos

        public void Cancelar(){
            
        }  

        //obrigatorio
        public abstract void Desconto(float valor);
    }
}