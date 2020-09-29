using MicrosoftDesenvolvimento.DAL;
using MicrosoftDesenvolvimento.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftDesenvolvimento.Views
{
    class ListarMascote
    {
        public static void ListarMasc()
        {
            Console.WriteLine(" Listar  Mascote");
            foreach (Mascote mascoteCadastrado in MascoteDAO.ListarMasc())
            {
                Console.WriteLine(mascoteCadastrado);

            }

        }


    }
}
