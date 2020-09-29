using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftDesenvolvimento.Models
{
    class Mascote
    {
        public string Nome { get; set; }
        public string CpfDono { get; set; }

        public string raca { get; set; }

        public string idade { get; set; }

        public string relatorio { get; set; }

        public   DateTime DataCad { get; set; }


        public Mascote()
        {
            DataCad = DateTime.Now;

        }

        public override string ToString()
        {
            return $"Nome do Mascote: {Nome}\nCPF: {CpfDono} \nRaça: {raca}\nIdade Atual :{idade}\nData de Cadastro: {DataCad}\nRelatório sobre o Animal:{relatorio}\n\n";
        }
    }

    
}
