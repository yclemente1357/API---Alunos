using AlunoAPI.Entities;

namespace AlunoAPI.Repository;

public class AlunoRepository
{
    public static List<Aluno> BancoDeDados { get; set; } = new List<Aluno>();
    public void Carga()
    {
        Aluno aluno1 = new Aluno(1, "Yuri", "Matriculado", 12345);
        Aluno aluno2 = new Aluno(2, "Yasmin", "Bloqueado", 54321);
        Aluno aluno3 = new Aluno(3, "Josi", "CANCELADO", 087);
        Aluno aluno4 = new Aluno(4, "Isadora", "Matriculado", 657);
        Aluno aluno5 = new Aluno(5, "Larissa", "Bloqueado", 5347);
        Aluno aluno6 = new Aluno(6, "Fabio", "CANCELADO", 159);  
        Aluno aluno7 = new Aluno(7, "EuNovamente kkkk ", "Matriculado", 0396);

        BancoDeDados.Add(aluno1);
        BancoDeDados.Add(aluno2);
        BancoDeDados.Add(aluno3);
        BancoDeDados.Add(aluno4);
        BancoDeDados.Add(aluno5);
        BancoDeDados.Add(aluno6);
        BancoDeDados.Add(aluno7);
    }
}
