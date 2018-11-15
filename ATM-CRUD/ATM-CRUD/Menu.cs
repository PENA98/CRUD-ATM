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
    }
}
