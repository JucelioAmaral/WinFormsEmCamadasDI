using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WindonsFormsUsingDI.Domain
{
    public class Dono
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DonoId { get; set; }
        [StringLength(100)]
        public string NomeDono { get; set; }

        [StringLength(15)]
        public string CPF { get; set; }

        [StringLength(15)]
        public string Telefone { get; set; }

        //public virtual Cao Caes { get; set; }        
        public IEnumerable<Cao> Caes { get; set; }

        public override string ToString() => $"{NomeDono}".Trim();
    }
}
