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
    
    public partial class TipoTelefone
    {
        public TipoTelefone()
        {
            this.Telefone = new HashSet<Telefone>();
        }
    
        public int IdTipoTelefone { get; set; }


        [Required(ErrorMessage = "Campo obrigat�rio")]
        [Display(Name = "Tipo telefone")]
        [StringLength(10, ErrorMessage = "No m�ximo 10 caracteres")]
        public string Tipo { get; set; }
    
        public virtual ICollection<Telefone> Telefone { get; set; }
    }
}
