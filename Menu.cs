using System;

namespace _2023_04_12_AP1.Domain
{
    public class Menu
    {
        public static void Exibir()
        {
            bool sair = false;
            while (!sair)
            {
                bool voltarMenu = false;
                while (!voltarMenu)
                {
                    // Exibir o menu 
                    Console.WriteLine("");
                    Console.WriteLine("----------- Menu -----------");
                    Console.WriteLine("1. Cadastros");
                    Console.WriteLine("2. Vendas");
                    Console.WriteLine("3. Sair");
                    Console.WriteLine("---------------------------");
                    Console.Write("Digite o número da opção desejada: ");
                    string opcao = Console.ReadLine();
                    switch (opcao)
                    {
                        case "1":
                            {
                                Console.WriteLine("");
                                Console.WriteLine("------ Menu Cadastros ------");
                                Console.WriteLine("1. Cadastrar Produto");
                                Console.WriteLine("2. Cadastrar Cliente");
                                Console.WriteLine("3. Listar Produtos");
                                Console.WriteLine("4. Listar Clientes");
                                Console.WriteLine("9. Voltar");
                                Console.WriteLine("---------------------------");
                                Console.Write("Digite o número da opção desejada: ");
                                string opcaoCadastros = Console.ReadLine();
                                switch (opcaoCadastros)
                                {
                                    case "1":
                                        Produtos.CadastrarProduto();
                                        break;

                                    case "2":
                                        Console.WriteLine("Cadastro de Cliente");
                                        Console.WriteLine("1) Pessoa Fisica - 2) Pessoa Juridica");
                                        string entrada = Console.ReadLine();
                                        int numero;
                                        if (int.TryParse(entrada, out numero))
                                        {
                                            if (numero == 1)
                                            {
                                                ClientesPF.CadastrarCliente();
                                                break;
                                            }
                                            else if (numero == 2)
                                            {
                                                ClientesPJ.CadastrarCliente();
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Opção invalida.");
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro válido.");
                                        }
                                        break;

                                    case "3":
                                        Console.WriteLine("-------Listagem de Produtos-------");
                                        Produtos.ListarProdutos();
                                        break;

                                    case "4":
                                        Console.WriteLine("");
                                        Console.WriteLine("-------Listagem de Clientes-------");
                                        ClientesPF.ListarClientes();
                                        ClientesPJ.ListarClientes();
                                        Console.WriteLine("-----------------------------");
                                        break;

                                    case "9":
                                        voltarMenu = true;
                                        break;

                                    default:
                                        Console.WriteLine("Opção inválida. Tente novamente.");
                                        break;
                                }
                            }
                            break;
                        case "2":
                            Vendas.EfetuarVenda();
                            break;

                        case "3":
                            Console.WriteLine("Saindo...");
                            sair = true;
                            voltarMenu = true;
                            break;

                        default:
                            Console.WriteLine("Opção inválida. Tente novamente.");
                            break;
                    }
                }
            }
            Console.WriteLine("Programa encerrado.");
        }
    }
}