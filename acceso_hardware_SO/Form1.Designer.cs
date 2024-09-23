namespace acceso_hardware_SO
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLeerNumeroSerieDisco = new System.Windows.Forms.Button();
            this.btnContarUnidadesDisco = new System.Windows.Forms.Button();
            this.btnObtenerInventario = new System.Windows.Forms.Button();
            this.btnObtenerMacAddress = new System.Windows.Forms.Button();
            this.btnAccesoRegistro = new System.Windows.Forms.Button();
            this.btnObtenerProcesosActivos = new System.Windows.Forms.Button();
            this.btnMatarProceso = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLeerNumeroSerieDisco
            // 
            this.btnLeerNumeroSerieDisco.Location = new System.Drawing.Point(77, 294);
            this.btnLeerNumeroSerieDisco.Name = "btnLeerNumeroSerieDisco";
            this.btnLeerNumeroSerieDisco.Size = new System.Drawing.Size(171, 23);
            this.btnLeerNumeroSerieDisco.TabIndex = 0;
            this.btnLeerNumeroSerieDisco.Text = "LEER #SERIE D";
            this.btnLeerNumeroSerieDisco.UseVisualStyleBackColor = true;
            this.btnLeerNumeroSerieDisco.Click += new System.EventHandler(this.btnLeerNumeroSerieDisco_Click);
            // 
            // btnContarUnidadesDisco
            // 
            this.btnContarUnidadesDisco.Location = new System.Drawing.Point(278, 294);
            this.btnContarUnidadesDisco.Name = "btnContarUnidadesDisco";
            this.btnContarUnidadesDisco.Size = new System.Drawing.Size(242, 23);
            this.btnContarUnidadesDisco.TabIndex = 1;
            this.btnContarUnidadesDisco.Text = "CONTAR UNIDADES";
            this.btnContarUnidadesDisco.UseVisualStyleBackColor = true;
            this.btnContarUnidadesDisco.Click += new System.EventHandler(this.btnContarUnidadesDisco_Click);
            // 
            // btnObtenerInventario
            // 
            this.btnObtenerInventario.Location = new System.Drawing.Point(562, 294);
            this.btnObtenerInventario.Name = "btnObtenerInventario";
            this.btnObtenerInventario.Size = new System.Drawing.Size(156, 23);
            this.btnObtenerInventario.TabIndex = 2;
            this.btnObtenerInventario.Text = "INVENTARIO";
            this.btnObtenerInventario.UseVisualStyleBackColor = true;
            this.btnObtenerInventario.Click += new System.EventHandler(this.btnObtenerInventario_Click);
            // 
            // btnObtenerMacAddress
            // 
            this.btnObtenerMacAddress.Location = new System.Drawing.Point(173, 343);
            this.btnObtenerMacAddress.Name = "btnObtenerMacAddress";
            this.btnObtenerMacAddress.Size = new System.Drawing.Size(75, 23);
            this.btnObtenerMacAddress.TabIndex = 3;
            this.btnObtenerMacAddress.Text = "MAC ADRESS";
            this.btnObtenerMacAddress.UseVisualStyleBackColor = true;
            this.btnObtenerMacAddress.Click += new System.EventHandler(this.btnObtenerMacAddress_Click);
            // 
            // btnAccesoRegistro
            // 
            this.btnAccesoRegistro.Location = new System.Drawing.Point(328, 343);
            this.btnAccesoRegistro.Name = "btnAccesoRegistro";
            this.btnAccesoRegistro.Size = new System.Drawing.Size(132, 23);
            this.btnAccesoRegistro.TabIndex = 4;
            this.btnAccesoRegistro.Text = "AccesoRegistro";
            this.btnAccesoRegistro.UseVisualStyleBackColor = true;
            this.btnAccesoRegistro.Click += new System.EventHandler(this.btnAccesoRegistro_Click);
            // 
            // btnObtenerProcesosActivos
            // 
            this.btnObtenerProcesosActivos.Location = new System.Drawing.Point(519, 343);
            this.btnObtenerProcesosActivos.Name = "btnObtenerProcesosActivos";
            this.btnObtenerProcesosActivos.Size = new System.Drawing.Size(172, 23);
            this.btnObtenerProcesosActivos.TabIndex = 5;
            this.btnObtenerProcesosActivos.Text = "PROCESOS ACTIVOS";
            this.btnObtenerProcesosActivos.UseVisualStyleBackColor = true;
            this.btnObtenerProcesosActivos.Click += new System.EventHandler(this.btnObtenerProcesosActivos_Click);
            // 
            // btnMatarProceso
            // 
            this.btnMatarProceso.Location = new System.Drawing.Point(327, 400);
            this.btnMatarProceso.Name = "btnMatarProceso";
            this.btnMatarProceso.Size = new System.Drawing.Size(133, 23);
            this.btnMatarProceso.TabIndex = 6;
            this.btnMatarProceso.Text = "MatarProceso";
            this.btnMatarProceso.UseVisualStyleBackColor = true;
            this.btnMatarProceso.Click += new System.EventHandler(this.btnMatarProceso_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(77, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(641, 289);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.Click += new System.EventHandler(this.btnObtenerProcesosActivos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnMatarProceso);
            this.Controls.Add(this.btnObtenerProcesosActivos);
            this.Controls.Add(this.btnAccesoRegistro);
            this.Controls.Add(this.btnObtenerMacAddress);
            this.Controls.Add(this.btnObtenerInventario);
            this.Controls.Add(this.btnContarUnidadesDisco);
            this.Controls.Add(this.btnLeerNumeroSerieDisco);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLeerNumeroSerieDisco;
        private System.Windows.Forms.Button btnContarUnidadesDisco;
        private System.Windows.Forms.Button btnObtenerInventario;
        private System.Windows.Forms.Button btnObtenerMacAddress;
        private System.Windows.Forms.Button btnAccesoRegistro;
        private System.Windows.Forms.Button btnObtenerProcesosActivos;
        private System.Windows.Forms.Button btnMatarProceso;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

