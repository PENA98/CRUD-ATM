using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MaterialSkin;
using MaterialSkin.Controls;

namespace ATM_CRUD
{
    public partial class Cliente : MaterialForm
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            clases.Cliente NuevoCliente = new clases.Cliente();

            NuevoCliente.nombres = NombreTxt.Text;
            NuevoCliente.apellidos = ApellidosTxt.Text;
            NuevoCliente.identidad = IdentidadTxt.Text;
            NuevoCliente.direccion = DireccionTxt.Text;
            NuevoCliente.telefono = TelefonoTxt.Text;
            NuevoCliente.celular = CelularTxt.Text;
            NuevoCliente.CrearCliente(NuevoCliente);

        }
    }
}
