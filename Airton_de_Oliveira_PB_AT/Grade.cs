using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airton_de_Oliveira_PB_AT
{
    internal class Grade
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }

        public Grade(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
        }


    }
}
