using MicrosoftDesenvolvimento.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftDesenvolvimento.Models
{
    class Adocao
    {
        public DateTime Adotadoem { get; set; }
        public Cliente Cliente { get; set; }

        public Mascote Mascote { get; set; }

        public string Nome { get; set; }

        public string CpfAdotante { get; set; }

        public string idade { get; set; }

        public string raca { get; set; }
        public string genero { get; set; }
        public string especie { get; set; }

        

         

        public Adocao()
        {
            Adotadoem = DateTime.Now;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}\nCPF do Adotante: {CpfAdotante}\nDia de Nascimento  {idade}\nRaça:{raca}\nEspecie: {especie} \nGenêro: {genero}\nData de Resgate: {Adotadoem}\n\n";
        }

    }
}
