using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftDesenvolvimento.Models
{
    class Cliente
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime Criadoem { get; set; }
         


        public Cliente() 
        {
            Criadoem = DateTime.Now;
        }
        public override string ToString()
        {
            return $"Nome: {Nome}\nCPF: {Cpf} \nData de Cadastro: {Criadoem}\n";
        }
    }
}
