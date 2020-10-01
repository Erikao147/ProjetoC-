using MicrosoftDesenvolvimento.DAL;
using MicrosoftDesenvolvimento.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftDesenvolvimento.Utils
{
    class MascAdocao
    {
        public static void MascotesCad() 
        {
       


            AdocaoDAO.Cadastrar(new Adocao() { Nome ="Mel", raca ="Husky Siberiano", especie ="Cachorro",idade ="11/04/2020", genero =" Femea",CpfAdotante = "1"});
            AdocaoDAO.Cadastrar(new Adocao() { Nome = "Pretinho", raca = "Basset",especie="Gato", idade = "13/04/2020", genero = " Macho", CpfAdotante = "2" });
            AdocaoDAO.Cadastrar(new Adocao() { Nome = "Godzilla", raca = "Leopard Gecko", especie = "Lagarto", idade = "10/04/2019", genero = " Macho", CpfAdotante = "3" });
            AdocaoDAO.Cadastrar(new Adocao() { Nome = "Riven", raca = "Gato Persa", especie = "Gato", idade = "24/07/2020", genero = " Femea", CpfAdotante = "4" });
            AdocaoDAO.Cadastrar(new Adocao() { Nome = "Pandora", raca = "Não Identificada", especie = "Gato", idade = "13/1/2020", genero = " Femea", CpfAdotante = "5" });
  











        }
    
        

        //Mascotes cadastrados para adoção
       
        
    }
}
