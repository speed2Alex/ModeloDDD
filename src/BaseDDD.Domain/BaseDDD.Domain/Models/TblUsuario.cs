
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;
using Microsoft.EntityFrameworkCore;

namespace BaseDDD.Domain.Models;
public class TblUsuario
{
    public TblUsuario(int codigo, string? nome, int? idade, string? email, int? codigoSexo,
        int? codigoGenero, string? senha)
    {
        Codigo = codigo;
        Nome = nome;
        Idade = idade;
        Email = email;
        CodigoSexo = codigoSexo;
        CodigoGenero = codigoGenero;
        Senha = senha;
    }

    protected TblUsuario() {}
    public int Codigo { get; set; }
    public string? Nome { get; set; }

    public int? Idade { get; set; }
    public string? Email { get; set; }
    public int? CodigoSexo { get; set; }
    public int? CodigoGenero { get; set; }
    public string? Senha { get; set; }

}