using GestionDeInventario.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeInventario.UI
{
    public partial class MantenimientoProvedores : Form
    {
        public MantenimientoProvedores()
        {
            InitializeComponent();
        }

      

        public void Nuevo()
        {
            CodigoProvedornumericUpDown.Value = 0;
            NombreDeLaEmpresatextBox.Text = string.Empty;
            DirecciontextBox.Text = string.Empty;
            TelefonomaskedTextBox.Text = string.Empty;
            ChofertextBox.Text = string.Empty;

        }
        public Provedores LlenaClase()
        {
            Provedores provedores = new Provedores();
            provedores.CodigoProvedores = Convert.ToInt32(CodigoProvedornumericUpDown.Value);
            provedores.NombreDeLaEmpresa = Convert.ToString(NombreDeLaEmpresatextBox.Text);
            provedores.Direccion = Convert.ToString(DirecciontextBox.Text);
            provedores.Telefono = Convert.ToString(TelefonomaskedTextBox.Text);
            provedores.Chofer = Convert.ToString(ChofertextBox.Text);
            return provedores;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Nuevo();

        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            if (LlenaClase().Guardar())
            {
                Nuevo();
                MessageBox.Show("Guaradado Con Exito");
            }
        }
    }
}
