using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CrudAppEmpresa.BD
{
    public class Empresa
    {
        [Key ]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]   
        public int EmpresaId { get; set; }
        public string Nombre { get; set; }
        public int Codigo { get; set;}
        public DateTime FechaCreacion { get; set;}
        public DateTime FechaModificacion { get; set;}

        

    }
}
