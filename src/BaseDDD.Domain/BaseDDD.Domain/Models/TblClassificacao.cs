using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BaseDDD.Domain.Models;

public  class TblClassificacao
{
    public TblClassificacao(int codigo, string? nome, string? idadeMaxima, string? descricao)
    {
        Codigo = codigo;
        Nome = nome;
        IdadeMaxima = idadeMaxima;
        Descricao = descricao;
    }
    protected TblClassificacao() {}
    public int Codigo { get; set; }
    public string? Nome { get; set; }
    public string? IdadeMaxima { get; set; }
    public string? Descricao { get; set; }
   
}