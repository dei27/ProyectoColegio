
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
            this.button1 = new System.Windows.Forms.Button();
            this.dgvAulas = new System.Windows.Forms.DataGridView();
            this.dtpFechaInicioHorario = new System.Windows.Forms.DateTimePicker();
            this.labelPrueba = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAulas)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(112, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 89);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvAulas
            // 
            this.dgvAulas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAulas.Location = new System.Drawing.Point(84, 193);
            this.dgvAulas.Name = "dgvAulas";
            this.dgvAulas.Size = new System.Drawing.Size(546, 172);
            this.dgvAulas.TabIndex = 1;
            // 
            // dtpFechaInicioHorario
            // 
            this.dtpFechaInicioHorario.Location = new System.Drawing.Point(399, 71);
            this.dtpFechaInicioHorario.Name = "dtpFechaInicioHorario";
            this.dtpFechaInicioHorario.Size = new System.Drawing.Size(231, 20);
            this.dtpFechaInicioHorario.TabIndex = 2;
            this.dtpFechaInicioHorario.Value = new System.DateTime(2021, 11, 29, 0, 0, 0, 0);
            // 
            // labelPrueba
            // 
            this.labelPrueba.AutoSize = true;
            this.labelPrueba.Location = new System.Drawing.Point(402, 116);
            this.labelPrueba.Name = "labelPrueba";
            this.labelPrueba.Size = new System.Drawing.Size(35, 13);
            this.labelPrueba.TabIndex = 3;
            this.labelPrueba.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelPrueba);
            this.Controls.Add(this.dtpFechaInicioHorario);
            this.Controls.Add(this.dgvAulas);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAulas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvAulas;
        private System.Windows.Forms.DateTimePicker dtpFechaInicioHorario;
        private System.Windows.Forms.Label labelPrueba;
    }
}

