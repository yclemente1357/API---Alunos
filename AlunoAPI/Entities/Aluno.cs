﻿namespace AlunoAPI.Entities;

public class Aluno
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Situacao { get; set; }
    public int Matricula { get; set; }

    public Aluno(int id, string nome, string situacao, int matricula)
    {
        Id = id;
        Nome = nome;
        Situacao = situacao;
        Matricula = matricula;
    }
}
