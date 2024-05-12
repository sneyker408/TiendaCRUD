namespace CapaVista
{
    partial class RegistroFabricante
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroFabricante));
            this.chkEstadoFabri = new System.Windows.Forms.CheckBox();
            this.FabricanteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelarFabri = new System.Windows.Forms.Button();
            this.btnGuardarFabri = new System.Windows.Forms.Button();
            this.txtFabricante = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FabricanteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chkEstadoFabri
            // 
            this.chkEstadoFabri.AutoSize = true;
            this.chkEstadoFabri.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.FabricanteBindingSource, "Estado", true));
            this.chkEstadoFabri.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEstadoFabri.Location = new System.Drawing.Point(232, 84);
            this.chkEstadoFabri.Name = "chkEstadoFabri";
            this.chkEstadoFabri.Size = new System.Drawing.Size(66, 20);
            this.chkEstadoFabri.TabIndex = 29;
            this.chkEstadoFabri.Text = "Activo";
            this.chkEstadoFabri.UseVisualStyleBackColor = true;
            // 
            // FabricanteBindingSource
            // 
            this.FabricanteBindingSource.DataSource = typeof(CapaEntidades.Fabricante);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "Estado:";
            // 
            // btnCancelarFabri
            // 
            this.btnCancelarFabri.Location = new System.Drawing.Point(474, 136);
            this.btnCancelarFabri.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelarFabri.Name = "btnCancelarFabri";
            this.btnCancelarFabri.Size = new System.Drawing.Size(140, 43);
            this.btnCancelarFabri.TabIndex = 27;
            this.btnCancelarFabri.Text = "Cancelar";
            this.btnCancelarFabri.UseVisualStyleBackColor = true;
            this.btnCancelarFabri.Click += new System.EventHandler(this.btnCancelarFabri_Click);
            // 
            // btnGuardarFabri
            // 
            this.btnGuardarFabri.Location = new System.Drawing.Point(14, 136);
            this.btnGuardarFabri.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarFabri.Name = "btnGuardarFabri";
            this.btnGuardarFabri.Size = new System.Drawing.Size(140, 43);
            this.btnGuardarFabri.TabIndex = 26;
            this.btnGuardarFabri.Text = "Guardar";
            this.btnGuardarFabri.UseVisualStyleBackColor = true;
            this.btnGuardarFabri.Click += new System.EventHandler(this.btnGuardarFabri_Click);
            // 
            // txtFabricante
            // 
            this.txtFabricante.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFabricante.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.FabricanteBindingSource, "NombreFabricante", true));
            this.txtFabricante.Location = new System.Drawing.Point(232, 20);
            this.txtFabricante.Margin = new System.Windows.Forms.Padding(4);
            this.txtFabricante.Name = "txtFabricante";
            this.txtFabricante.Size = new System.Drawing.Size(363, 22);
            this.txtFabricante.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Nombre del Fabricante";
            // 
            // RegistroFabricante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 207);
            this.Controls.Add(this.chkEstadoFabri);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancelarFabri);
            this.Controls.Add(this.btnGuardarFabri);
            this.Controls.Add(this.txtFabricante);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistroFabricante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vapesney | RegistroFabricante";
            ((System.ComponentModel.ISupportInitialize)(this.FabricanteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource FabricanteBindingSource;
        private System.Windows.Forms.CheckBox chkEstadoFabri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelarFabri;
        private System.Windows.Forms.Button btnGuardarFabri;
        private System.Windows.Forms.TextBox txtFabricante;
        private System.Windows.Forms.Label label1;
    }
}