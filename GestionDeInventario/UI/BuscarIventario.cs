using GestionDeInventario.Entidades;
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
    public partial class BuscarIventario : Form
    {
        public BuscarIventario()
        {
            InitializeComponent();
            LlenarGrip();
        }
        public void LlenarGrip()
        {

            DetalleIventario di = new DetalleIventario();
            dataGridView1.DataSource = di.Buscarp();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            DetalleIventario di = new DetalleIventario();

        }
        public DetalleIventario Seleccion { get; set; }
        private void Aceptarbutton_Click(object sender, EventArgs e)
        {
            DetalleIventario di = new DetalleIventario();
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                Seleccion = di.Buscar();
                this.Close();
            }
        }
    }
}
