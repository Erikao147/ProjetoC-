using MicrosoftDesenvolvimento.DAL;
using MicrosoftDesenvolvimento.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftDesenvolvimento.Views
{
    class AdotarMascote 
    {
        public static void Adocao() 
        {
            Console.WriteLine("------ADOÇÃO DE MASCOTES--------");
            Console.WriteLine("Para  que seja autorizado a  adoção o cliente deve ser Cadastrado.");
            Console.WriteLine("Para continuarmos Informe o Cpf:");
            string cpf = Console.ReadLine();

            ClienteDAO.Buscar(cpf);



        }




    }
    }
}
