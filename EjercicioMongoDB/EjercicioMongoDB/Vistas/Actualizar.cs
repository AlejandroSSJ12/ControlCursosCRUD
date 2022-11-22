using EjercicioMongoDB.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioMongoDB
{
    public partial class Actualizar : Form
    {
        public Actualizar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                AlumnoModel alumnoModel = new AlumnoModel()
                {
                    Id = ID.Text,
                    NombreAlumno = txtNombreAlumno.Text,
                    Apellido = apellido.Text,
                    NombreCurso = txtNombreCurso.Text,
                    ProgresoCurso = (string)listProceso.SelectedItem,
                    FechaIncio = dateTimeInicio.Text,
                    FechaFinal = dateTimeFinal.Text
                };
                Queries.Actualizar(alumnoModel);
                MessageBox.Show("Datos actualizados correctamente");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Algo ha ocurrido, intentalo nuevamente");
            }
            
        }

        private void btnBuscarAlumno_Click(object sender, EventArgs e)
        {
            AlumnoModel alumno= Queries.BuscarAlumno (txtNombreAlumno.Text);
            if ( alumno == null)
            {
                MessageBox.Show("Vuelve a intentarlo");
                return;
            }
            ID.Text = alumno.Id;
            txtNombreAlumno.Text = alumno.NombreAlumno;
            apellido.Text = alumno.Apellido;
            txtNombreCurso.Text = alumno.NombreCurso;
            listProceso.SelectedItem = alumno.ProgresoCurso;
            dateTimeInicio.Text = alumno.FechaIncio;
            dateTimeFinal.Text = alumno.FechaFinal;
        }

        private void Actualizar_Load(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
