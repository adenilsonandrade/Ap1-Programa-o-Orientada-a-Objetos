using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2023_04_12_AP1.Domain
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Cria produtos
            Produtos produto1 = new Produtos(1, "Produto 1", 100.00);
            Produtos produto2 = new Produtos(2, "Produto 2", 200.00);
            Produtos produto3 = new Produtos(3, "Produto 3", 90.00);
            Produtos produto4 = new Produtos(4, "Produto 4", 35.00);
            Produtos produto5 = new Produtos(5, "Produto 5", 160.00);

            // Cria clientes
            Clientes cliente1 = new Clientes(1, "Joao", "045.689.136-56", "Rua Joaquim Porto", "51973285761");
            ClientesPJ cliente2 = new ClientesPJ(2, "Hotel", "", "Av 10", "51 36641588", "10.469.482/0001-69");

            // Criar venda 1
            Vendas venda1 = new Vendas(cliente1); // Passa o objeto do cliente como parâmetro no construtor

            // Adiciona produtos à venda 1
            venda1.AdicionarProduto(produto1);
            venda1.AdicionarProduto(produto2);
            venda1.AdicionarProduto(produto4);
            venda1.AdicionarProduto(produto5);

            // Cálcula total da venda 1
            decimal totalVenda1 = venda1.CalcularTotalVenda();

            // Exibe resultados da venda 1
            Console.WriteLine("Detalhes da Venda:");
            Console.WriteLine($"Cliente: {venda1.Cliente.Nome + " | CPF: " + venda1.Cliente.CPF}");
            Console.WriteLine("Produtos:");
            foreach (var produto in venda1.Produtos)
            {
                Console.WriteLine($"- {produto.Nome} (R$ {produto.Preco})");
            }
            Console.WriteLine($"Total da Venda: R$ {totalVenda1}");

            // Cria venda 2 PJ
            decimal desconto = 10;
            Vendas venda2 = new Vendas(cliente2); // Passa o objeto do cliente como parâmetro no construtor

            // Adiciona produtos à venda 2
            venda2.AdicionarProduto(produto4);
            venda2.AdicionarProduto(produto5);
            venda2.AdicionarProduto(produto5);

            // Cálcula total da venda 2
            decimal totalVenda2 = venda2.CalcularTotalVenda(desconto);

            // Exibe resultados da venda 2
            Console.WriteLine("\nDetalhes da Venda 2:");
            Console.WriteLine($"Cliente: {venda2.ClientePJ.Nome + " | Telefone: " +  venda2.ClientePJ.Telefone + " | CNPJ: " + venda2.ClientePJ.CNPJ}");
            Console.WriteLine("Produtos:");
            foreach (var produto in venda2.Produtos)
            {
                Console.WriteLine($"- {produto.Nome} (R$ {produto.Preco})");
            }
            Console.WriteLine($"Total da Venda: R$ {totalVenda2}");
        }
    }
}