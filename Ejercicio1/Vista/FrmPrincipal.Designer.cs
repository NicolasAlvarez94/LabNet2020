namespace Vista
{
    partial class FrmPrincipal
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
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvDatosTransportes = new System.Windows.Forms.DataGridView();
            this.btnOperaciones = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosTransportes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMostrar.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnMostrar.Location = new System.Drawing.Point(35, 76);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(180, 36);
            this.btnMostrar.TabIndex = 1;
            this.btnMostrar.Text = "MOSTRAR TRANSPORTES";
            this.btnMostrar.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSalir.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnSalir.Location = new System.Drawing.Point(594, 382);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(180, 36);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblTitulo.Location = new System.Drawing.Point(32, 24);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(188, 18);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "LISTA DE TRANSPORTES";
            // 
            // dgvDatosTransportes
            // 
            this.dgvDatosTransportes.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvDatosTransportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosTransportes.Location = new System.Drawing.Point(35, 148);
            this.dgvDatosTransportes.Name = "dgvDatosTransportes";
            this.dgvDatosTransportes.Size = new System.Drawing.Size(465, 197);
            this.dgvDatosTransportes.TabIndex = 5;
            // 
            // btnOperaciones
            // 
            this.btnOperaciones.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOperaciones.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnOperaciones.Location = new System.Drawing.Point(320, 76);
            this.btnOperaciones.Name = "btnOperaciones";
            this.btnOperaciones.Size = new System.Drawing.Size(180, 36);
            this.btnOperaciones.TabIndex = 6;
            this.btnOperaciones.Text = "VER OPERACIONES";
            this.btnOperaciones.UseVisualStyleBackColor = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOperaciones);
            this.Controls.Add(this.dgvDatosTransportes);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnMostrar);
            this.Name = "FrmPrincipal";
            this.Text = "TRANSPORTES";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosTransportes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvDatosTransportes;
        private System.Windows.Forms.Button btnOperaciones;
    }
}