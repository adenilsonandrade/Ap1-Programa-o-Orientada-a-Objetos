using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2023_04_12_AP1.Domain
{
    public abstract class Clientes
    {
        // Dados do Cliente
        public int IdCliente { get; private set; }
        public string Nome { get; protected set; }
        public string Endereco { get; protected set; }
        public string Telefone { get; protected set; }

        // Construtor
        public Clientes(string parametroNome, string paramentroEndereco, string parametroTelefone)
        {
            IdCliente = GeradorIds.GerarIdCliente();
            Nome = parametroNome;
            Endereco = paramentroEndereco;
            Telefone = parametroTelefone;
        }

        // SETTERS
        public void SetNome(string parametroNome)
        {
            this.Nome = parametroNome;
        }
        public void SetEndereco(string paramentroEndereco)
        {
            this.Endereco = paramentroEndereco;
        }
        public void SetTelefone(string parametroTelefone)
        {
            this.Telefone = parametroTelefone;
        }
    }
}