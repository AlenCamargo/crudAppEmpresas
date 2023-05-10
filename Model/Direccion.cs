using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudAppEmpresa.BD
{
    public class Direccion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DireccionID { get; set; }
        public int EmpresaID { get; set; }
        public string DireccionEmp { get; set; }
        public string Ciudad { get; set;}
        public string Departamento { get; set;}
        public string Pais { get; set;}
       

        [ForeignKey("EmpresaID")]
        public virtual Empresa FK_Direccion_Empresa { get; set; }

    }
}
