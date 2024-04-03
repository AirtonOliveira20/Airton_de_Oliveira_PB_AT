using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airton_de_Oliveira_PB_AT
{
    internal class Curso
    {

        public int Codigo { get; set; }
        public string Nome {  get; set; }

        List<Aluno> Alunos = new List<Aluno>();

        public Curso(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
        }

        public void addAluno(Aluno aluno)
        {
            Alunos.Add(aluno);
        }

        public string exibirAlunos()
        {
           foreach(var aux in Alunos)
            {
                Console.WriteLine(aux.ToString());
            }
        }


    }
}
