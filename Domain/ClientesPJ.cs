using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2023_04_12_AP1.Domain
{
    public class ClientesPJ : Clientes
    {
        public string CNPJ { get; private set; }


        public ClientesPJ(string parametroNome, string parametroCNPJ, string paramentroEndereco, string parametroTelefone) : base(parametroNome, paramentroEndereco, parametroTelefone)
        {
            CNPJ = parametroCNPJ;
        }

        public void SetCNPJ(string parametroCNPJ)
        {
            this.CNPJ = parametroCNPJ;
        }

        public static List<Clientes> listaClientesPJ = new List<Clientes>();

        public static void CadastrarCliente()
        {
            Console.Write("\nDigite o Nome do Cliente PJ: ");
            string nomeClientePJ = Console.ReadLine();
            Console.Write("\nDigite o Endereço do Cliente: ");
            string endereco = Console.ReadLine();
            Console.Write("\nDigite o Telefone do Cliente: ");
            string telefone = Console.ReadLine();
            Console.Write("\nDigite o CNPJ do Cliente: ");
            string cnpj = Console.ReadLine();
            ClientesPJ clientePJ = new ClientesPJ(nomeClientePJ, cnpj, endereco, telefone);
            listaClientesPJ.Add(clientePJ);
            Console.WriteLine("\nCliente Cadastrado.");
        }

        public static void ListarClientes()
        {
            Console.WriteLine("\n-------Pessoa Jurídica-------");
            if (listaClientesPJ.Count == 0)
            {
                Console.WriteLine("Nenhum cliente cadastrado.");
            }
            else
            {
                Console.WriteLine("Lista de Clientes:");
                foreach (var cliente in listaClientesPJ)
                {
                    Console.WriteLine($"ID: {cliente.IdCliente} | Nome: {cliente.Nome} | CNPJ: {((ClientesPJ)cliente).CNPJ} | Endereço: {cliente.Endereco} | Telefone: {cliente.Telefone}");
                }
            }
        }
    }
}