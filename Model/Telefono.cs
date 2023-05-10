using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudAppEmpresa.BD
{
    public class Telefono
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TelefonoId { get; set; }
        public int EmpresaID { get; set; }
        public string TelefonoNum { get; set;}
        
        [ForeignKey("EmpresaID")]
        public virtual Empresa FK_Telefono_Empresa { get; set; }
    }
}
