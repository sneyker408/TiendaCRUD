
namespace CapaVista
{
    partial class RegistroInventario
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardarInventario = new System.Windows.Forms.Button();
            this.txtProductoOnInventario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCantidadStkInv = new System.Windows.Forms.TextBox();
            this.txtProveedorOnInventario = new System.Windows.Forms.TextBox();
            this.dtpUtmaFchaRpscn = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(534, 145);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(105, 35);
            this.btnCancelar.TabIndex = 36;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardarInventario
            // 
            this.btnGuardarInventario.Location = new System.Drawing.Point(12, 145);
            this.btnGuardarInventario.Name = "btnGuardarInventario";
            this.btnGuardarInventario.Size = new System.Drawing.Size(105, 35);
            this.btnGuardarInventario.TabIndex = 35;
            this.btnGuardarInventario.Text = "Guardar";
            this.btnGuardarInventario.UseVisualStyleBackColor = true;
            // 
            // txtProductoOnInventario
            // 
            this.txtProductoOnInventario.Location = new System.Drawing.Point(112, 28);
            this.txtProductoOnInventario.Name = "txtProductoOnInventario";
            this.txtProductoOnInventario.Size = new System.Drawing.Size(200, 20);
            this.txtProductoOnInventario.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(285, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Ultima fecha Reposición:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(351, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Proveedor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Cantidad en stock:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Producto:";
            // 
            // txtCantidadStkInv
            // 
            this.txtCantidadStkInv.Location = new System.Drawing.Point(112, 74);
            this.txtCantidadStkInv.Name = "txtCantidadStkInv";
            this.txtCantidadStkInv.Size = new System.Drawing.Size(90, 20);
            this.txtCantidadStkInv.TabIndex = 37;
            // 
            // txtProveedorOnInventario
            // 
            this.txtProveedorOnInventario.Location = new System.Drawing.Point(430, 28);
            this.txtProveedorOnInventario.Name = "txtProveedorOnInventario";
            this.txtProveedorOnInventario.Size = new System.Drawing.Size(200, 20);
            this.txtProveedorOnInventario.TabIndex = 38;
            // 
            // dtpUtmaFchaRpscn
            // 
            this.dtpUtmaFchaRpscn.Location = new System.Drawing.Point(430, 74);
            this.dtpUtmaFchaRpscn.Name = "dtpUtmaFchaRpscn";
            this.dtpUtmaFchaRpscn.Size = new System.Drawing.Size(200, 20);
            this.dtpUtmaFchaRpscn.TabIndex = 39;
            // 
            // RegistroInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 192);
            this.Controls.Add(this.dtpUtmaFchaRpscn);
            this.Controls.Add(this.txtProveedorOnInventario);
            this.Controls.Add(this.txtCantidadStkInv);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardarInventario);
            this.Controls.Add(this.txtProductoOnInventario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Name = "RegistroInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistroInventario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardarInventario;
        private System.Windows.Forms.TextBox txtProductoOnInventario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCantidadStkInv;
        private System.Windows.Forms.TextBox txtProveedorOnInventario;
        private System.Windows.Forms.DateTimePicker dtpUtmaFchaRpscn;
    }
}