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

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime fecha=dtpFechaInicioHorario.Value;

            if (fecha.DayOfWeek != DayOfWeek.Monday)
            {
                MessageBox.Show("El día elegido no es lunes","Atención",MessageBoxButtons.OK,MessageBoxIcon.Error);
                dtpFechaInicioHorario.Focus();
            }
            else
            {
                EHorario horario=new EHorario();
                DateTime date = new DateTime(2021, 3, 26, 9, 0,0);
                
                horario.Aula.IdAula = 8;
                horario.Docente.IdDocente = 1;
                horario.Seccion.IdSeccion = 1;
                horario.FechaInicioLeccion = date;
                horario.FechaInicioLeccion = date.AddMinutes(40);
                lnH.insertarHorario(horario);
                llenarDGV();
                labelPrueba.Text = lnH.contar("Horarios", "IdAula", 1).ToString();
            }

        }

        private void llenarDGV(string condicion = "")
        {
            DataSet ds;
            try
            {
                ds = lnH.listarHorarios(condicion);
                //ds = ln.listarTodos(); ///like se usa como comparador % comodines para buscar por filtros en el where
                dgvAulas.DataSource = ds.Tables[0]; // se carga el data grid view  con el indice 0 del data set;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            dgvAulas.Columns[0].HeaderText = "Seccion";
            dgvAulas.Columns[1].HeaderText = "Materia";
            dgvAulas.Columns[2].HeaderText = "Docente";
            dgvAulas.Columns[3].HeaderText = "Aula";
            dgvAulas.Columns[4].HeaderText = "Hora Inicio";
            dgvAulas.Columns[5].HeaderText = "Hora Fin";
            dgvAulas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }
    }
}
