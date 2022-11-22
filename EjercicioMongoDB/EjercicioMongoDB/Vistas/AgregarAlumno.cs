using EjercicioMongoDB.Models;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioMongoDB.Vistas
{
    public partial class AgregarAlumno : Form
    {
        public AgregarAlumno()
        {
            InitializeComponent();
        }

        private void btnGuardarAlumno_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombreAlumno.Text == "" || txtNombreCurso.Text == "")
                {
                    MessageBox.Show("Revisar que todo este lleno");
                }
                AlumnoModel alumnoModel = new AlumnoModel()
                {
                    NombreAlumno = txtNombreAlumno.Text,
                    Apellido = txtApellido.Text,
                    NombreCurso = txtNombreCurso.Text,
                    ProgresoCurso = (string)listProceso.SelectedItem,
                    FechaIncio = dateTimeInicio.Text,
                    FechaFinal = dateTimeFinal.Text
                };
                if (Queries.VerificarCurso(txtNombreCurso.Text))
                {
                    Queries.InsertarAlumno(alumnoModel);
                    MessageBox.Show("Datos guardados correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se encontro una empresa con el nombre ingresado");
                }
            }
            catch
            {
                MessageBox.Show("Verifique los datos e intentelo de nuevo");
            }
            
        }

        private void dateTimePickerIni_ValueChanged(object sender, EventArgs e)
        {
            DateTime fecha = dateTimeInicio.Value;
        }

        private void lblNombreAlumno_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimeInicio_ValueChanged(object sender, EventArgs e)
        {
            DateTime fecha = dateTimeInicio.Value;
        }

        private void dateTimeFinal_ValueChanged(object sender, EventArgs e)
        {
            DateTime fecha = dateTimeFinal.Value;
        }

        private void txtNombreCurso_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTabla_Click(object sender, EventArgs e)
        {
            MostrarDatos mostrar = new MostrarDatos();
            mostrar.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
