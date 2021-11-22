using Entidades;
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
    public partial class Asistente : Form
    {
        LNAula ln = new LNAula(PConfig.getnoSoyLaCadena);
        LNHorario lnH = new LNHorario(PConfig.getnoSoyLaCadena);

        public Asistente()
        {
            InitializeComponent();
        }

        private void btnGenerarHorario_Click(object sender, EventArgs e)
        {
            DateTime fecha = dtpInicioDeHorario.Value;

            if (fecha.DayOfWeek != DayOfWeek.Monday)
            {
                MessageBox.Show("El día elegido no es lunes", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpInicioDeHorario.Focus();
            }
            else
            {
                DateTime date = new DateTime(2021, 3, 26, 7, 20, 0);
                int totalDia = 0;
                int aulas = 1;
                int dia = 0;


                EHorario horario = new EHorario();
                while (aulas < 9)
                {
                    while (dia < 5)
                    {
                        while (totalDia < 11)
                        {
                            int numLeccion = 1;
                            int contadorMinutos = 0;
                            int cantidadLeccionMateria = cantidadLeccionesMateria(numLeccion);

                            while (cantidadLeccionMateria != 0)
                            {
                                //int cantidadProfe = lnH.contar("Horarios", $"IdMateria={lecciones} and IdDocente={lecciones}");
                                horario.Aula.IdAula = aulas;
                                horario.Docente.IdDocente = numLeccion;
                                horario.Seccion.IdSeccion = aulas;
                                date = date.AddMinutes(sumarMinutosInicio(contadorMinutos));
                                horario.FechaInicioLeccion = date;
                                horario.FechaFinLeccion = date.AddMinutes(40);
                                lnH.insertarHorario(horario);
                                cantidadLeccionMateria--;
                                contadorMinutos++;
                                numLeccion++;
                            }
                            totalDia = +cantidadLeccionMateria;
                        }
                        date = date.AddHours(16);
                        horario.FechaInicioLeccion = date;
                        dia++;
                    }
                    aulas++;
                }
            }
            llenarDGV();
            labelPrueba.Text = lnH.contar("Horarios", "IdSeccion=1 and IdDocente=1").ToString();

            //('Ingles'),
            //('Ciencias'),
            //('Matematicas'),
            //('Español'),
            //('Estudios Sociales'),
            //('Frances'),
            //('Educacion Fisica'),
            //('Musica'),
            //('Educacion Financiera'),
            //('Computo'),
            //('Contabilidad'),


        }

        private void llenarDGV(string condicion = "")
        {
            DataSet ds;
            try
            {
                ds = lnH.listarHorarios(condicion);
                //ds = ln.listarTodos(); ///like se usa como comparador % comodines para buscar por filtros en el where
                dgvHorario.DataSource = ds.Tables[0]; // se carga el data grid view  con el indice 0 del data set;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            dgvHorario.Columns[0].HeaderText = "Seccion";
            dgvHorario.Columns[1].HeaderText = "Materia";
            dgvHorario.Columns[2].HeaderText = "Docente";
            dgvHorario.Columns[3].HeaderText = "Aula";
            dgvHorario.Columns[4].HeaderText = "Hora Inicio";
            dgvHorario.Columns[5].HeaderText = "Hora Fin";
            dgvHorario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        public int cantidadLeccionesMateria(int idLeccion)
        {
            int cantidad = 0;

            switch (idLeccion)
            {
                case 1:
                    cantidad = 6;
                    break;
                case 2:
                    cantidad = 4;
                    break;
                case 3:
                    cantidad = 4;
                    break;
                case 4:
                    cantidad = 4;
                    break;
                case 5:
                    cantidad = 4;
                    break;
                case 6:
                    cantidad = 2;
                    break;
                case 7:
                    cantidad = 2;
                    break;
                case 8:
                    cantidad = 2;
                    break;
                case 9:
                    cantidad = 1;
                    break;
                case 10:
                    cantidad = 12;
                    break;
                case 11:
                    cantidad = 12;
                    break;
            }
            return cantidad;
        }

        public int sumarMinutosInicio(int numeroLeccion)
        {
            int minutos;

            switch (numeroLeccion)
            {
                case 0:
                    minutos = 0;
                    break;
                case 2:
                    minutos = 60;
                    break;
                case 4:
                    minutos = 60;
                    break;
                case 6:
                    minutos = 100;
                    break;
                case 8:
                    minutos = 60;
                    break;
                default:
                    minutos = 40;
                    break;
            }

            return minutos;
        }
    }
}
