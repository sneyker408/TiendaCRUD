
namespace CapaVista
{
    partial class RegistroCliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtApellidoCliente = new System.Windows.Forms.TextBox();
            this.TxtTelefonoCliente = new System.Windows.Forms.TextBox();
            this.txtCorreoCliente = new System.Windows.Forms.TextBox();
            this.txtDireccionCliente = new System.Windows.Forms.TextBox();
            this.btnCancelarCliente = new System.Windows.Forms.Button();
            this.btnGuardarCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dirección:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(377, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Teléfono:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(377, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Correo:";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(116, 41);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(217, 20);
            this.txtNombreCliente.TabIndex = 5;
            // 
            // txtApellidoCliente
            // 
            this.txtApellidoCliente.Location = new System.Drawing.Point(116, 99);
            this.txtApellidoCliente.Name = "txtApellidoCliente";
            this.txtApellidoCliente.Size = new System.Drawing.Size(217, 20);
            this.txtApellidoCliente.TabIndex = 6;
            // 
            // TxtTelefonoCliente
            // 
            this.TxtTelefonoCliente.Location = new System.Drawing.Point(440, 99);
            this.TxtTelefonoCliente.Name = "TxtTelefonoCliente";
            this.TxtTelefonoCliente.Size = new System.Drawing.Size(125, 20);
            this.TxtTelefonoCliente.TabIndex = 8;
            // 
            // txtCorreoCliente
            // 
            this.txtCorreoCliente.Location = new System.Drawing.Point(440, 41);
            this.txtCorreoCliente.Name = "txtCorreoCliente";
            this.txtCorreoCliente.Size = new System.Drawing.Size(241, 20);
            this.txtCorreoCliente.TabIndex = 7;
            // 
            // txtDireccionCliente
            // 
            this.txtDireccionCliente.Location = new System.Drawing.Point(116, 172);
            this.txtDireccionCliente.Multiline = true;
            this.txtDireccionCliente.Name = "txtDireccionCliente";
            this.txtDireccionCliente.Size = new System.Drawing.Size(565, 85);
            this.txtDireccionCliente.TabIndex = 9;
            // 
            // btnCancelarCliente
            // 
            this.btnCancelarCliente.Location = new System.Drawing.Point(608, 302);
            this.btnCancelarCliente.Name = "btnCancelarCliente";
            this.btnCancelarCliente.Size = new System.Drawing.Size(105, 35);
            this.btnCancelarCliente.TabIndex = 11;
            this.btnCancelarCliente.Text = "Cancelar";
            this.btnCancelarCliente.UseVisualStyleBackColor = true;
            this.btnCancelarCliente.Click += new System.EventHandler(this.btnCancelarCliente_Click);
            // 
            // btnGuardarCliente
            // 
            this.btnGuardarCliente.Location = new System.Drawing.Point(12, 302);
            this.btnGuardarCliente.Name = "btnGuardarCliente";
            this.btnGuardarCliente.Size = new System.Drawing.Size(105, 35);
            this.btnGuardarCliente.TabIndex = 10;
            this.btnGuardarCliente.Text = "Guardar";
            this.btnGuardarCliente.UseVisualStyleBackColor = true;
            // 
            // RegistroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 349);
            this.Controls.Add(this.btnCancelarCliente);
            this.Controls.Add(this.btnGuardarCliente);
            this.Controls.Add(this.txtDireccionCliente);
            this.Controls.Add(this.TxtTelefonoCliente);
            this.Controls.Add(this.txtCorreoCliente);
            this.Controls.Add(this.txtApellidoCliente);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegistroCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistroCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtApellidoCliente;
        private System.Windows.Forms.TextBox TxtTelefonoCliente;
        private System.Windows.Forms.TextBox txtCorreoCliente;
        private System.Windows.Forms.TextBox txtDireccionCliente;
        private System.Windows.Forms.Button btnCancelarCliente;
        private System.Windows.Forms.Button btnGuardarCliente;
    }
}