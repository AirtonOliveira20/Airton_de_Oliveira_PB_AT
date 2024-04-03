using Airton_de_Oliveira_PB_AT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airton_de_Oliveira_PB_AT
{
    internal class Professor
    {
        public int Matricula { get; set; }
        public string Nome { get; set; }

        public Turma Turma { get; set; }
        public Professor(int matricula, string nome)
        {
            this.Matricula = matricula;
            this.Nome = nome;

        }


    }
}
