namespace Vista
{
    partial class FrmMostrarOperaciones
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
            this.lblTransporte = new System.Windows.Forms.Label();
            this.lblAccionA = new System.Windows.Forms.Label();
            this.lblAccionB = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTransporte
            // 
            this.lblTransporte.AutoSize = true;
            this.lblTransporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransporte.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTransporte.Location = new System.Drawing.Point(12, 73);
            this.lblTransporte.Name = "lblTransporte";
            this.lblTransporte.Size = new System.Drawing.Size(51, 20);
            this.lblTransporte.TabIndex = 0;
            this.lblTransporte.Text = "label1";
            // 
            // lblAccionA
            // 
            this.lblAccionA.AutoSize = true;
            this.lblAccionA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccionA.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAccionA.Location = new System.Drawing.Point(12, 126);
            this.lblAccionA.Name = "lblAccionA";
            this.lblAccionA.Size = new System.Drawing.Size(51, 20);
            this.lblAccionA.TabIndex = 1;
            this.lblAccionA.Text = "label2";
            // 
            // lblAccionB
            // 
            this.lblAccionB.AutoSize = true;
            this.lblAccionB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccionB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAccionB.Location = new System.Drawing.Point(12, 181);
            this.lblAccionB.Name = "lblAccionB";
            this.lblAccionB.Size = new System.Drawing.Size(51, 20);
            this.lblAccionB.TabIndex = 2;
            this.lblAccionB.Text = "label3";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCerrar.Location = new System.Drawing.Point(417, 283);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(184, 39);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "CERRAR";
            this.btnCerrar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(124, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "CARACTERISTICAS Y COMPORTAMIENTOS";
            // 
            // FrmMostrarOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(621, 343);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblAccionB);
            this.Controls.Add(this.lblAccionA);
            this.Controls.Add(this.lblTransporte);
            this.Name = "FrmMostrarOperaciones";
            this.Text = "OPERACIONES";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTransporte;
        private System.Windows.Forms.Label lblAccionA;
        private System.Windows.Forms.Label lblAccionB;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label1;
    }
}