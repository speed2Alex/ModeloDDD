using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BaseDDD.Domain.Models;
public  class TblTipoStreaming
{
    public TblTipoStreaming(int codigo, string? descricao)
    {
        Codigo = codigo;
        Descricao = descricao;
    }
    protected TblTipoStreaming() { }
    public int Codigo { get; set; }
    public string? Descricao { get; set; }
   
}