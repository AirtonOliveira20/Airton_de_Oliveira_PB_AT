﻿using Airton_de_Oliveira_PB_AT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airton_de_Oliveira_PB_AT
{
    internal class Disciplina
    {
       

        public int Codigo { get; set; }
        public string Nome { get; set; }

        public Turma Turma { get; set; }

        public Disciplina(int codigo, string nome)
        {
            this.Codigo = codigo;
            this.Nome = nome;
        }

     
    }
}
