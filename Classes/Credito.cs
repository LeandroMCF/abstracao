using System;

namespace abstracao.Classes
{
    public class Credito : Cartao
    {
        private float limite = 3000;
        public float Limite{
            get{return limite;}
            set{limite = value;}
        }



        //Funções
        public void Pagar(float valor, int parcelas, string ops){
            while (parcelas > 12)
            {
                Console.WriteLine($"Numero de parcelas ultrapassado");
                parcelas = int.Parse(Console.ReadLine());
            }
            if (parcelas < 1 && parcelas <= 6)
            {
                valor = valor + (valor / 0.05f);
            }
            else if (parcelas > 7)
            {
                valor = valor + (valor / 0.08f);
            }
            Console.WriteLine($"Valor final é de: {valor}\n[P] Para pagar\n[C] Para cancelar");
            ops = Console.ReadLine();
            ops = ops.ToUpper();
            while (ops != "P" && ops != "C")
            {
                Console.WriteLine($"Resposta inválida.\n[P] Para pagar\n[C] Para cancelar");
                ops = Console.ReadLine();
                ops = ops.ToUpper();  
            }
            if (ops == "P")
            {
                if (Limite < valor)
                {
                    Console.WriteLine($"Limite do cartão excedido, não será possivel efetuar esse pagamento.");
                }
                else
                {
                    Console.WriteLine($"Compra efetuada!");
                    Limite = Limite - valor;
                }
            }
        }
    }
}