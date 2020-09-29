using MicrosoftDesenvolvimento.DAL;
using MicrosoftDesenvolvimento.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftDesenvolvimento.Views
{
    class ListarFuncionario
    {
        public static void ListarFunc()
        {
            Console.WriteLine(" Listar  Funcionario");
            foreach (Funcionario funcionarioCadastrado in FuncionarioDAO.Listar())
            {
                Console.WriteLine(funcionarioCadastrado);
                    
            }

        }


    }
}
