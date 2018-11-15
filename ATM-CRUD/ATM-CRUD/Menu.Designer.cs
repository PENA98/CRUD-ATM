namespace ATM_CRUD
{
    partial class Menu
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
            this.BtnCliente = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnConfiguracion = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnCuentaCliente = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnTarjetaCredito = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnServicioPublico = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnServicioCliente = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // BtnCliente
            // 
            this.BtnCliente.Depth = 0;
            this.BtnCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCliente.Location = new System.Drawing.Point(75, 146);
            this.BtnCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnCliente.Name = "BtnCliente";
            this.BtnCliente.Primary = true;
            this.BtnCliente.Size = new System.Drawing.Size(147, 46);
            this.BtnCliente.TabIndex = 0;
            this.BtnCliente.Text = "Cliente\r\n";
            this.BtnCliente.UseVisualStyleBackColor = true;
            this.BtnCliente.Click += new System.EventHandler(this.BtnCliente_Click);
            // 
            // BtnConfiguracion
            // 
            this.BtnConfiguracion.Depth = 0;
            this.BtnConfiguracion.Location = new System.Drawing.Point(319, 146);
            this.BtnConfiguracion.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnConfiguracion.Name = "BtnConfiguracion";
            this.BtnConfiguracion.Primary = true;
            this.BtnConfiguracion.Size = new System.Drawing.Size(147, 46);
            this.BtnConfiguracion.TabIndex = 1;
            this.BtnConfiguracion.Text = "Configuracion";
            this.BtnConfiguracion.UseVisualStyleBackColor = true;
            // 
            // BtnCuentaCliente
            // 
            this.BtnCuentaCliente.Depth = 0;
            this.BtnCuentaCliente.Location = new System.Drawing.Point(550, 146);
            this.BtnCuentaCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnCuentaCliente.Name = "BtnCuentaCliente";
            this.BtnCuentaCliente.Primary = true;
            this.BtnCuentaCliente.Size = new System.Drawing.Size(147, 46);
            this.BtnCuentaCliente.TabIndex = 2;
            this.BtnCuentaCliente.Text = "Cuenta cliente\r\n";
            this.BtnCuentaCliente.UseVisualStyleBackColor = true;
            // 
            // BtnTarjetaCredito
            // 
            this.BtnTarjetaCredito.Depth = 0;
            this.BtnTarjetaCredito.Location = new System.Drawing.Point(550, 296);
            this.BtnTarjetaCredito.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnTarjetaCredito.Name = "BtnTarjetaCredito";
            this.BtnTarjetaCredito.Primary = true;
            this.BtnTarjetaCredito.Size = new System.Drawing.Size(147, 46);
            this.BtnTarjetaCredito.TabIndex = 5;
            this.BtnTarjetaCredito.Text = "Tarjeta credito";
            this.BtnTarjetaCredito.UseVisualStyleBackColor = true;
            // 
            // BtnServicioPublico
            // 
            this.BtnServicioPublico.Depth = 0;
            this.BtnServicioPublico.Location = new System.Drawing.Point(319, 296);
            this.BtnServicioPublico.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnServicioPublico.Name = "BtnServicioPublico";
            this.BtnServicioPublico.Primary = true;
            this.BtnServicioPublico.Size = new System.Drawing.Size(147, 46);
            this.BtnServicioPublico.TabIndex = 4;
            this.BtnServicioPublico.Text = "Servicio publico";
            this.BtnServicioPublico.UseVisualStyleBackColor = true;
            // 
            // BtnServicioCliente
            // 
            this.BtnServicioCliente.Depth = 0;
            this.BtnServicioCliente.Location = new System.Drawing.Point(75, 296);
            this.BtnServicioCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnServicioCliente.Name = "BtnServicioCliente";
            this.BtnServicioCliente.Primary = true;
            this.BtnServicioCliente.Size = new System.Drawing.Size(147, 46);
            this.BtnServicioCliente.TabIndex = 3;
            this.BtnServicioCliente.Text = "Servicio cliente\r\n";
            this.BtnServicioCliente.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnTarjetaCredito);
            this.Controls.Add(this.BtnServicioPublico);
            this.Controls.Add(this.BtnServicioCliente);
            this.Controls.Add(this.BtnCuentaCliente);
            this.Controls.Add(this.BtnConfiguracion);
            this.Controls.Add(this.BtnCliente);
            this.Name = "Menu";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton BtnCliente;
        private MaterialSkin.Controls.MaterialRaisedButton BtnConfiguracion;
        private MaterialSkin.Controls.MaterialRaisedButton BtnCuentaCliente;
        private MaterialSkin.Controls.MaterialRaisedButton BtnTarjetaCredito;
        private MaterialSkin.Controls.MaterialRaisedButton BtnServicioPublico;
        private MaterialSkin.Controls.MaterialRaisedButton BtnServicioCliente;
    }
}

