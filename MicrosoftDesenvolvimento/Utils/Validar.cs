﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftDesenvolvimento.Utils
{
    class Validar
    {
        public static bool ValidarCpf(string cpf)
        {
            int peso = 10, soma = 0, multp, armz1, armz2, rest;
            cpf = cpf.Replace(".", "").Replace("-", "");

            if (cpf.Length != 11)
            {
                return false;
            }
            switch (cpf)
            {
                case "11111111111": return false;
                case "22222222222": return false;
                case "33333333333": return false;
                case "44444444444": return false;
                case "55555555555": return false;
                case "66666666666": return false;
                case "77777777777": return false;
                case "88888888888": return false;
                case "99999999999": return false;
                case "00000000000": return false;
            }
            // Digito 1
            for (int i = 0; i < 9; i++)
            {
                soma += Convert.ToInt32(cpf[i].ToString()) * peso;

                peso--;
            }
            rest = soma % 11;
            if (rest < 2)
            {
                armz1 = 0;

            }
            else
            {
                armz1 = 11 - rest;
            }



            if (Convert.ToInt32(cpf[9].ToString()) != armz1)
            {
                return false;
            }

            // digito 2
            soma = 0;
            peso = 11;
            for (int i = 0; i < 10; i++)
            {


                soma += Convert.ToInt32(cpf[i].ToString()) * peso;

                peso--;
            }
            rest = soma % 11;
            if (rest < 2)
            {
                armz2 = 0;

            }
            else
            {
                armz2 = 11 - rest;
            }



            if (Convert.ToInt32(cpf[10].ToString()) != armz2)
            {
                return false;
            }
            return true;
        }
    }
}
