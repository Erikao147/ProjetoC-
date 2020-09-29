using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftDesenvolvimento.Models
{
    class Funcionario
    {

        public string Nome { get; set; }
        public string Cpf { get; set; }

        public string Funcao { get; set; }
        public DateTime Contratadoem { get; set; }


        public Funcionario()
        {
            Contratadoem = DateTime.Now;

        }

        public override string ToString()
        {
            return $"Nome: {Nome}\nCPF: {Cpf} \nCargo Exercido :{Funcao}\nData de Contração: {Contratadoem}\n";
        }
    }
}
