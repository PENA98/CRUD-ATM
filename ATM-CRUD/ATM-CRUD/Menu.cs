using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Aplicar material skin
using MaterialSkin;
using MaterialSkin.Controls;


namespace ATM_CRUD
{
    public partial class Menu : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;

        public Menu()
        {
            InitializeComponent();

            // Implementar temas y colores
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey500, Primary.BlueGrey700, Primary.Grey200,
                Accent.Orange400, TextShade.WHITE
            );
        }

        private void BtnCliente_Click(object sender, EventArgs e)
        {
            Cliente vista = new Cliente();
            vista.Show();
        }

        private void BtnConfiguracion_Click(object sender, EventArgs e)
        {
            Configuraciones vista = new Configuraciones();
            vista.Show();
        }

        private void BtnCuentaCliente_Click(object sender, EventArgs e)
        {
            CuentaCliente vista = new CuentaCliente();
            vista.Show();
        }

        private void BtnServicioCliente_Click(object sender, EventArgs e)
        {
            ServicioCliente vista = new ServicioCliente();
            vista.Show();
        }

        private void BtnServicioPublico_Click(object sender, EventArgs e)
        {
            ServicioPublico vista = new ServicioPublico();
            vista.Show();
        }

        private void BtnTarjetaCredito_Click(object sender, EventArgs e)
        {
            TarjetasCredito vista = new TarjetasCredito();
            vista.Show();
        }
    }
}
