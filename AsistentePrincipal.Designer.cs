namespace ProyectoColegio
{
    partial class AsistentePrincipal
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
            this.btnAdmiDocentes = new System.Windows.Forms.Button();
            this.btnEncargados = new System.Windows.Forms.Button();
            this.btnSecciones = new System.Windows.Forms.Button();
            this.btnHorarioGenerar = new System.Windows.Forms.Button();
            this.btnAdmiEstudiantes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdmiDocentes
            // 
            this.btnAdmiDocentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmiDocentes.Location = new System.Drawing.Point(26, 56);
            this.btnAdmiDocentes.Name = "btnAdmiDocentes";
            this.btnAdmiDocentes.Size = new System.Drawing.Size(345, 124);
            this.btnAdmiDocentes.TabIndex = 0;
            this.btnAdmiDocentes.Text = "Administrar Docentes";
            this.btnAdmiDocentes.UseVisualStyleBackColor = true;
            this.btnAdmiDocentes.Click += new System.EventHandler(this.btnAdmiDocentes_Click);
            // 
            // btnEncargados
            // 
            this.btnEncargados.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncargados.Location = new System.Drawing.Point(26, 339);
            this.btnEncargados.Name = "btnEncargados";
            this.btnEncargados.Size = new System.Drawing.Size(345, 124);
            this.btnEncargados.TabIndex = 1;
            this.btnEncargados.Text = "Administrar encargados";
            this.btnEncargados.UseVisualStyleBackColor = true;
            this.btnEncargados.Click += new System.EventHandler(this.btnEncargados_Click);
            // 
            // btnSecciones
            // 
            this.btnSecciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSecciones.Location = new System.Drawing.Point(434, 56);
            this.btnSecciones.Name = "btnSecciones";
            this.btnSecciones.Size = new System.Drawing.Size(345, 124);
            this.btnSecciones.TabIndex = 2;
            this.btnSecciones.Text = "Administrar Secciones";
            this.btnSecciones.UseVisualStyleBackColor = true;
            this.btnSecciones.Click += new System.EventHandler(this.btnSecciones_Click);
            // 
            // btnHorarioGenerar
            // 
            this.btnHorarioGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHorarioGenerar.Location = new System.Drawing.Point(434, 195);
            this.btnHorarioGenerar.Name = "btnHorarioGenerar";
            this.btnHorarioGenerar.Size = new System.Drawing.Size(345, 124);
            this.btnHorarioGenerar.TabIndex = 3;
            this.btnHorarioGenerar.Text = "Generar horario";
            this.btnHorarioGenerar.UseVisualStyleBackColor = true;
            this.btnHorarioGenerar.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnAdmiEstudiantes
            // 
            this.btnAdmiEstudiantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmiEstudiantes.Location = new System.Drawing.Point(26, 195);
            this.btnAdmiEstudiantes.Name = "btnAdmiEstudiantes";
            this.btnAdmiEstudiantes.Size = new System.Drawing.Size(345, 124);
            this.btnAdmiEstudiantes.TabIndex = 4;
            this.btnAdmiEstudiantes.Text = "Administrar estudiantes";
            this.btnAdmiEstudiantes.UseVisualStyleBackColor = true;
            this.btnAdmiEstudiantes.Click += new System.EventHandler(this.btnAdmiEstudiantes_Click);
            // 
            // AsistentePrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 490);
            this.Controls.Add(this.btnAdmiEstudiantes);
            this.Controls.Add(this.btnHorarioGenerar);
            this.Controls.Add(this.btnSecciones);
            this.Controls.Add(this.btnEncargados);
            this.Controls.Add(this.btnAdmiDocentes);
            this.Name = "AsistentePrincipal";
            this.Text = "AsistentePrincipal";
            this.Load += new System.EventHandler(this.AsistentePrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdmiDocentes;
        private System.Windows.Forms.Button btnEncargados;
        private System.Windows.Forms.Button btnSecciones;
        private System.Windows.Forms.Button btnHorarioGenerar;
        private System.Windows.Forms.Button btnAdmiEstudiantes;
    }
}