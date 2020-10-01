using MicrosoftDesenvolvimento.Models;
using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace MicrosoftDesenvolvimento.DAL
{
    class MascoteDAO 
    {
        private static List<Mascote> mascotes = new List<Mascote>();
        public static List<Mascote> ListarMasc() => mascotes;
        public static Mascote Buscar(string cpf)
        {
            foreach (Mascote mascoteCadastrado in mascotes)
            {
                if (mascoteCadastrado.CpfDono == cpf)
                {

                    return mascoteCadastrado;

                }



            }
            

            return null;
        }

        public static bool Cadastrar(Mascote mascote)
        {
            if (Buscar(mascote.CpfDono) == null)
            {
                mascotes.Add(mascote);
                return true;
            }
            mascotes.Add(mascote);
            return true;

        }

        
    }
}
