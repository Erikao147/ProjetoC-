using MicrosoftDesenvolvimento.DAL;
using MicrosoftDesenvolvimento.Utils;
using MicrosoftDesenvolvimento.Models;
using System;
using System.Net.NetworkInformation;

namespace MicrosoftDesenvolvimento.Views
{
    class CadastrarCliente
    {
        public static void Renderizar() 
        {
            Console.WriteLine(" Cadastro  Cliente");

            Cliente c = new Cliente();

            Console.WriteLine("Digite o Nome do Cliente");
            c.Nome = Console.ReadLine();
            Console.WriteLine("Digite o CPF do Cliente");
            c.Cpf = Console.ReadLine();

            if (Validar.ValidarCpf(c.Cpf))
            {
                if (ClienteDAO.Cadastrar(c))
                {
                    Console.WriteLine("Cliente Cadastrado com Sucesso!!");
                }
                else
                {
                    Console.WriteLine("O Cliente ja existe");
                }

            }
            else
            {
                Console.WriteLine("CPF INVALIDO!!!");
            }
        }
    }
}