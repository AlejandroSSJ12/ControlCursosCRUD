namespace EjercicioMongoDB.Vistas
{
    partial class AgregarCurso
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
            this.btnCurso = new System.Windows.Forms.Button();
            this.txtLecciones = new System.Windows.Forms.TextBox();
            this.txtImparte = new System.Windows.Forms.TextBox();
            this.txtNombreCurso = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.NombreCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imparte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumLecciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnActTabla = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCurso
            // 
            this.btnCurso.Location = new System.Drawing.Point(182, 317);
            this.btnCurso.Name = "btnCurso";
            this.btnCurso.Size = new System.Drawing.Size(120, 23);
            this.btnCurso.TabIndex = 50;
            this.btnCurso.Text = "Guardar datos";
            this.btnCurso.UseVisualStyleBackColor = true;
            this.btnCurso.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtLecciones
            // 
            this.txtLecciones.Location = new System.Drawing.Point(285, 194);
            this.txtLecciones.Name = "txtLecciones";
            this.txtLecciones.Size = new System.Drawing.Size(259, 23);
            this.txtLecciones.TabIndex = 46;
            // 
            // txtImparte
            // 
            this.txtImparte.Location = new System.Drawing.Point(285, 158);
            this.txtImparte.Name = "txtImparte";
            this.txtImparte.Size = new System.Drawing.Size(259, 23);
            this.txtImparte.TabIndex = 45;
            // 
            // txtNombreCurso
            // 
            this.txtNombreCurso.Location = new System.Drawing.Point(285, 119);
            this.txtNombreCurso.Name = "txtNombreCurso";
            this.txtNombreCurso.Size = new System.Drawing.Size(259, 23);
            this.txtNombreCurso.TabIndex = 44;
            this.txtNombreCurso.TextChanged += new System.EventHandler(this.textNombreCurso_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 23);
            this.label5.TabIndex = 42;
            this.label5.Text = "Descripcion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 23);
            this.label4.TabIndex = 41;
            this.label4.Text = "Num. lecciones";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 23);
            this.label3.TabIndex = 40;
            this.label3.Text = "Nombre del curso";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(12, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(253, 23);
            this.label7.TabIndex = 39;
            this.label7.Text = "Persona que lo imparte";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(106, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 23);
            this.label2.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(429, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 36);
            this.label1.TabIndex = 37;
            this.label1.Text = "Agregar Curso";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(275, 236);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(269, 63);
            this.txtDescripcion.TabIndex = 51;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreCurso,
            this.Imparte,
            this.NumLecciones,
            this.Descripcion});
            this.dataGridView2.Location = new System.Drawing.Point(570, 123);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(436, 176);
            this.dataGridView2.TabIndex = 52;
            // 
            // NombreCurso
            // 
            this.NombreCurso.HeaderText = "Nombre Curso";
            this.NombreCurso.Name = "NombreCurso";
            // 
            // Imparte
            // 
            this.Imparte.HeaderText = "Imparte";
            this.Imparte.Name = "Imparte";
            // 
            // NumLecciones
            // 
            this.NumLecciones.HeaderText = "Num Lecciones";
            this.NumLecciones.Name = "NumLecciones";
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            // 
            // btnActTabla
            // 
            this.btnActTabla.Location = new System.Drawing.Point(739, 317);
            this.btnActTabla.Name = "btnActTabla";
            this.btnActTabla.Size = new System.Drawing.Size(120, 23);
            this.btnActTabla.TabIndex = 53;
            this.btnActTabla.Text = "Actualizar tabla";
            this.btnActTabla.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(877, 39);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(120, 23);
            this.btnCerrar.TabIndex = 54;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // AgregarCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(1009, 358);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnActTabla);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.btnCurso);
            this.Controls.Add(this.txtLecciones);
            this.Controls.Add(this.txtImparte);
            this.Controls.Add(this.txtNombreCurso);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AgregarCurso";
            this.Text = "AgregarCurso";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCurso;
        private TextBox txtLecciones;
        private TextBox txtImparte;
        private TextBox txtNombreCurso;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label7;
        private Label label2;
        private Label label1;
        private TextBox txtDescripcion;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn NombreCurso;
        private DataGridViewTextBoxColumn Imparte;
        private DataGridViewTextBoxColumn NumLecciones;
        private DataGridViewTextBoxColumn Descripcion;
        private Button btnActTabla;
        private Button btnCerrar;
    }
}