using MicrosoftDesenvolvimento.DAL;
using MicrosoftDesenvolvimento.Utils;
using MicrosoftDesenvolvimento.Models;
using System;
using System.Net.NetworkInformation;

namespace MicrosoftDesenvolvimento.Views
{
    class CadastrarFuncionario
    {
        public static void Renderizar()
        {
            Console.WriteLine(" ------Cadastro  Funcionario-------");

            Funcionario f = new Funcionario();

            Console.WriteLine("Digite o Nome do Funcionario");
            f.Nome = Console.ReadLine();
            Console.WriteLine("Digite o CPF do Cliente");
            f.Cpf = Console.ReadLine();
            Console.WriteLine("Digite a Especialização que deseja ser Contratado");
            f.Funcao = Console.ReadLine();

            if (Validar.ValidarCpf(f.Cpf))
            {
                if (FuncionarioDAO.Cadastrar(f))
                {
                    Console.WriteLine("Funcionario Cadastrado com Sucesso!!");
                }
                else
                {
                    Console.WriteLine("O Funcionario ja trabalha na empresa");
                }

            }
            else
            {
                Console.WriteLine("CPF INVALIDO!!!");
            }
        }
    }
}
