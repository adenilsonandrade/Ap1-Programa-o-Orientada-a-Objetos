using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2023_04_12_AP1.Domain
{
    public class Produtos
    {
        // Dados do Produto
        public int IdProduto { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produtos(string parametroNome, double parametroPreco)
        {
            IdProduto = GeradorIds.GerarIdProduto();
            Nome = parametroNome;
            Preco = parametroPreco;
        }

        // SETTERS
        public void SetNome(string parametroNome)
        {
            this.Nome = parametroNome;
        }
        public void SetPreco(double parametroPreco)
        {
            this.Preco = parametroPreco;
        }

        public static List<Produtos> listaProdutos = new List<Produtos>();

        public static void CadastrarProduto()
        {
            Console.WriteLine("Cadastro de Produto.");
            Console.Write("\nDigite o Nome do Produto: ");
            string nomeProduto = Console.ReadLine();
            if (listaProdutos.Any(produto => produto.Nome == nomeProduto))
            {
                Console.WriteLine("\nProduto já cadastrado.");
            }
            else
            {
                Console.Write("\nDigite o Preço do Produto: ");
                string precoString = Console.ReadLine();
                double preco;
                if (double.TryParse(precoString, out preco))
                {
                    Produtos produto = new Produtos(nomeProduto, preco);
                    listaProdutos.Add(produto);
                    Console.WriteLine("\nProduto Cadastrado.");
                }
                else
                {
                    Console.WriteLine("\nPreço inválido. Tente novamente.");
                }
            }
        }

        public static void ListarProdutos()
        {
            if (listaProdutos.Count == 0)
            {
                Console.WriteLine("Nenhum produto cadastrado.");
            }
            else
            {
                Console.WriteLine("\nLista de Produtos:");
                foreach (var produto in listaProdutos)
                {
                    Console.WriteLine($"ID: {produto.IdProduto} | Nome: {produto.Nome} | Preço: R$ {produto.Preco},00");
                }
            }
        }
    }
}