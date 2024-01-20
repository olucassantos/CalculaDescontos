using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaDescontos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string SENHA_PADRAO = "senha";

            Console.WriteLine("Bem vindo ao DescontosApp");

            // Console.WriteLine("Por favor, digite a senha:");
            //string senha = Console.ReadLine();

            if ("senha" != SENHA_PADRAO)
            {
                Console.WriteLine("A senha está incorreta!");
                Console.WriteLine("Um bjo.");
                Console.ReadKey();
                Environment.Exit(0);
            }

            // Solicita o valor do produto
            Console.WriteLine("Qual o valor do produto?");
            double valorProduto = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual a porcentagem de desconto?");
            double porcentagemDesconto = double.Parse(Console.ReadLine());

            // Verifica se as taxas de desconto estão corretas
            if (porcentagemDesconto > 50 || porcentagemDesconto < 0)
                MostraMensagemErro("A porcentagem não pode ser maior que 50% ou menor que 0%");
            else if (valorProduto < 200 && porcentagemDesconto > 20)
                MostraMensagemErro("Apenas descontos menores que 20% são permitidos para compras abaixo de 200 reais!");
            else if (valorProduto < 100 && porcentagemDesconto > 10)
                MostraMensagemErro("Apenas descontos menores que 10% são permitidos para compras abaixo de 100 reais!");

            double valorFinal = valorProduto - (valorProduto * (porcentagemDesconto / 100));

            Console.Write("O valor final do produto é ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(valorFinal.ToString("C"));
        }

        static void MostraMensagemErro(string Mensagem = "Erro na execução")
        {
            Console.WriteLine(Mensagem);
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
