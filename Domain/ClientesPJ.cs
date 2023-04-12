using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2023_04_12_AP1.Domain
{
    public class ClientesPJ : Clientes
    {
        public string CNPJ { get; protected set; }


        public ClientesPJ(int parametroIdCliente, string parametroNome, string parametroCPF, string paramentroEndereco, string parametroTelefone, string parametroCNPJ) : base(parametroIdCliente, parametroNome, parametroCPF, paramentroEndereco, parametroTelefone)
        {
            CNPJ = parametroCNPJ;
        }

        public void SetCNPJ(string parametroCNPJ)
        {
            this.CNPJ = parametroCNPJ;
        }

        public override void ListarClientes(List<Clientes> listaClientes)
        {
            Console.WriteLine("Lista de Clientes (Pessoa Jurídica):");
            foreach (var cliente in listaClientes)
            {
                if (cliente is ClientesPJ clientePJ)
                {
                    Console.WriteLine($"ID: {cliente.IdCliente}\nNome: {cliente.Nome}\nEndereço: {cliente.Endereco}\nTelefone: {cliente.Telefone}\nCNPJ: {clientePJ.CNPJ}");
                }
            }
        }
    }
}