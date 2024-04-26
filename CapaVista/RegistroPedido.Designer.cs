
namespace CapaVista
{
    partial class RegistroPedido
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
            this.txtTotalPedido = new System.Windows.Forms.TextBox();
            this.chkEstadoPedido = new System.Windows.Forms.CheckBox();
            this.txtClienteOnPedido = new System.Windows.Forms.TextBox();
            this.dtpFechaPedido = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardarPedido = new System.Windows.Forms.Button();
            this.btnCancelarPedido = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTotalPedido
            // 
            this.txtTotalPedido.Location = new System.Drawing.Point(390, 79);
            this.txtTotalPedido.Name = "txtTotalPedido";
            this.txtTotalPedido.Size = new System.Drawing.Size(90, 20);
            this.txtTotalPedido.TabIndex = 15;
            // 
            // chkEstadoPedido
            // 
            this.chkEstadoPedido.AutoSize = true;
            this.chkEstadoPedido.Location = new System.Drawing.Point(390, 32);
            this.chkEstadoPedido.Name = "chkEstadoPedido";
            this.chkEstadoPedido.Size = new System.Drawing.Size(15, 14);
            this.chkEstadoPedido.TabIndex = 14;
            this.chkEstadoPedido.UseVisualStyleBackColor = true;
            // 
            // txtClienteOnPedido
            // 
            this.txtClienteOnPedido.Location = new System.Drawing.Point(75, 27);
            this.txtClienteOnPedido.Name = "txtClienteOnPedido";
            this.txtClienteOnPedido.Size = new System.Drawing.Size(200, 20);
            this.txtClienteOnPedido.TabIndex = 13;
            // 
            // dtpFechaPedido
            // 
            this.dtpFechaPedido.Location = new System.Drawing.Point(75, 76);
            this.dtpFechaPedido.Name = "dtpFechaPedido";
            this.dtpFechaPedido.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaPedido.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(339, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Total:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(339, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Estado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Fecha:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cliente:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(608, 135);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(105, 35);
            this.btnCancelar.TabIndex = 25;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardarPedido
            // 
            this.btnGuardarPedido.Location = new System.Drawing.Point(12, 135);
            this.btnGuardarPedido.Name = "btnGuardarPedido";
            this.btnGuardarPedido.Size = new System.Drawing.Size(105, 35);
            this.btnGuardarPedido.TabIndex = 24;
            this.btnGuardarPedido.Text = "Guardar";
            this.btnGuardarPedido.UseVisualStyleBackColor = true;
            // 
            // btnCancelarPedido
            // 
            this.btnCancelarPedido.Location = new System.Drawing.Point(416, 135);
            this.btnCancelarPedido.Name = "btnCancelarPedido";
            this.btnCancelarPedido.Size = new System.Drawing.Size(105, 35);
            this.btnCancelarPedido.TabIndex = 26;
            this.btnCancelarPedido.Text = "Cancelar";
            this.btnCancelarPedido.UseVisualStyleBackColor = true;
            this.btnCancelarPedido.Click += new System.EventHandler(this.btnCancelarPedido_Click);
            // 
            // RegistroPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 182);
            this.Controls.Add(this.btnCancelarPedido);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardarPedido);
            this.Controls.Add(this.txtTotalPedido);
            this.Controls.Add(this.chkEstadoPedido);
            this.Controls.Add(this.txtClienteOnPedido);
            this.Controls.Add(this.dtpFechaPedido);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Name = "RegistroPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistroPedido";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTotalPedido;
        private System.Windows.Forms.CheckBox chkEstadoPedido;
        private System.Windows.Forms.TextBox txtClienteOnPedido;
        private System.Windows.Forms.DateTimePicker dtpFechaPedido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardarPedido;
        private System.Windows.Forms.Button btnCancelarPedido;
    }
}