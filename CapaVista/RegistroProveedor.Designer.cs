
namespace CapaVista
{
    partial class RegistroProveedor
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
            this.btnGuardarProveedor = new System.Windows.Forms.Button();
            this.txtDireccionProveedor = new System.Windows.Forms.TextBox();
            this.TxtTelefonoProveedor = new System.Windows.Forms.TextBox();
            this.txtCorreoProveedor = new System.Windows.Forms.TextBox();
            this.txtNombreProveedor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(604, 293);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(105, 35);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardarProveedor
            // 
            this.btnGuardarProveedor.Location = new System.Drawing.Point(8, 293);
            this.btnGuardarProveedor.Name = "btnGuardarProveedor";
            this.btnGuardarProveedor.Size = new System.Drawing.Size(105, 35);
            this.btnGuardarProveedor.TabIndex = 22;
            this.btnGuardarProveedor.Text = "Guardar";
            this.btnGuardarProveedor.UseVisualStyleBackColor = true;
            // 
            // txtDireccionProveedor
            // 
            this.txtDireccionProveedor.Location = new System.Drawing.Point(112, 157);
            this.txtDireccionProveedor.Multiline = true;
            this.txtDireccionProveedor.Name = "txtDireccionProveedor";
            this.txtDireccionProveedor.Size = new System.Drawing.Size(573, 53);
            this.txtDireccionProveedor.TabIndex = 21;
            // 
            // TxtTelefonoProveedor
            // 
            this.TxtTelefonoProveedor.Location = new System.Drawing.Point(112, 92);
            this.TxtTelefonoProveedor.Name = "TxtTelefonoProveedor";
            this.TxtTelefonoProveedor.Size = new System.Drawing.Size(125, 20);
            this.TxtTelefonoProveedor.TabIndex = 20;
            // 
            // txtCorreoProveedor
            // 
            this.txtCorreoProveedor.Location = new System.Drawing.Point(436, 32);
            this.txtCorreoProveedor.Name = "txtCorreoProveedor";
            this.txtCorreoProveedor.Size = new System.Drawing.Size(241, 20);
            this.txtCorreoProveedor.TabIndex = 19;
            // 
            // txtNombreProveedor
            // 
            this.txtNombreProveedor.Location = new System.Drawing.Point(112, 32);
            this.txtNombreProveedor.Name = "txtNombreProveedor";
            this.txtNombreProveedor.Size = new System.Drawing.Size(217, 20);
            this.txtNombreProveedor.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Teléfono:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(373, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Correo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Dirección:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nombre:";
            // 
            // RegistroProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 338);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardarProveedor);
            this.Controls.Add(this.txtDireccionProveedor);
            this.Controls.Add(this.TxtTelefonoProveedor);
            this.Controls.Add(this.txtCorreoProveedor);
            this.Controls.Add(this.txtNombreProveedor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "RegistroProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistroProveedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardarProveedor;
        private System.Windows.Forms.TextBox txtDireccionProveedor;
        private System.Windows.Forms.TextBox TxtTelefonoProveedor;
        private System.Windows.Forms.TextBox txtCorreoProveedor;
        private System.Windows.Forms.TextBox txtNombreProveedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}