using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EjercicioMongoDB.Models;
using EjercicioMongoDB.Vistas;

namespace EjercicioMongoDB
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnAct_Click(object sender, EventArgs e)
        {
            Actualizar actualizar= new Actualizar();
            actualizar.Show();
        }

        private void btnAggAlumno_Click(object sender, EventArgs e)
        {
            AgregarAlumno agregar = new AgregarAlumno();
            agregar.Show();
        }

        private void btnCurso_Click(object sender, EventArgs e)
        {
            AgregarCurso agregarCurso= new AgregarCurso();
            agregarCurso.Show();
        }
    }
}
