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
            btnGenerarHorario.Enabled = false;
            DateTime fecha = dtpInicioDeHorario.Value;

            if (fecha.DayOfWeek != DayOfWeek.Monday)
            {
                MessageBox.Show("El día elegido no es lunes", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpInicioDeHorario.Focus();
            }
            else
            {
                EHorario horario = new EHorario();

                for (int secciones = 1; secciones < 10; secciones++)
                {
                    fecha = dtpInicioDeHorario.Value.Date + dateTimeHoraInicio.Value.TimeOfDay;

                    int totalDia = 10;
                    int contadorMinutos = 0;
                    int materia = 0;

                    if (secciones == 9)
                    {
                        fecha = fecha.AddDays(3);
                    }

                    int numeroAula = lnH.aulaDocenteDisponible("IdAula", "Aulas", fecha.ToString("yyyy-MM-dd h:m"));

                    for (int ileccionesDiarias = 1; ileccionesDiarias < 11; ileccionesDiarias++)
                    {

                        if (secciones != 1)
                        {
                            materia = lnH.materiaDisponible(fecha.ToString("yyyy-MM-dd h:m"));
                        }
                        else
                        {
                            materia++;
                        }

                        int cantidadLeccionMateria = cantidadLeccionesMateria(materia);
                        int idDocente = lnH.elegir("IdDocente", "Docentes", $"IdMateria={materia}");

                        while (cantidadLeccionMateria != 0)
                        {
                            horario.Aula.IdAula = numeroAula;

                            horario.Docente.IdDocente = idDocente;
                            horario.Seccion.IdSeccion = secciones;
                            fecha = fecha.AddMinutes(sumarMinutosInicio(contadorMinutos));
                            horario.FechaInicioLeccion = fecha;
                            horario.FechaFinLeccion = fecha.AddMinutes(40);
                            lnH.insertarHorario(horario);
                            cantidadLeccionMateria--;
                            contadorMinutos++;
                            totalDia--;
                            if (totalDia == 0)
                            {
                                totalDia = 10;
                                contadorMinutos = 0;
                                fecha = fecha.AddHours(16);
                                horario.FechaInicioLeccion = fecha;
                            }
                        }


                    }
                }

                //segundo ciclo para grupos decimo a duodecimo

                //for (int secciones = 1; secciones < 5; secciones++)
                //{
                //    fecha = dtpInicioDeHorario.Value.Date + dateTimeHoraInicio.Value.TimeOfDay;

                //    int totalDia = 10;
                //    int contadorMinutos = 0;
                //    int materia = 0;

                //    if (secciones == 9)
                //    {
                //        fecha = fecha.AddDays(3);
                //    }

                //    int numeroAula = lnH.aulaDocenteDisponible("IdAula", "Aulas", fecha.ToString("yyyy-MM-dd h:m"));
                //    materia = lnH.materiaDisponible(fecha.ToString("yyyy-MM-dd h:m"));

                //    for (int ileccionesDiarias = 1; ileccionesDiarias < 11; ileccionesDiarias++)
                //    {

                //        int cantidadLeccionMateria = cantidadLeccionesMateria(materia);
                //        int idDocente = lnH.elegir("IdDocente", "Docentes", $"IdMateria={materia}");

                //        while (cantidadLeccionMateria != 0)
                //        {
                //            if (materia==10)
                //            {
                //                numeroAula = 11;
                //            }
                //            else if(materia==11)
                //            {
                //                numeroAula=12;
                //            }
                //            horario.Aula.IdAula = numeroAula;
                //            horario.Docente.IdDocente = idDocente;
                //            horario.Seccion.IdSeccion = secciones;
                //            fecha = fecha.AddMinutes(sumarMinutosInicio(contadorMinutos));
                //            horario.FechaInicioLeccion = fecha;
                //            horario.FechaFinLeccion = fecha.AddMinutes(40);
                //            lnH.insertarHorario(horario);
                //            cantidadLeccionMateria--;
                //            contadorMinutos++;
                //            totalDia--;
                //            if (totalDia == 0)
                //            {
                //                totalDia = 10;
                //                contadorMinutos = 0;
                //                fecha = fecha.AddHours(16);
                //                horario.FechaInicioLeccion = fecha;
                //            }
                //        }
                //        materia++;

                //    }
                //}

            }
            llenarDGV();
            labelPrueba.Text = lnH.contar("Horarios", "IdSeccion=1 and IdDocente=1").ToString();

        }

        private void llenarDGV(string condicion = "")
        {
            DataSet ds;
            try
            {
                ds = lnH.listarHorarios(condicion);
                dgvHorario.DataSource = ds.Tables[0];
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
                default:
                    cantidad = 0;
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

        public int cantidadLeccionesMateria1012(int idLeccion)
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
                case 7:
                    cantidad = 2;
                    break;
                case 10:
                    cantidad = 12;
                    break;
                case 11:
                    cantidad = 12;
                    break;
                default:
                    cantidad = 0;
                    break;

            }
            return cantidad;
        }
    }
}
