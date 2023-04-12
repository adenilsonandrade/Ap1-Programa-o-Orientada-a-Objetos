using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2023_04_12_AP1.Domain
{
    public class Vendas
    {
        public Clientes Cliente { get; set; }
        public PessoaJuridica ClientePJ { get; set; }
        public List<Produtos> Produtos { get; set; }

        public Vendas(Clientes cliente)
        {
            Cliente = cliente;
            Produtos = new List<Produtos>();
        }

        public Vendas(PessoaJuridica cliente)
        {
            ClientePJ = cliente;
            Produtos = new List<Produtos>();
        }

        public void AdicionarProduto(Produtos produto)
        {
            Produtos.Add(produto);
        }

        public decimal CalcularTotalVenda()
        {
            decimal total = 0;
            foreach (var produto in Produtos)
            {
                total += (decimal)produto.Preco;
            }
            return total;
        }

        public decimal CalcularTotalVenda(decimal desconto)
        {
            decimal total = 0;
            foreach (var produto in Produtos)
            {
                total += (decimal)produto.Preco;
            }
            desconto = total * (desconto / 100);
            total = total - desconto;
            return total;
        }
    }
}