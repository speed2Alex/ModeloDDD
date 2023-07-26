using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BaseDDD.Domain.Models;

public  class TblStreaming
{
    public TblStreaming(int codigo, string? nome, DateTime? lancamento, int? nota, 
        string? descricao, int? codigoClassificacao, int? codigoGenero, int? codigoTipoStreaming,
        byte[]? imagem )
    {
        Codigo = codigo;
        Nome = nome;
        Lancamento = lancamento;
        Descricao = descricao;
        CodigoClassificacao = codigoClassificacao;
        CodigoGenero = codigoGenero;
        CodigoTipoStreaming = codigoTipoStreaming;
        Imagem = imagem;
    }

    protected TblStreaming() { }
    public int Codigo { get; set; }
    public string? Nome { get; set; }
    public DateTime? Lancamento { get; set; }
    public int? Nota { get; set; }
    public string? Descricao { get; set; }
    public int? CodigoClassificacao { get; set; }
    public int? CodigoGenero { get; set; }
    public int? CodigoTipoStreaming { get; set; }
    public byte[]? Imagem { get; set; }
   
}