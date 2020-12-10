using System;

namespace abstracao.Classes
{
    public abstract class Pagamento
    {
        private DateTime data;
        public DateTime Data{
            get{return DateTime.Now;}
        }
        protected float valor;
        public float Valor{
            set{valor = value;}
            get{return valor;}
        }

        //Métodos

        public void Cancelar(){
            
        }  

        //obrigatorio
        public abstract void Desconto(float valor);
    }
}