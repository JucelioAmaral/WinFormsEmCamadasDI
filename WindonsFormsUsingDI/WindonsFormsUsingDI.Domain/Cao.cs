using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WindonsFormsUsingDI.Domain
{
    public class Cao
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(100)]
        public string NomeCao { get; set; }
        [StringLength(100)]
        public string Raca { get; set; }

        public int? DonoId { get; set; }
        public Dono Dono { get; set; }
    }
}
