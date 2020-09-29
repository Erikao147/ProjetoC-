using MicrosoftDesenvolvimento.DAL;
using MicrosoftDesenvolvimento.Models;
using System;
using System.Collections.Generic;

namespace MicrosoftDesenvolvimento.Views
{
    class Program
    {
        static void Main(string[] args)
        {

            Cliente c = new Cliente();
           
            int opcao = 0;
                     do
            {
                Console.Clear();
               
                Console.WriteLine("---- Projeto----- \n");
                Console.WriteLine(" 1 - Cadastrar Cliente");
                Console.WriteLine(" 2-  Listar Cliente");
                Console.WriteLine(" 3 - Cadastrar Funcionario");
                Console.WriteLine(" 4 - Listar Funcionario");
                Console.WriteLine(" 5 - Cadastrar Mascote");
                Console.WriteLine(" 6 - Listar Mascote");
                Console.WriteLine(" 0 - Sair");
                Console.WriteLine(" Escolha a Opção");
                opcao = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (opcao)
                { 
                    case 1:
                        CadastrarCliente.Renderizar();
                        break;
                    case 2:
                        ListarClientes.ListarCli();
                        break;
                    case 3:
                        CadastrarFuncionario.Renderizar();
                        break;
                    case 4:
                        ListarFuncionario.ListarFunc();
                        break;
                    case 5:
                        CadastrarMascote.Renderizar();
                        break;
                    case 6:
                        ListarMascote.ListarMasc();
                        break;
                    case 0:
                        Console.WriteLine(" Saindo...");
                        break;
                    default:
                        Console.WriteLine(" Opção Invalida");
                        break;
                }

                Console.WriteLine("Selecione uma tecla para Continuar...\n");
                Console.ReadKey();
            } while (opcao != 0);

        }

        
    }
    
}
