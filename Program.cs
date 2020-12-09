using System;
using abstracao.Classes;

namespace abstracao
{
    class Program
    {
        static void Main(string[] args)
        {
            string ops, rep = "";
            Boleto boleto = new Boleto();
            Credito credito = new Credito();
            Debito debito = new Debito();

            Console.Write($"----------------\nPagamento\n----------------");
            do
            {
                Console.Write("Digite a forma de pagamento\n[B] Boleto\n[C] Cartão\nOpção: ");
                ops = Console.ReadLine();
                ops = ops.ToUpper();
                CorrigindoOpcao(ops, "B", "C");
                if (ops == "B")
                {
                    Console.Write($"Digite o código de barras");
                    boleto.CodigoDeBarra;
                }
            }while(rep != "S");




            //Funções
            void CorrigindoOpcao(string ops, string a, string b){
                while (ops != a && ops != b)
                {
                    Console.Write($"Opção inválida.\nDigite a opção novamente: ");
                    ops = Console.ReadLine();
                    ops = ops.ToUpper();
                }
            } 
        }
    }
}
