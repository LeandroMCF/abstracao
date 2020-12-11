using System;
namespace abstracao.Classes
{
    public abstract class Cartao : Pagamento
    {
        public string[] bandeira = new string[3];
        public string[] numero = new string[3];
        public string[] titular = new string[3];
        public string[] cvv = new string[3];
        public int i = 0;
        
        public void SalvarCartao(){
            string salvarBandeira;
            string salvarNumero;
            string salvarTitular;
            string salvarCvv;
            if (i > 3)
            {
                Console.WriteLine($"Só é possivel salvar 3 cartões");
            }
            else
            {
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
                        salvarBandeira = "MasterCard";
                        break;
                    case "2":
                        salvarBandeira = "Visa";
                        break;
                    default:
                        salvarBandeira = "Elo";
                        break;
                }
                //add o numero do cartão
                Console.Write($"Digite o número do cartão: ");
                salvarNumero = Console.ReadLine();
                while (salvarNumero == "")
                {
                    Console.Write($"Você não digitou o número.\nDigite o número do cartão: ");
                    salvarNumero = Console.ReadLine();
                }
                //add Nome do titular
                Console.Write($"Digite o nome do titular como aparece no cartão: ");
                salvarTitular = Console.ReadLine();
                //add o cvv
                Console.Write($"Digite o cod de segurança do cartão: ");
                salvarCvv = Console.ReadLine();
                Console.Write($"Você deseja salvar esse cartão?\n[S] Sim\n[N] Não\nOpção: ");
                string opsSalvar = Console.ReadLine();
                opsSalvar = opsSalvar.ToUpper();
                while (opsSalvar != "S" && opsSalvar != "N")
                {
                    Console.WriteLine($"Resposta inválida.\nVocê deseja salvar esse cartão?\n[S] Sim\n[N] Não\nOpção: ");
                    opsSalvar = Console.ReadLine();
                    opsSalvar = opsSalvar.ToUpper();
                }
                if (opsSalvar == "S")
                {
                    bandeira[i] = salvarBandeira;
                    numero[i] = salvarNumero;
                    titular[i] = salvarTitular;
                    cvv[i] = salvarCvv;
                    i++;
                    Console.WriteLine($"Cartão salvo com sucesso!");
                }
                else
                {
                    Console.WriteLine($"seu cartão não foi salvo.");
                }
            }
        }
        
        public override void Desconto(float valor)
        {
            
        }
    }
}