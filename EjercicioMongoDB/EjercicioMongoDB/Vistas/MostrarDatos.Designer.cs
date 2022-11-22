namespace EjercicioMongoDB.Vistas
{
    partial class MostrarDatos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreAlumnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.progresoCursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaIncioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaFinalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alumnoModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.AutoGenerateColumns = false;
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombreAlumnoDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.nombreCursoDataGridViewTextBoxColumn,
            this.progresoCursoDataGridViewTextBoxColumn,
            this.fechaIncioDataGridViewTextBoxColumn,
            this.fechaFinalDataGridViewTextBoxColumn});
            this.dgvAlumnos.DataSource = this.alumnoModelBindingSource;
            this.dgvAlumnos.Location = new System.Drawing.Point(46, 112);
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.RowTemplate.Height = 25;
            this.dgvAlumnos.Size = new System.Drawing.Size(644, 209);
            this.dgvAlumnos.TabIndex = 0;
            this.dgvAlumnos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nombreAlumnoDataGridViewTextBoxColumn
            // 
            this.nombreAlumnoDataGridViewTextBoxColumn.DataPropertyName = "NombreAlumno";
            this.nombreAlumnoDataGridViewTextBoxColumn.HeaderText = "NombreAlumno";
            this.nombreAlumnoDataGridViewTextBoxColumn.Name = "nombreAlumnoDataGridViewTextBoxColumn";
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            // 
            // nombreCursoDataGridViewTextBoxColumn
            // 
            this.nombreCursoDataGridViewTextBoxColumn.DataPropertyName = "NombreCurso";
            this.nombreCursoDataGridViewTextBoxColumn.HeaderText = "NombreCurso";
            this.nombreCursoDataGridViewTextBoxColumn.Name = "nombreCursoDataGridViewTextBoxColumn";
            // 
            // progresoCursoDataGridViewTextBoxColumn
            // 
            this.progresoCursoDataGridViewTextBoxColumn.DataPropertyName = "ProgresoCurso";
            this.progresoCursoDataGridViewTextBoxColumn.HeaderText = "ProgresoCurso";
            this.progresoCursoDataGridViewTextBoxColumn.Name = "progresoCursoDataGridViewTextBoxColumn";
            // 
            // fechaIncioDataGridViewTextBoxColumn
            // 
            this.fechaIncioDataGridViewTextBoxColumn.DataPropertyName = "FechaIncio";
            this.fechaIncioDataGridViewTextBoxColumn.HeaderText = "FechaIncio";
            this.fechaIncioDataGridViewTextBoxColumn.Name = "fechaIncioDataGridViewTextBoxColumn";
            // 
            // fechaFinalDataGridViewTextBoxColumn
            // 
            this.fechaFinalDataGridViewTextBoxColumn.DataPropertyName = "FechaFinal";
            this.fechaFinalDataGridViewTextBoxColumn.HeaderText = "FechaFinal";
            this.fechaFinalDataGridViewTextBoxColumn.Name = "fechaFinalDataGridViewTextBoxColumn";
            // 
            // alumnoModelBindingSource
            // 
            this.alumnoModelBindingSource.DataSource = typeof(EjercicioMongoDB.Models.AlumnoModel);
            this.alumnoModelBindingSource.CurrentChanged += new System.EventHandler(this.alumnoModelBindingSource_CurrentChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(298, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 36);
            this.label1.TabIndex = 38;
            this.label1.Text = "Alumnos";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(570, 40);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(120, 23);
            this.btnCerrar.TabIndex = 41;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnTabla_Click);
            // 
            // MostrarDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(740, 350);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAlumnos);
            this.Name = "MostrarDatos";
            this.Text = "MostrarDatos";
            this.Load += new System.EventHandler(this.MostrarDatos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvAlumnos;
        private Label label1;
        private Button btnCerrar;
        private BindingSource alumnoModelBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreAlumnoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreCursoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn progresoCursoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaIncioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaFinalDataGridViewTextBoxColumn;
    }
}