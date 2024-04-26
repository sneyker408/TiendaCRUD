
namespace CapaVista
{
    partial class RegistroCategoria
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
            this.btnCancelarCategoria = new System.Windows.Forms.Button();
            this.btnGuardarCategoria = new System.Windows.Forms.Button();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelarCategoria
            // 
            this.btnCancelarCategoria.Location = new System.Drawing.Point(357, 100);
            this.btnCancelarCategoria.Name = "btnCancelarCategoria";
            this.btnCancelarCategoria.Size = new System.Drawing.Size(105, 35);
            this.btnCancelarCategoria.TabIndex = 8;
            this.btnCancelarCategoria.Text = "Cancelar";
            this.btnCancelarCategoria.UseVisualStyleBackColor = true;
            this.btnCancelarCategoria.Click += new System.EventHandler(this.btnCancelarCategoria_Click);
            // 
            // btnGuardarCategoria
            // 
            this.btnGuardarCategoria.Location = new System.Drawing.Point(12, 100);
            this.btnGuardarCategoria.Name = "btnGuardarCategoria";
            this.btnGuardarCategoria.Size = new System.Drawing.Size(105, 35);
            this.btnGuardarCategoria.TabIndex = 7;
            this.btnGuardarCategoria.Text = "Guardar";
            this.btnGuardarCategoria.UseVisualStyleBackColor = true;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(178, 41);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(273, 20);
            this.txtCategoria.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre de la categoria:";
            // 
            // RegistroCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 147);
            this.Controls.Add(this.btnCancelarCategoria);
            this.Controls.Add(this.btnGuardarCategoria);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.label1);
            this.Name = "RegistroCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarCategoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelarCategoria;
        private System.Windows.Forms.Button btnGuardarCategoria;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Label label1;
    }
}