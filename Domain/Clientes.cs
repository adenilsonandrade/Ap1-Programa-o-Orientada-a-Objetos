using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2023_04_12_AP1.Domain
{
    public class Clientes
    {
        // Dados do Cliente
        public int IdCliente { get; protected set; }
        public string Nome { get; protected set; }
        public string CPF { get; protected set; }
        public string Endereco { get; protected set; }
        public string Telefone { get; protected set; }

        // Construtor
        public Clientes(int parametroIdCliente, string parametroNome, string parametroCPF, string paramentroEndereco, string parametroTelefone)
        {
            IdCliente = parametroIdCliente;
            Nome = parametroNome;
            CPF = parametroCPF;
            Endereco = paramentroEndereco;
            Telefone = parametroTelefone;
        }

        // SETTERS
        public void SetIdCliente(int parametroIdCliente)
        {
            this.IdCliente = parametroIdCliente;
        }
        public void SetNome(string parametroNome)
        {
            this.Nome = parametroNome;
        }
        public void SetCPF(string parametroCPF)
        {
            this.CPF = parametroCPF;
        }
        public void SetEndereco(string paramentroEndereco)
        {
            this.Endereco = paramentroEndereco;
        }
        public void SetTelefone(string parametroTelefone)
        {
            this.Telefone = parametroTelefone;
        }

        public virtual void ListarClientes(List<Clientes> listaClientes)
        {
            Console.WriteLine("Lista de Clientes:");
            foreach (var cliente in listaClientes)
            {
                Console.WriteLine($"ID: {cliente.IdCliente}\nNome: {cliente.Nome}\nCPF: {cliente.CPF}\nEndereço: {cliente.Endereco}\nTelefone: {cliente.Telefone}");
            }
        }

    }
}