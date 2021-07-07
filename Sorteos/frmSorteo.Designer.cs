namespace Sorteos
{
    partial class frmSorteo
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSorteo = new System.Windows.Forms.Button();
            this.lblNumGanador = new System.Windows.Forms.Label();
            this.lblGanador = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.txtHasta = new System.Windows.Forms.TextBox();
            this.txtDesde = new System.Windows.Forms.TextBox();
            this.lstNumSorteados = new System.Windows.Forms.ListBox();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSorteo
            // 
            this.btnSorteo.Location = new System.Drawing.Point(120, 223);
            this.btnSorteo.Name = "btnSorteo";
            this.btnSorteo.Size = new System.Drawing.Size(121, 42);
            this.btnSorteo.TabIndex = 13;
            this.btnSorteo.Text = "SORTEO";
            this.btnSorteo.UseVisualStyleBackColor = true;
            this.btnSorteo.Click += new System.EventHandler(this.btnSorteo_Click);
            // 
            // lblNumGanador
            // 
            this.lblNumGanador.AutoSize = true;
            this.lblNumGanador.Location = new System.Drawing.Point(161, 89);
            this.lblNumGanador.Name = "lblNumGanador";
            this.lblNumGanador.Size = new System.Drawing.Size(0, 13);
            this.lblNumGanador.TabIndex = 12;
            // 
            // lblGanador
            // 
            this.lblGanador.AutoSize = true;
            this.lblGanador.Location = new System.Drawing.Point(140, 61);
            this.lblGanador.Name = "lblGanador";
            this.lblGanador.Size = new System.Drawing.Size(61, 13);
            this.lblGanador.TabIndex = 11;
            this.lblGanador.Text = "GANADOR";
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(193, 140);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(35, 13);
            this.lblHasta.TabIndex = 10;
            this.lblHasta.Text = "Hasta";
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(63, 141);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(38, 13);
            this.lblDesde.TabIndex = 9;
            this.lblDesde.Text = "Desde";
            // 
            // txtHasta
            // 
            this.txtHasta.Location = new System.Drawing.Point(193, 160);
            this.txtHasta.MaxLength = 5;
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.Size = new System.Drawing.Size(100, 20);
            this.txtHasta.TabIndex = 8;
            this.txtHasta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHasta_KeyPress);
            // 
            // txtDesde
            // 
            this.txtDesde.Location = new System.Drawing.Point(63, 160);
            this.txtDesde.MaxLength = 5;
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(100, 20);
            this.txtDesde.TabIndex = 7;
            this.txtDesde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDesde_KeyPress);
            // 
            // lstNumSorteados
            // 
            this.lstNumSorteados.FormattingEnabled = true;
            this.lstNumSorteados.Location = new System.Drawing.Point(362, 3);
            this.lstNumSorteados.Name = "lstNumSorteados";
            this.lstNumSorteados.Size = new System.Drawing.Size(120, 368);
            this.lstNumSorteados.TabIndex = 14;
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Location = new System.Drawing.Point(143, 292);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(75, 23);
            this.btnReiniciar.TabIndex = 15;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // frmSorteo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 379);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.lstNumSorteados);
            this.Controls.Add(this.btnSorteo);
            this.Controls.Add(this.lblNumGanador);
            this.Controls.Add(this.lblGanador);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.lblDesde);
            this.Controls.Add(this.txtHasta);
            this.Controls.Add(this.txtDesde);
            this.Name = "frmSorteo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sorteo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSorteo;
        private System.Windows.Forms.Label lblNumGanador;
        private System.Windows.Forms.Label lblGanador;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.TextBox txtHasta;
        private System.Windows.Forms.TextBox txtDesde;
        private System.Windows.Forms.ListBox lstNumSorteados;
        private System.Windows.Forms.Button btnReiniciar;
    }
}

