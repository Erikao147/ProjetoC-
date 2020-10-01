using MicrosoftDesenvolvimento.DAL;
using MicrosoftDesenvolvimento.Models;
using MicrosoftDesenvolvimento.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftDesenvolvimento.Views
{
    class ListarMascCad
    {
        public static void Listar() 
        {
            MascAdocao.MascotesCad();

            Console.WriteLine("Os Mascotes disponiveis são:");
            foreach (Adocao mascCadastrado in AdocaoDAO.Listar())
            {
                Console.WriteLine(mascCadastrado);
            }


        }
    }
}
