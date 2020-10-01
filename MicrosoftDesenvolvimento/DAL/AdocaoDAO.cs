using MicrosoftDesenvolvimento.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftDesenvolvimento.DAL
{
    class AdocaoDAO : Cliente
    {
        private static List<Adocao> adotados = new List<Adocao>();
        public static List<Adocao> Listar() => adotados;

        public static Adocao Buscar(string cpf)
        {
            foreach (Adocao mascCadastrado in adotados)
            {
                if (mascCadastrado.CpfAdotante == cpf)
                {

                    return mascCadastrado;

                }



            }

            return null;
        }
        public static bool Cadastrar(Adocao adocao)
        {
            if (Buscar(adocao.CpfAdotante) == null)
            {
                adotados.Add(adocao);
                return true;
            }
            else
            {
                return false;
            }
           

        }
    }
}
