using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2023_04_12_AP1.Domain
{
    public class Menu
    {
        static List<Produtos> listaProdutos = new List<Produtos>();
        public void Exibir()
        {
            bool sair = false;

            while (!sair)
            {
                // Exibir o menu
                Console.WriteLine("----------- Menu -----------");
                Console.WriteLine("1. Cadastrar Produto");
                Console.WriteLine("2. Listar Produtos");
                Console.WriteLine("3. Cadastrar Cliente");
                Console.WriteLine("4. Listar Clientes");
                Console.WriteLine("5. Efetuar Venda");
                Console.WriteLine("6. Sair");
                Console.WriteLine("---------------------------");
                Console.Write("Digite o número da opção desejada: ");
                string opcao = Console.ReadLine();

                // Tratar a opção selecionada
                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Cadastro de Produto.");
                        Console.WriteLine("\nDigite o ID do Produto.");
                        string idString = Console.ReadLine();
                        int id = int.Parse(idString);
                        Console.WriteLine("\nDigite o Nome do Produto.");
                        string nome = Console.ReadLine();
                        Console.WriteLine("\nDigite o Preço do Produto.");
                        string precoString = Console.ReadLine();
                        double preco;
                        if (double.TryParse(precoString, out preco))
                        {
                            Produtos produto = new Produtos(id, nome, preco);
                            Console.WriteLine("\nProduto Cadastrado.");
                        }
                        break;

                    case "2":
                        Console.WriteLine("Listagem de Produtos.");
                        Produtos.ListarProdutos(listaProdutos); // Chama o método ListarProdutos, passando a lista de produtos cadastrados
                        break;

                    case "3":
                        Console.WriteLine("Opção 3 selecionada.");
                        // Lógica da Opção 3
                        break;

                    case "4":
                        Console.WriteLine("Saindo...");
                        sair = true;
                        break;

                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }

                Console.WriteLine(); // Pular uma linha para melhorar a visualização
            }

            Console.WriteLine("Programa encerrado.");
        }
    }
}