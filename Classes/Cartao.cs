using System;
namespace abstracao.Classes
{
    public abstract class Cartao : Pagamento
    {
        public string[] bandeira;
        public string[] numero;
        public string[] titular;
        public string[] cvv;
        public int i;
        
        public void SalvarCartao(){
            string ops;
            //add bandeira do cartão
            Console.WriteLine($"Escolha a bandeira do seu cartão\n[1] MarterCard\n[2] Visa\n[3] Elo");
            ops = Console.ReadLine();
            while (ops != "1" && ops != "2" && ops != "3")
            {
                Console.WriteLine($"Opção inválida.\nEscolha a bandeira do seu cartão\n[1] MarterCard\n[2] Visa\n[3] Elo");
                ops = Console.ReadLine();
            }
            switch (ops)
            {
                case "1":
                    bandeira[i] = "MasterCard";
                    break;
                case "2":
                    bandeira[i] = "Visa";
                    break;
                default:
                    bandeira[i] = "Elo";
                    break;
            }
            //add o numero do cartão
            Console.Write($"Digite o número do cartão: ");
            numero[i] = Console.ReadLine();
            while (numero[i] == "")
            {
                Console.Write($"Você não digitou o número.\nDigite o número do cartão: ");
                numero[i] = Console.ReadLine();
            }
            //add Nome do titular
            Console.Write($"Digite o nome do titular como aparece no cartão: ");
            titular[i] = Console.ReadLine();
            //add o cvv
            Console.Write($"Digite o cod de segurança do cartão: ");
            cvv[i] = Console.ReadLine();
            i++;
        }
        
        public override void Desconto(float valor)
        {
            
        }
    }
}