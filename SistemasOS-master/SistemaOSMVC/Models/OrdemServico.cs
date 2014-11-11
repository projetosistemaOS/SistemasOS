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
    
    public partial class OrdemServico
    {
        public OrdemServico()
        {
            this.Servico = new HashSet<Servico>();
        }
    
        public int IdOrdemServico { get; set; }
        public int IdClienteFK { get; set; }
        public int IdFuncionarioFK { get; set; }
        public int IdAndamentoOSFK { get; set; }
        public int IdEquipamentoFK { get; set; }
        public int IdDefeitoFK { get; set; }
        public string OBSERVACAO { get; set; }
    
        public virtual AndamentoOS AndamentoOS { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual Defeito Defeito { get; set; }
        public virtual Equipamento Equipamento { get; set; }
        public virtual Funcionario Funcionario { get; set; }
        public virtual ICollection<Servico> Servico { get; set; }
    }
}