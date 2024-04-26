
namespace CapaVista
{
    partial class MantenimientoCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenimientoCliente));
            this.BtnNuevoClie = new System.Windows.Forms.Button();
            this.BtnAtrasClie = new System.Windows.Forms.Button();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnNuevoClie
            // 
            this.BtnNuevoClie.BackColor = System.Drawing.Color.YellowGreen;
            this.BtnNuevoClie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNuevoClie.Location = new System.Drawing.Point(44, 474);
            this.BtnNuevoClie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnNuevoClie.Name = "BtnNuevoClie";
            this.BtnNuevoClie.Size = new System.Drawing.Size(156, 50);
            this.BtnNuevoClie.TabIndex = 8;
            this.BtnNuevoClie.Text = "Nuevo";
            this.BtnNuevoClie.UseVisualStyleBackColor = false;
            this.BtnNuevoClie.Click += new System.EventHandler(this.BtnNuevoClie_Click);
            // 
            // BtnAtrasClie
            // 
            this.BtnAtrasClie.BackColor = System.Drawing.Color.LightCoral;
            this.BtnAtrasClie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAtrasClie.Location = new System.Drawing.Point(868, 474);
            this.BtnAtrasClie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnAtrasClie.Name = "BtnAtrasClie";
            this.BtnAtrasClie.Size = new System.Drawing.Size(156, 50);
            this.BtnAtrasClie.TabIndex = 7;
            this.BtnAtrasClie.Text = "Atras";
            this.BtnAtrasClie.UseVisualStyleBackColor = false;
            this.BtnAtrasClie.Click += new System.EventHandler(this.BtnAtrasClie_Click);
            // 
            // dgvCliente
            // 
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(44, 58);
            this.dgvCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.RowHeadersWidth = 51;
            this.dgvCliente.Size = new System.Drawing.Size(980, 398);
            this.dgvCliente.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(47, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(635, 117);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro por Cliente";
            // 
            // MantenimientoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.BtnNuevoClie);
            this.Controls.Add(this.BtnAtrasClie);
            this.Controls.Add(this.dgvCliente);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MantenimientoCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vapesney | MantenimientoCliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnNuevoClie;
        private System.Windows.Forms.Button BtnAtrasClie;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}