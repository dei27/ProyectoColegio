using System;
using System.Data;
using System.Windows.Forms;
using Entidades;
using LogicaNegocio;

namespace ProyectoColegio
{
    public partial class Form1 : Form
    {
        LNAula ln = new LNAula(PConfig.getnoSoyLaCadena);
        LNHorario lnH = new LNHorario(PConfig.getnoSoyLaCadena);

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAsistente_Click(object sender, EventArgs e)
        {
            Asistente asistente = new Asistente();
            asistente.Show();
        }
    }
}
