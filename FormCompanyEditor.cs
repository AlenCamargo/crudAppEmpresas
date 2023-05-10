using CruaAppEmpresa;
using CrudAppEmpresa.BD;
using CrudAppEmpresa.DBContext;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudAppEmpresa
{

    public partial class frmEditor : Form
    {

        public int idEmpresa;
        EmpresaContext db = new EmpresaContext();


        public frmEditor()
        {
            InitializeComponent();

        }



        public bool ExisteEmpresa(string nombre)
        {

            return db.Empresas.Any(e => e.Nombre == nombre);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de que desea cancelar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                this.Close();
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtCiudad.Text) || string.IsNullOrEmpty(txtCodigo.Text) || string.IsNullOrEmpty(txtDepartamento.Text) || string.IsNullOrEmpty(txtDireccion.Text) || string.IsNullOrEmpty(txtPais.Text) || string.IsNullOrEmpty(txtTelefono.Text))
            {
                MessageBox.Show("Faltan campos por rellenar");
            }
            else
            {
                if (ExisteEmpresa(txtNombre.Text) && lblTitulo.Text == "Creando nueva empresa")
                {
                    MessageBox.Show("Ya existe una empresa con el mismo nombre");
                    return;
                }
                else
                {
                    if (lblTitulo.Text == "Creando nueva empresa")
                    {
                        agregarEmpresa();

                    }
                    else
                    {

                        try
                        {
                            actualizarEmpresa(idEmpresa, txtNombre.Text, txtCodigo.Text, txtDireccion.Text, txtCiudad.Text, txtDepartamento.Text, txtPais.Text, txtTelefono.Text);
                            MessageBox.Show("Elemento editado con exito");
                            this.Close();
                        }
                        catch (Exception)
                        {

                            MessageBox.Show("Error al insertar datos. Varifica que la casilla Codigo sea de tipo numerica");
                        }
                    }


                }
            }

            



        }

        public void actualizarEmpresa(int empresaId, string nuevoNombre, string nuevoCodigo, string nuevaDireccion, string nuevaCiudad, string nuevoDepartamento, string nuevoPais, string nuevoTelefono)
        {


            var empresa = db.Empresas.Find(empresaId);

            if (empresa != null)
            {
                empresa.Nombre = nuevoNombre;
                empresa.Codigo = Convert.ToInt32(nuevoCodigo);
                empresa.FechaModificacion = DateTime.Now;
                var direccion = db.Direcciones.FirstOrDefault(d => d.EmpresaID == empresaId);

                if (direccion != null)
                {
                    direccion.DireccionEmp = nuevaDireccion;
                    direccion.Ciudad = nuevaCiudad;
                    direccion.Departamento = nuevoDepartamento;
                    direccion.Pais = nuevoPais;

                }

                var telefono = db.Telefonos.FirstOrDefault(t => t.EmpresaID == empresaId);

                if (telefono != null)
                {
                    telefono.TelefonoNum = nuevoTelefono;
                }

                db.SaveChanges();
            }
            else
            {
                MessageBox.Show("Empresa no encontrada");
            }

        }

        public void agregarEmpresa()
        {
            try
            {
                Empresa nuevaEmpresa = new Empresa
                {
                    Nombre = txtNombre.Text,
                    Codigo = Convert.ToInt32(txtCodigo.Text),
                    FechaCreacion = DateTime.Now,
                    FechaModificacion = DateTime.Now
                };
                db.Empresas.Add(nuevaEmpresa);


                Direccion nuevaDireccion = new Direccion
                {
                    EmpresaID = nuevaEmpresa.EmpresaId,
                    DireccionEmp = txtDireccion.Text,
                    Ciudad = txtCiudad.Text,
                    Departamento = txtDepartamento.Text,
                    Pais = txtPais.Text,

                };
                db.Direcciones.Add(nuevaDireccion);


                Telefono nuevoTelefono = new Telefono
                {
                    EmpresaID = nuevaEmpresa.EmpresaId,
                    TelefonoNum = txtTelefono.Text,

                };
                db.Telefonos.Add(nuevoTelefono);


                db.SaveChanges();


                MessageBox.Show("Empresa agregada con Exito");

                this.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Error del sistema, Verifica que el Codigo sea tipo numerico");
            }
            
        }

        private void frmEditor_Load(object sender, EventArgs e)
        {
            if(lblTitulo.Text=="Editando una Empresa")
            {
       
                string nombreEmpresa = txtNombre.Text;
                var empresa = db.Empresas.FirstOrDefault(e => e.Nombre == nombreEmpresa);
                if (empresa != null)
                {
                    idEmpresa = empresa.EmpresaId;

                }
            }
        }
    }
}
