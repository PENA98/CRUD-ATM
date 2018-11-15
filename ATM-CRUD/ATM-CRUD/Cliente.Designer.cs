namespace ATM_CRUD
{
    partial class Cliente
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
            this.NombreTxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.ApellidosTxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.IdentidadTxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.DireccionTxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.TelefonoTxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.CelularTxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.DgvCliente = new System.Windows.Forms.DataGridView();
            this.BtnCrear = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnListar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnActualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnEliminar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnCancelar = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // NombreTxt
            // 
            this.NombreTxt.Depth = 0;
            this.NombreTxt.Hint = "";
            this.NombreTxt.Location = new System.Drawing.Point(136, 81);
            this.NombreTxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.NombreTxt.Name = "NombreTxt";
            this.NombreTxt.PasswordChar = '\0';
            this.NombreTxt.SelectedText = "";
            this.NombreTxt.SelectionLength = 0;
            this.NombreTxt.SelectionStart = 0;
            this.NombreTxt.Size = new System.Drawing.Size(153, 23);
            this.NombreTxt.TabIndex = 0;
            this.NombreTxt.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(25, 85);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(71, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Nombres";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(25, 127);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(72, 19);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Apellidos";
            // 
            // ApellidosTxt
            // 
            this.ApellidosTxt.Depth = 0;
            this.ApellidosTxt.Hint = "";
            this.ApellidosTxt.Location = new System.Drawing.Point(136, 123);
            this.ApellidosTxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.ApellidosTxt.Name = "ApellidosTxt";
            this.ApellidosTxt.PasswordChar = '\0';
            this.ApellidosTxt.SelectedText = "";
            this.ApellidosTxt.SelectionLength = 0;
            this.ApellidosTxt.SelectionStart = 0;
            this.ApellidosTxt.Size = new System.Drawing.Size(153, 23);
            this.ApellidosTxt.TabIndex = 2;
            this.ApellidosTxt.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(25, 169);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(70, 19);
            this.materialLabel3.TabIndex = 5;
            this.materialLabel3.Text = "Identidad";
            // 
            // IdentidadTxt
            // 
            this.IdentidadTxt.Depth = 0;
            this.IdentidadTxt.Hint = "";
            this.IdentidadTxt.Location = new System.Drawing.Point(136, 165);
            this.IdentidadTxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.IdentidadTxt.Name = "IdentidadTxt";
            this.IdentidadTxt.PasswordChar = '\0';
            this.IdentidadTxt.SelectedText = "";
            this.IdentidadTxt.SelectionLength = 0;
            this.IdentidadTxt.SelectionStart = 0;
            this.IdentidadTxt.Size = new System.Drawing.Size(153, 23);
            this.IdentidadTxt.TabIndex = 4;
            this.IdentidadTxt.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(25, 211);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(73, 19);
            this.materialLabel4.TabIndex = 7;
            this.materialLabel4.Text = "Direccion";
            // 
            // DireccionTxt
            // 
            this.DireccionTxt.Depth = 0;
            this.DireccionTxt.Hint = "";
            this.DireccionTxt.Location = new System.Drawing.Point(136, 207);
            this.DireccionTxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.DireccionTxt.Name = "DireccionTxt";
            this.DireccionTxt.PasswordChar = '\0';
            this.DireccionTxt.SelectedText = "";
            this.DireccionTxt.SelectionLength = 0;
            this.DireccionTxt.SelectionStart = 0;
            this.DireccionTxt.Size = new System.Drawing.Size(153, 23);
            this.DireccionTxt.TabIndex = 6;
            this.DireccionTxt.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(25, 253);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(69, 19);
            this.materialLabel5.TabIndex = 9;
            this.materialLabel5.Text = "Telefono";
            // 
            // TelefonoTxt
            // 
            this.TelefonoTxt.Depth = 0;
            this.TelefonoTxt.Hint = "";
            this.TelefonoTxt.Location = new System.Drawing.Point(136, 249);
            this.TelefonoTxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.TelefonoTxt.Name = "TelefonoTxt";
            this.TelefonoTxt.PasswordChar = '\0';
            this.TelefonoTxt.SelectedText = "";
            this.TelefonoTxt.SelectionLength = 0;
            this.TelefonoTxt.SelectionStart = 0;
            this.TelefonoTxt.Size = new System.Drawing.Size(153, 23);
            this.TelefonoTxt.TabIndex = 8;
            this.TelefonoTxt.UseSystemPasswordChar = false;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(25, 295);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(56, 19);
            this.materialLabel6.TabIndex = 11;
            this.materialLabel6.Text = "Celular";
            // 
            // CelularTxt
            // 
            this.CelularTxt.Depth = 0;
            this.CelularTxt.Hint = "";
            this.CelularTxt.Location = new System.Drawing.Point(136, 291);
            this.CelularTxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.CelularTxt.Name = "CelularTxt";
            this.CelularTxt.PasswordChar = '\0';
            this.CelularTxt.SelectedText = "";
            this.CelularTxt.SelectionLength = 0;
            this.CelularTxt.SelectionStart = 0;
            this.CelularTxt.Size = new System.Drawing.Size(153, 23);
            this.CelularTxt.TabIndex = 10;
            this.CelularTxt.UseSystemPasswordChar = false;
            // 
            // DgvCliente
            // 
            this.DgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCliente.Location = new System.Drawing.Point(336, 81);
            this.DgvCliente.Name = "DgvCliente";
            this.DgvCliente.Size = new System.Drawing.Size(452, 233);
            this.DgvCliente.TabIndex = 12;
            // 
            // BtnCrear
            // 
            this.BtnCrear.Depth = 0;
            this.BtnCrear.Location = new System.Drawing.Point(12, 384);
            this.BtnCrear.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnCrear.Name = "BtnCrear";
            this.BtnCrear.Primary = true;
            this.BtnCrear.Size = new System.Drawing.Size(134, 34);
            this.BtnCrear.TabIndex = 13;
            this.BtnCrear.Text = "Crear";
            this.BtnCrear.UseVisualStyleBackColor = true;
            this.BtnCrear.Click += new System.EventHandler(this.BtnCrear_Click);
            // 
            // BtnListar
            // 
            this.BtnListar.Depth = 0;
            this.BtnListar.Location = new System.Drawing.Point(170, 384);
            this.BtnListar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnListar.Name = "BtnListar";
            this.BtnListar.Primary = true;
            this.BtnListar.Size = new System.Drawing.Size(134, 34);
            this.BtnListar.TabIndex = 14;
            this.BtnListar.Text = "Listar";
            this.BtnListar.UseVisualStyleBackColor = true;
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Depth = 0;
            this.BtnActualizar.Location = new System.Drawing.Point(328, 384);
            this.BtnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Primary = true;
            this.BtnActualizar.Size = new System.Drawing.Size(134, 34);
            this.BtnActualizar.TabIndex = 15;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Depth = 0;
            this.BtnEliminar.Location = new System.Drawing.Point(486, 384);
            this.BtnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Primary = true;
            this.BtnEliminar.Size = new System.Drawing.Size(134, 34);
            this.BtnEliminar.TabIndex = 16;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Depth = 0;
            this.BtnCancelar.Location = new System.Drawing.Point(644, 384);
            this.BtnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Primary = true;
            this.BtnCancelar.Size = new System.Drawing.Size(134, 34);
            this.BtnCancelar.TabIndex = 17;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.BtnListar);
            this.Controls.Add(this.BtnCrear);
            this.Controls.Add(this.DgvCliente);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.CelularTxt);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.TelefonoTxt);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.DireccionTxt);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.IdentidadTxt);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.ApellidosTxt);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.NombreTxt);
            this.Name = "Cliente";
            this.Text = "Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.DgvCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField NombreTxt;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField ApellidosTxt;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField IdentidadTxt;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField DireccionTxt;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialSingleLineTextField TelefonoTxt;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialSingleLineTextField CelularTxt;
        private System.Windows.Forms.DataGridView DgvCliente;
        private MaterialSkin.Controls.MaterialRaisedButton BtnCrear;
        private MaterialSkin.Controls.MaterialRaisedButton BtnListar;
        private MaterialSkin.Controls.MaterialRaisedButton BtnActualizar;
        private MaterialSkin.Controls.MaterialRaisedButton BtnEliminar;
        private MaterialSkin.Controls.MaterialRaisedButton BtnCancelar;
    }
}