
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace SistemaOSMVC.Models
{

using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
public partial class Servico
{

    public int IdServico { get; set; }

    [Required(ErrorMessage = "Campo obrigat�rio")]
    [Display(Name = "Tipo do Servi�o")]
    public int IdTipoServicoFK { get; set; }

    [Required(ErrorMessage = "Campo obrigat�rio")]
    [Display(Name = "Ordem de Servi�o")]
    public int IdOrdemServicoFK { get; set; }

    [Required(ErrorMessage = "Campo obrigat�rio")]
    [Display(Name = "Data de Abertura")]
    public System.DateTime DataAbertura { get; set; }

    [Display(Name = "Data de Encerramento")]
    public Nullable<System.DateTime> DataEncerramento { get; set; }



    public virtual OrdemServico OrdemServico { get; set; }

    public virtual TipoServico TipoServico { get; set; }

}

}
