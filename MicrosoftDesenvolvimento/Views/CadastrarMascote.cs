using MicrosoftDesenvolvimento.DAL;
using MicrosoftDesenvolvimento.Models;
using MicrosoftDesenvolvimento.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftDesenvolvimento.Views
{
    class CadastrarMascote
    {
        public static void Renderizar()
        {
            Console.WriteLine(" Cadastro  de Mascote");

            Mascote m = new Mascote();

            Console.WriteLine("Digite o Nome do Mascote");
            m.Nome = Console.ReadLine();
            Console.WriteLine("Digite o CPF do Dono do Mascote");
            m.CpfDono = Console.ReadLine();
            Console.WriteLine("Digite a Idade do Mascote(Em dias,anos ou Meses)");
            m.idade = Console.ReadLine();
            Console.WriteLine("Informe a  Raça do Animal");
            m.raca = Console.ReadLine();
            Console.WriteLine("Faça um Breve Resumo Sobre Seu Mascote. ");
            m.relatorio = Console.ReadLine();

            if (Validar.ValidarCpf(m.CpfDono))
            {
                if (MascoteDAO.Cadastrar(m))
                {
                    Console.WriteLine("Mascote Cadastrado com Sucesso!!");
                }
                else
                {
                    Console.WriteLine("Mascote Cadastrado com Sucesso!!");
                }

            }
            else
            {
                Console.WriteLine("CPF INVALIDO!!!");
            }
        }
    }
}
