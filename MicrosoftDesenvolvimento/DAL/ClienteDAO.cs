﻿using MicrosoftDesenvolvimento.Models;
using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace MicrosoftDesenvolvimento.DAL
{
    class ClienteDAO
    {
        private static List<Cliente> clientes = new List<Cliente>();
        public static List<Cliente> Listar() => clientes;
        public static Cliente Buscar(string cpf)
        {
            foreach (Cliente clienteCadastrado in clientes)
            {
                if (clienteCadastrado.Cpf == cpf)
                {
                    
                    return clienteCadastrado;

                }
                
                

            }
            
            return null;
        }

        public static bool Cadastrar(Cliente cliente) 
        {
            if (Buscar(cliente.Cpf) == null)
            {
                clientes.Add(cliente);
                return true;
            }
            return false;

        }
    }
}
