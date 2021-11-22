
namespace ProyectoColegio
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDirector = new System.Windows.Forms.Button();
            this.btnDocente = new System.Windows.Forms.Button();
            this.btnAsistente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDirector
            // 
            this.btnDirector.Location = new System.Drawing.Point(50, 140);
            this.btnDirector.Name = "btnDirector";
            this.btnDirector.Size = new System.Drawing.Size(193, 100);
            this.btnDirector.TabIndex = 0;
            this.btnDirector.Text = "Director";
            this.btnDirector.UseVisualStyleBackColor = true;
            // 
            // btnDocente
            // 
            this.btnDocente.Location = new System.Drawing.Point(271, 140);
            this.btnDocente.Name = "btnDocente";
            this.btnDocente.Size = new System.Drawing.Size(193, 100);
            this.btnDocente.TabIndex = 1;
            this.btnDocente.Text = "Docente";
            this.btnDocente.UseVisualStyleBackColor = true;
            // 
            // btnAsistente
            // 
            this.btnAsistente.Location = new System.Drawing.Point(498, 140);
            this.btnAsistente.Name = "btnAsistente";
            this.btnAsistente.Size = new System.Drawing.Size(193, 100);
            this.btnAsistente.TabIndex = 2;
            this.btnAsistente.Text = "Asistente";
            this.btnAsistente.UseVisualStyleBackColor = true;
            this.btnAsistente.Click += new System.EventHandler(this.btnAsistente_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAsistente);
            this.Controls.Add(this.btnDocente);
            this.Controls.Add(this.btnDirector);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDirector;
        private System.Windows.Forms.Button btnDocente;
        private System.Windows.Forms.Button btnAsistente;
    }
}

