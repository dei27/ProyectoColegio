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
    public partial class AsistentePrincipal : Form
    {
        public AsistentePrincipal()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Asistente asistente = new Asistente();
            asistente.Show();
        }

        private void btnAdmiDocentes_Click(object sender, EventArgs e)
        {
            formAdmiDocentes docentes = new formAdmiDocentes();
            docentes.Show();
        }

        private void btnSecciones_Click(object sender, EventArgs e)
        {
            formAdmiSecciones secciones = new formAdmiSecciones();
            secciones.Show();
        }

        private void btnEncargados_Click(object sender, EventArgs e)
        {
            formAdmiEncargados encargados = new formAdmiEncargados();
            encargados.Show();
        }

        private void btnAdmiEstudiantes_Click(object sender, EventArgs e)
        {
            formAdmiEstudiantes estudiantes = new formAdmiEstudiantes();
            estudiantes.Show();
        }

        private void AsistentePrincipal_Load(object sender, EventArgs e)
        {
            btnAdmiEstudiantes.Enabled = false;
            btnEncargados.Enabled = false;
            btnSecciones.Enabled = false;
        }
    }
}
