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
    public partial class AgregarCurso : Form
    {
        public AgregarCurso()
        {
            
            InitializeComponent();
            CargarGrid();
        }

        private void CargarGrid()
        {
            dgvCursos.Rows.Clear();
            List<CursoModel> cursoList = Queries.ObtenerCursos();
            foreach (CursoModel curso in cursoList)
            {
                dgvCursos.Rows.Add(curso.NombreCurso, curso.NombreImparte, curso.NumLecciones, curso.Descripcion);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombreCurso.Text == "" || txtDescripcion.Text == "" || txtImparte.Text == "" || txtLecciones.Text == "")
                {
                    MessageBox.Show("Revisar que todo este lleno");
                }
                CursoModel cursoModel = new CursoModel()
                {
                    NombreCurso = txtNombreCurso.Text,
                    NombreImparte = txtImparte.Text,
                    NumLecciones = txtLecciones.Text,
                    Descripcion = txtDescripcion.Text

                };
                Queries.InsertarCurso(cursoModel);
                MessageBox.Show("Datos guardados correctamente");
                CargarGrid();
            }
            catch
            {
                MessageBox.Show("Algo ha sucedido, intentalo nuevamente");
            }
            
        }

        private void textNombreCurso_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActTabla_Click(object sender, EventArgs e)
        {
            CargarGrid();
        }
    }
}
