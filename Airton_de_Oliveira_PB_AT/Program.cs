using System.Security.Cryptography.X509Certificates;

namespace Airton_de_Oliveira_PB_AT
{
    internal class Program
    {

        //teste
      //  static List<Turma> Turmas = new List<Turma>();
      //  static List<Aluno> Alunos = new List<Aluno>();
        static void Main(string[] args)
        {
             List<Turma> Turmas = new List<Turma>();
             List<Aluno> Alunos = new List<Aluno>();
            List<Professor> Professores = new List<Professor>();
            List<Disciplina> Disciplinas = new List<Disciplina>();

            int op;

            do
            {
                Console.WriteLine("\nSelecionar uma opção:");

                Console.WriteLine("1. Adicionar Alunos");
                Console.WriteLine("2. Abrir turma");
                Console.WriteLine("3. Gerar pauta");
                Console.WriteLine("4. Criar turma");
                Console.WriteLine("5. Criar aluno");
                Console.WriteLine("6. Exibir turmas");
                Console.WriteLine("0. Sair");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        AdicionarAluno(Turmas, Alunos);
                        break;

                    case 2:
                        AbrirTurma(Turmas);

                        break;

                    case 3:
                        GerarPauta(Turmas);

                        break;

                    case 4:
                        CriarTurma(Turmas, Professores, Disciplinas);

                        break;

                    case 5:
                        CriarAluno(Alunos);

                        break;

                    case 6:
                        ExibirTurmas(Alunos);

                        break;


                    default:
                        Console.WriteLine("Sistema encerrado");
                        break;
                }
            } while (op != 0);
        }

        public static void AdicionarAluno(List<Turma> Turmas, List<Aluno> Alunos)
        {
            Console.WriteLine("Digite o código do aluno a ser adicionado: ");
            int matricula = int.Parse(Console.ReadLine());

            foreach (Aluno alunos in Alunos)
            {
                if (alunos.Matricula == matricula)
                {
                    Console.WriteLine("Digite o codigo da turma que ele será alocado: ");
                    int codigoTurma = int.Parse(Console.ReadLine());

                    foreach (Turma t in Turmas)
                    {
                        if (t.Codigo == codigoTurma)
                        {
                            Console.Write(t.addAluno(alunos));
                        }

                    }

                }

            }

        }

        public static void CriarTurma(List<Turma> Turmas, List<Professor> Professores, List<Disciplina> Disciplinas)
        {
            Console.WriteLine("Digite a matricula do professor ");
            int matricula = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do professor: ");
            string nomeProfessor = Console.ReadLine();

            Professor professor = new Professor(matricula, nomeProfessor);

            Console.WriteLine("Digite o nome da disciplina:");
            string nomeDisciplina = Console.ReadLine();

            Console.WriteLine("Digite o código da disciplina: ");
            int codDisciplina = int.Parse(Console.ReadLine());

            Disciplina disciplina = new Disciplina(codDisciplina, nomeDisciplina);

            Console.WriteLine("Digite o código da turma: ");
            int codTurma = int.Parse(Console.ReadLine());

            Turma turma = new Turma(codTurma, disciplina, professor);
 
            Turmas.Add(turma);
            Professores.Add(professor);
            Disciplinas.Add(disciplina);

            Console.WriteLine("Turma criada");

        }

        public static void CriarAluno(List<Aluno> Alunos)
        {
            Console.WriteLine("Digite o nome do aluno: ");
            string nomeAluno = Console.ReadLine();

            Console.WriteLine("Digite a matricula do aluno: ");
            int matriculaAluno = int.Parse(Console.ReadLine());

            Aluno aluno1 = new Aluno(matriculaAluno, nomeAluno);

            Alunos.Add(aluno1);


        }

        public static void AbrirTurma(List<Turma> Turmas)
        {
            Console.WriteLine("Digite o código da turma ");
            int codTurma = int.Parse(Console.ReadLine());

            foreach (Turma t in Turmas)
            {
                if (t.Codigo == codTurma)
                {
                    if (t.abrirTurma())
                    {
                        Console.WriteLine("Turma aberta");
                    }
                    else
                    {
                        Console.WriteLine("Turma não pode ser aberta");
                    }
                }
            }


        }

        public static void GerarPauta(List<Turma> Turmas)
        {
            Console.WriteLine(Turmas[0].gerarPauta());
        }

        public static void ExibirTurmas( List<Aluno> Alunos)
        {
            Console.WriteLine("Digite a matricula do aluno: ");
            int matriculaAluno = int.Parse(Console.ReadLine());

            foreach (Aluno alunos in Alunos)
            {
                if (alunos.Matricula == matriculaAluno)
                {
                    alunos.ExibirTurmas();
                }
            }
        }

    }
}
