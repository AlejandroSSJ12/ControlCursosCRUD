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

namespace EjercicioMongoDB.Vistas
{
    public partial class MostrarDatos : Form
    {
        public MostrarDatos()
        {
            InitializeComponent();
            CargarGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MostrarDatos_Load(object sender, EventArgs e)
        {

        }

        private void CargarGrid()
        {
            dgvAlumnos.Rows.Clear();
            List<AlumnoModel> alumnoList = Queries.ObtenerAlumnos();
            foreach (AlumnoModel alumn in alumnoList)
            {
                dgvAlumnos.Rows.Add(alumn.NombreAlumno, alumn.Apellido, alumn.NombreCurso, alumn.ProgresoCurso, alumn.FechaIncio, alumn.FechaFinal);
            }
        }

        private void btnTabla_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void alumnoModelBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
