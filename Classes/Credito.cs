using System;

namespace abstracao.Classes
{
    public class Credito : Cartao
    {
        private float limite = 3000;
        public float Limite{
            get{return limite;}
        }



        //Funções
        public void Pagar(float valor, int parcelas){
            while (parcelas < 12)
            {
                Console.WriteLine($"Numero de parcelas ultrapassado");
                parcelas = int.Parse(Console.ReadLine());
            }
            if (parcelas <= 6)
            {
                valor = valor + (valor / 0.05f);
            }
            if (parcelas > 7)
            {
                valor = valor + (valor / 0.08f);
            }
        }
    }
}