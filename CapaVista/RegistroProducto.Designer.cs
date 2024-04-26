namespace CapaVista
{
    partial class RegistroProducto
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.txtStockDisponible = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFabricante = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightCoral;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Location = new System.Drawing.Point(545, 318);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(146, 51);
            this.btnCancelar.TabIndex = 24;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.YellowGreen;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Location = new System.Drawing.Point(12, 318);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(147, 51);
            this.btnGuardar.TabIndex = 23;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEstado.Location = new System.Drawing.Point(383, 250);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(65, 21);
            this.chkEstado.TabIndex = 22;
            this.chkEstado.Text = "Activo";
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // txtStockDisponible
            // 
            this.txtStockDisponible.Location = new System.Drawing.Point(139, 254);
            this.txtStockDisponible.Name = "txtStockDisponible";
            this.txtStockDisponible.Size = new System.Drawing.Size(50, 26);
            this.txtStockDisponible.TabIndex = 21;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(139, 197);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(93, 26);
            this.txtPrecio.TabIndex = 20;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(139, 64);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(555, 104);
            this.txtDescripcion.TabIndex = 19;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(140, 18);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(554, 26);
            this.txtNombre.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(290, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Estado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Stock Disponible:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Precio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Descripcion:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nombre Producto:";
            // 
            // txtFabricante
            // 
            this.txtFabricante.Location = new System.Drawing.Point(383, 192);
            this.txtFabricante.Name = "txtFabricante";
            this.txtFabricante.Size = new System.Drawing.Size(311, 26);
            this.txtFabricante.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(290, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "Fabricante";
            // 
            // RegistroProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 381);
            this.Controls.Add(this.txtFabricante);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.chkEstado);
            this.Controls.Add(this.txtStockDisponible);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "RegistroProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vapes | RegistroProducto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.CheckBox chkEstado;
        private System.Windows.Forms.TextBox txtStockDisponible;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFabricante;
        private System.Windows.Forms.Label label6;
    }
}