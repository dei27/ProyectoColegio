namespace ProyectoColegio
{
    partial class formAdmiDocentes
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
            this.dgvDocentes = new System.Windows.Forms.DataGridView();
            this.btnBusquedaDocente = new System.Windows.Forms.Button();
            this.txtBusquedaDocente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminarDocente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocentes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDocentes
            // 
            this.dgvDocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocentes.Location = new System.Drawing.Point(12, 92);
            this.dgvDocentes.Name = "dgvDocentes";
            this.dgvDocentes.Size = new System.Drawing.Size(776, 346);
            this.dgvDocentes.TabIndex = 0;
            // 
            // btnBusquedaDocente
            // 
            this.btnBusquedaDocente.Location = new System.Drawing.Point(509, 28);
            this.btnBusquedaDocente.Name = "btnBusquedaDocente";
            this.btnBusquedaDocente.Size = new System.Drawing.Size(123, 47);
            this.btnBusquedaDocente.TabIndex = 1;
            this.btnBusquedaDocente.Text = "Buscar docente";
            this.btnBusquedaDocente.UseVisualStyleBackColor = true;
            this.btnBusquedaDocente.Click += new System.EventHandler(this.btnBusquedaDocente_Click);
            // 
            // txtBusquedaDocente
            // 
            this.txtBusquedaDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusquedaDocente.Location = new System.Drawing.Point(12, 37);
            this.txtBusquedaDocente.Name = "txtBusquedaDocente";
            this.txtBusquedaDocente.Size = new System.Drawing.Size(480, 38);
            this.txtBusquedaDocente.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingrese el numero de cedula";
            // 
            // btnEliminarDocente
            // 
            this.btnEliminarDocente.Enabled = false;
            this.btnEliminarDocente.Location = new System.Drawing.Point(650, 28);
            this.btnEliminarDocente.Name = "btnEliminarDocente";
            this.btnEliminarDocente.Size = new System.Drawing.Size(120, 47);
            this.btnEliminarDocente.TabIndex = 5;
            this.btnEliminarDocente.Text = "Eliminar";
            this.btnEliminarDocente.UseVisualStyleBackColor = true;
            this.btnEliminarDocente.Click += new System.EventHandler(this.btnEliminarDocente_Click);
            // 
            // formAdmiDocentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEliminarDocente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBusquedaDocente);
            this.Controls.Add(this.btnBusquedaDocente);
            this.Controls.Add(this.dgvDocentes);
            this.Name = "formAdmiDocentes";
            this.Text = "formAdmiDocentes";
            this.Load += new System.EventHandler(this.formAdmiDocentes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocentes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDocentes;
        private System.Windows.Forms.Button btnBusquedaDocente;
        private System.Windows.Forms.TextBox txtBusquedaDocente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminarDocente;
    }
}