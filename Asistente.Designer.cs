namespace ProyectoColegio
{
    partial class Asistente
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
            this.btnGenerarHorario = new System.Windows.Forms.Button();
            this.dtpInicioDeHorario = new System.Windows.Forms.DateTimePicker();
            this.dgvHorario = new System.Windows.Forms.DataGridView();
            this.labelPrueba = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerarHorario
            // 
            this.btnGenerarHorario.Location = new System.Drawing.Point(12, 8);
            this.btnGenerarHorario.Name = "btnGenerarHorario";
            this.btnGenerarHorario.Size = new System.Drawing.Size(334, 131);
            this.btnGenerarHorario.TabIndex = 0;
            this.btnGenerarHorario.Text = "button1";
            this.btnGenerarHorario.UseVisualStyleBackColor = true;
            this.btnGenerarHorario.Click += new System.EventHandler(this.btnGenerarHorario_Click);
            // 
            // dtpInicioDeHorario
            // 
            this.dtpInicioDeHorario.Location = new System.Drawing.Point(365, 12);
            this.dtpInicioDeHorario.Name = "dtpInicioDeHorario";
            this.dtpInicioDeHorario.Size = new System.Drawing.Size(187, 20);
            this.dtpInicioDeHorario.TabIndex = 1;
            // 
            // dgvHorario
            // 
            this.dgvHorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHorario.Location = new System.Drawing.Point(12, 160);
            this.dgvHorario.Name = "dgvHorario";
            this.dgvHorario.Size = new System.Drawing.Size(776, 278);
            this.dgvHorario.TabIndex = 2;
            // 
            // labelPrueba
            // 
            this.labelPrueba.AutoSize = true;
            this.labelPrueba.Location = new System.Drawing.Point(374, 67);
            this.labelPrueba.Name = "labelPrueba";
            this.labelPrueba.Size = new System.Drawing.Size(35, 13);
            this.labelPrueba.TabIndex = 3;
            this.labelPrueba.Text = "label1";
            // 
            // Asistente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelPrueba);
            this.Controls.Add(this.dgvHorario);
            this.Controls.Add(this.dtpInicioDeHorario);
            this.Controls.Add(this.btnGenerarHorario);
            this.Name = "Asistente";
            this.Text = "Asistente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerarHorario;
        private System.Windows.Forms.DateTimePicker dtpInicioDeHorario;
        private System.Windows.Forms.DataGridView dgvHorario;
        private System.Windows.Forms.Label labelPrueba;
    }
}