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
    
    public partial class Servico
    {
        public int IdServico { get; set; }
        public int IdTipoServicoFK { get; set; }
        public int IdOrdemServicoFK { get; set; }
        public Nullable<System.DateTime> DataAbertura { get; set; }
        public System.DateTime DataEncerramento { get; set; }
    
        public virtual OrdemServico OrdemServico { get; set; }
        public virtual TipoServico TipoServico { get; set; }
    }
}
