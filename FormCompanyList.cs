using CrudAppEmpresa;
using CrudAppEmpresa.BD;
using CrudAppEmpresa.DBContext;
using System.Windows.Forms;

namespace CruaAppEmpresa
{
    public partial class FormCompanyList : Form
    {

        EmpresaContext db = new EmpresaContext();

        public FormCompanyList()
        {
            InitializeComponent();
            bindGridView();
        }
        public void bindGridView()
        {

            var query = from empresa in db.Empresas
                        join direccion in db.Direcciones on empresa.EmpresaId equals direccion.EmpresaID
                        join telefono in db.Telefonos on empresa.EmpresaId equals telefono.EmpresaID
                        select new
                        {
                            empresa.Nombre,
                            empresa.Codigo,
                            Direccion = direccion.DireccionEmp,
                            direccion.Ciudad,
                            direccion.Departamento,
                            direccion.Pais,
                            Telefono = telefono.TelefonoNum,
                            empresa.FechaCreacion,
                            empresa.FechaModificacion
                        };

            dataGridView1.DataSource = query.ToList();
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            frmEditor agregarEmpresa = new frmEditor();
            agregarEmpresa.lblTitulo.Text = "Creando nueva empresa";

            agregarEmpresa.ShowDialog();

            bindGridView();





        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            frmEditor frmEditarEmpresa = new frmEditor();
            frmEditarEmpresa.lblTitulo.Text = "Editando una Empresa";




            if (dataGridView1.SelectedRows.Count == 1)
            {


                frmEditarEmpresa.txtNombre.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                frmEditarEmpresa.txtCodigo.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                frmEditarEmpresa.txtDireccion.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                frmEditarEmpresa.txtCiudad.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                frmEditarEmpresa.txtDepartamento.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                frmEditarEmpresa.txtPais.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                frmEditarEmpresa.txtTelefono.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

                frmEditarEmpresa.ShowDialog();
                bindGridView();
            }
            else
            {
                MessageBox.Show("Selecciona un registro para editar");
            }



        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DialogResult result = MessageBox.Show("¿Está seguro de que deseas eliminar registros?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {

                        foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                        {
                            string? nombre = dataGridView1.Rows[row.Index].Cells[0].Value.ToString();



                            if (nombre != null)
                            {
                                EliminarEmpresa(nombre);
                            }

                        }
                    }
                    bindGridView();
                }
                else
                {
                    MessageBox.Show("Selecciona uno o mas registros");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("No se pudo Eliminar el o los registros" + ex);
            }
        }

        private void EliminarEmpresa(string nombreEmpresa)
        {

            var empresaAEliminar = db.Empresas.SingleOrDefault(e => e.Nombre == nombreEmpresa);

            if (empresaAEliminar != null)
            {
                var direccionesAEliminar = db.Direcciones.Where(d => d.EmpresaID == empresaAEliminar.EmpresaId);
                db.Direcciones.RemoveRange(direccionesAEliminar);
                var telefonosAEliminar = db.Telefonos.Where(t => t.EmpresaID == empresaAEliminar.EmpresaId);
                db.Telefonos.RemoveRange(telefonosAEliminar);
                db.Empresas.Remove(empresaAEliminar);
                db.SaveChanges();
            }
            else
            {

                Console.WriteLine($"No se encontró ninguna empresa con el nombre {nombreEmpresa}.");
            }
        }



        private void txtFiltrar_KeyUp(object sender, KeyEventArgs e)
        {
            var query = from empresa in db.Empresas
                        join direccion in db.Direcciones on empresa.EmpresaId equals direccion.EmpresaID
                        join telefono in db.Telefonos on empresa.EmpresaId equals telefono.EmpresaID
                        where  empresa.Nombre.Contains(txtFiltrar.Text) 
                        select new
                        {
                            empresa.Nombre,
                            empresa.Codigo,
                            Direccion = direccion.DireccionEmp,
                            direccion.Ciudad,
                            direccion.Departamento,
                            direccion.Pais,
                            Telefono = telefono.TelefonoNum,
                            empresa.FechaCreacion,
                            empresa.FechaModificacion
                        };

           
            var bindingSource = new BindingSource();
            bindingSource.DataSource = query.ToList();

         
            dataGridView1.DataSource = bindingSource;
        }
    }
}