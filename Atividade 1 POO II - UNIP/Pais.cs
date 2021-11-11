using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_1_POO_II___UNIP
{
    public class Pais
    {



        public Pais(string nome, int ouros, int pratas, int bronzes, string urlImagem)
        {
            Nome = nome;
            Ouros = ouros;
            Pratas = pratas;
            Bronzes = bronzes;
            UrlImagem = urlImagem;
        }

        public string Nome { get; set; }
        public int Ouros { get; set; }
        public int Pratas { get; set; }
        public int Bronzes { get; set; }
        public string UrlImagem { get; set; }

        public int TotalMedalhas()
        {
            return Ouros + Pratas + Bronzes;
        }

        public override string ToString()
        {
            return Nome;
        }

    }
}
