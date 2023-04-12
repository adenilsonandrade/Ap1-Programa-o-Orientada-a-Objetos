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

        // Construtor
        public Produtos(int parametroIdProduto, string parametroNome, double parametroPreco)
        {
            IdProduto = parametroIdProduto;
            Nome = parametroNome;
            Preco = parametroPreco;
        }

        // SETTERS
        public void SetIdProduto(int parametroIdProduto)
        {
            this.IdProduto = parametroIdProduto;
        }
        public void SetNome(string parametroNome)
        {
            this.Nome = parametroNome;
        }
        public void SetPreco(double parametroPreco)
        {
            this.Preco = parametroPreco;
        }
        public static void ListarProdutos(List<Produtos> listaProdutos)
        {
            Console.WriteLine("Lista de Produtos:");
            foreach (var produto in listaProdutos)
            {
                Console.WriteLine($"ID: {produto.IdProduto} | Nome: {produto.Nome} | Preço: {produto.Preco}");
            }
        }
    }
}