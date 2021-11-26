using LogicaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoColegio
{
    public partial class formAdmiDocentes : Form
    {
        LNDocente lnD = new LNDocente(PConfig.getnoSoyLaCadena);

        public formAdmiDocentes()
        {
            InitializeComponent();
        }

        private void formAdmiDocentes_Load(object sender, EventArgs e)
        {
            llenarDGV();
        }

        private void llenarDGV(string condicion = "")
        {
            DataSet ds;
            try
            {
                ds = lnD.listarDocentes(condicion);
                dgvDocentes.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {

                throw ex;
            }
            dgvDocentes.Columns[0].HeaderText = "Id Docente";
            dgvDocentes.Columns[1].HeaderText = "Cedula";
            dgvDocentes.Columns[2].HeaderText = "Nombre";
            dgvDocentes.Columns[3].HeaderText = "Apellido 1";
            dgvDocentes.Columns[4].HeaderText = "Apellido 2";
            dgvDocentes.Columns[5].HeaderText = "Telefono";
            dgvDocentes.Columns[6].HeaderText = "Correo";
            dgvDocentes.Columns[7].HeaderText = "Colegio";
            dgvDocentes.Columns[8].HeaderText = "Disponible";
            dgvDocentes.Columns[9].HeaderText = "Grado Academico";
            dgvDocentes.Columns[10].HeaderText = "Borrado";
            dgvDocentes.Columns[11].HeaderText = "Materia";
            dgvDocentes.Columns[12].HeaderText = "Clave";
            dgvDocentes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void btnBusquedaDocente_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtBusquedaDocente.Text))
            {
                MessageBox.Show("Debe escribir una cedula por favor", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (lnD.buscarDocente(txtBusquedaDocente.Text) ==1)
                {
                    llenarDGV($"cedulaDoc='{txtBusquedaDocente.Text}'");
                    btnEliminarDocente.Enabled = true;
                }
                else
                {
                    MessageBox.Show("La cedula no existe","Precaución",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnEliminarDocente_Click(object sender, EventArgs e)
        {
            if (lnD.eliminarDocente(txtBusquedaDocente.Text)!=0)
            {
                MessageBox.Show("Borrado existoso", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                llenarDGV();
            }
            else
            {
                MessageBox.Show("Actualmente el docente está vinculado con otras tablas", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                llenarDGV();
            }
            
        }
    }
}
