namespace EjercicioMongoDB
{
    partial class Principal
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
            this.btnAggAlumno = new System.Windows.Forms.Button();
            this.btnAct = new System.Windows.Forms.Button();
            this.btnCurso = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAggAlumno
            // 
            this.btnAggAlumno.Location = new System.Drawing.Point(78, 89);
            this.btnAggAlumno.Name = "btnAggAlumno";
            this.btnAggAlumno.Size = new System.Drawing.Size(75, 44);
            this.btnAggAlumno.TabIndex = 0;
            this.btnAggAlumno.Text = "Agregar alumno";
            this.btnAggAlumno.UseVisualStyleBackColor = true;
            this.btnAggAlumno.Click += new System.EventHandler(this.btnAggAlumno_Click);
            // 
            // btnAct
            // 
            this.btnAct.Location = new System.Drawing.Point(78, 139);
            this.btnAct.Name = "btnAct";
            this.btnAct.Size = new System.Drawing.Size(75, 44);
            this.btnAct.TabIndex = 1;
            this.btnAct.Text = "Actualizar";
            this.btnAct.UseVisualStyleBackColor = true;
            this.btnAct.Click += new System.EventHandler(this.btnAct_Click);
            // 
            // btnCurso
            // 
            this.btnCurso.Location = new System.Drawing.Point(78, 189);
            this.btnCurso.Name = "btnCurso";
            this.btnCurso.Size = new System.Drawing.Size(75, 44);
            this.btnCurso.TabIndex = 2;
            this.btnCurso.Text = "Agregar Curso";
            this.btnCurso.UseVisualStyleBackColor = true;
            this.btnCurso.Click += new System.EventHandler(this.btnCurso_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(17, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 27);
            this.label1.TabIndex = 24;
            this.label1.Text = "Menu Principal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 15);
            this.label2.TabIndex = 25;
            this.label2.Text = "(No olvides primero llenar un curso)";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(212, 245);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCurso);
            this.Controls.Add(this.btnAct);
            this.Controls.Add(this.btnAggAlumno);
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.MinimizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAggAlumno;
        private Button btnAct;
        private Button btnCurso;
        private Label label1;
        private Label label2;
    }
}