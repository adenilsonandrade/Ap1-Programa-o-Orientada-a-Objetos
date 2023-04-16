using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2023_04_12_AP1.Domain
{
    public class Vendas
    {
        List<Produtos> produtosVendidos = new List<Produtos>();
        List<Vendas> vendasRealizadas = new List<Vendas>();

        public static void AdicionarProdutos(List<Produtos> produtosVendidos, List<int> quantidadesVendidas)
        {
            do
            {
                Console.Write("\nDigite o ID do Produto: ");
                int idProduto;
                if (int.TryParse(Console.ReadLine(), out idProduto))
                {
                    var produto = Produtos.listaProdutos.FirstOrDefault(p => p.IdProduto == idProduto);
                    if (produto != null)
                    {
                        Console.Write("\nDigite a quantidade vendida: ");
                        int quantidadeVendida;
                        if (int.TryParse(Console.ReadLine(), out quantidadeVendida))
                        {
                            // Realiza a venda
                            produtosVendidos.Add(produto); // Adiciona o produto vendido à lista de produtos vendidos
                            quantidadesVendidas.Add(quantidadeVendida); // Adiciona a quantidade vendida à lista de quantidades vendidas
                        }
                        else
                        {
                            Console.WriteLine("\nQuantidade inválida. Tente novamente.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nProduto não encontrado.");
                    }
                }
                else
                {
                    Console.WriteLine("\nID do Produto inválido. Tente novamente.");
                }

                Console.Write("\nDeseja adicionar mais produtos à venda? (S/N): ");
                string resposta = Console.ReadLine();

                if (resposta.ToLower() != "s")
                {
                    break; // Encerra o loop se o usuário não deseja adicionar mais produtos
                }

            } while (true);
        }
        public static void EfetuarVenda()
        {
            Console.WriteLine("Efetuar Venda.");
            Console.Write("\nDigite o ID do Cliente: ");
            int idCliente;
            if (int.TryParse(Console.ReadLine(), out idCliente))
            {
                var clientePF = ClientesPF.listaClientesPF.FirstOrDefault(c => c.IdCliente == idCliente);
                var clientePJ = ClientesPJ.listaClientesPJ.FirstOrDefault(c => c.IdCliente == idCliente);

                if (clientePF != null)
                {
                    List<Produtos> produtosVendidos = new List<Produtos>(); // Lista para armazenar os produtos vendidos
                    List<int> quantidadesVendidas = new List<int>(); // Lista para armazenar as quantidades vendidas dos produtos

                    AdicionarProdutos(produtosVendidos, quantidadesVendidas); // Chama o método AdicionarProdutos para adicionar os produtos vendidos

                    // Exibe a lista de produtos vendidos
                    Console.WriteLine($"\nVenda realizada:\nCliente: {clientePF.Nome} | ID: {clientePF.IdCliente}");

                    Console.WriteLine("\nProdutos vendidos:");
                    for (int i = 0; i < produtosVendidos.Count; i++)
                    {
                        Console.WriteLine($"Produto: {produtosVendidos[i].Nome} | ID: {produtosVendidos[i].IdProduto} | Preço: R$ {produtosVendidos[i].Preco},00 | Quantidade: {quantidadesVendidas[i]}");
                    }
                    CalcularTotalVenda(produtosVendidos, quantidadesVendidas);
                }
                else if (clientePJ != null)
                {
                    List<Produtos> produtosVendidos = new List<Produtos>(); // Lista para armazenar os produtos vendidos
                    List<int> quantidadesVendidas = new List<int>(); // Lista para armazenar as quantidades vendidas dos produtos

                    AdicionarProdutos(produtosVendidos, quantidadesVendidas); // Chama o método AdicionarProdutos para adicionar os produtos vendidos

                    // Exibe a lista de produtos vendidos
                    Console.WriteLine($"\nVenda realizada:\nCliente: {clientePJ.Nome} | ID: {clientePJ.IdCliente}");

                    Console.WriteLine("\nProdutos vendidos:");
                    for (int i = 0; i < produtosVendidos.Count; i++)
                    {
                        Console.WriteLine($"Produto: {produtosVendidos[i].Nome} | ID: {produtosVendidos[i].IdProduto} | Preço: R$ {produtosVendidos[i].Preco},00 | Quantidade: {quantidadesVendidas[i]}");
                    }
                    CalcularTotalVenda(produtosVendidos, quantidadesVendidas);
                }
                else
                {
                    Console.WriteLine("\nCliente não encontrado.");
                }
            }
            else
            {
                Console.WriteLine("\nID do Cliente inválido. Tente novamente.");
            }
        }

        static void CalcularTotalVenda(List<Produtos> produtosVendidos, List<int> quantidadesVendidas)
        {
            decimal totalVenda = 0;

            for (int i = 0; i < produtosVendidos.Count; i++)
            {
                decimal precoProduto = Convert.ToDecimal(produtosVendidos[i].Preco);
                int quantidadeVendida = quantidadesVendidas[i];
                decimal subtotal = precoProduto * quantidadeVendida; // Calcula o subtotal para cada produto vendido
                totalVenda += subtotal; // Soma o subtotal ao total da venda
            }

            Console.WriteLine($"\nTotal da venda: R$ {totalVenda},00");
        }

    }
}