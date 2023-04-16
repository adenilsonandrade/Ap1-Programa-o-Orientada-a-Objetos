using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2023_04_12_AP1.Domain
{
    public class ClientesPF : Clientes
    {
        public string CPF { get; protected set; }

        public ClientesPF(string parametroNome, string parametroCPF, string paramentroEndereco, string parametroTelefone) : base(parametroNome, paramentroEndereco, parametroTelefone)
        {
            CPF = parametroCPF;
        }

        public void SetCPF(string parametroCPF)
        {
            this.CPF = parametroCPF;
        }

        public static List<Clientes> listaClientesPF = new List<Clientes>();

        public static void CadastrarCliente()
        {
            Console.Write("\nDigite o Nome do Cliente: ");
            string nomeClientePF = Console.ReadLine();
            Console.Write("\nDigite o CPF do Cliente: ");
            string cpf = Console.ReadLine();
            Console.Write("\nDigite o Endereço do Cliente: ");
            string endereco = Console.ReadLine();
            Console.Write("\nDigite o Telefone do Cliente: ");
            string telefone = Console.ReadLine();
            ClientesPF clientePF = new ClientesPF(nomeClientePF, cpf, endereco, telefone);
            listaClientesPF.Add(clientePF);
            Console.WriteLine("\nCliente Cadastrado.");
        }

        public static void ListarClientes()
        {
            Console.WriteLine("\n-------Pessoa Física-------");
            if (listaClientesPF.Count == 0)
            {
                Console.WriteLine("Nenhum cliente cadastrado.");
            }
            else
            {
                Console.WriteLine("Lista de Clientes:");
                foreach (var cliente in listaClientesPF)
                {
                    Console.WriteLine($"Id: {cliente.IdCliente} | Nome: {cliente.Nome} | CPF: {((ClientesPF)cliente).CPF} | Endereço: {cliente.Endereco} | Telefone: {cliente.Telefone}");
                }
            }
        }
    }
}