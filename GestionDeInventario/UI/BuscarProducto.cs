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
    public partial class BuscarProducto : Form
    {
        public BuscarProducto()
        {
            InitializeComponent();
            LlenarGr();
        }
        
         public void LlenarGr()
        {
           
            Producto p = new Producto();
            dataGridView1.DataSource = p.BuscarL(p.Descripcion,p.Provedor);
        }

        
        public Producto Productoselec { get; set; } 
        private void Aceptarbutton_Click(object sender, EventArgs e)
        {
            Producto p = new Producto();
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                Productoselec = p.Buscarp(id);
                this.Close();
           }
        }

        private void Cancbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CriteriotextBox_TextChanged(object sender, EventArgs e)
        {
            Producto p = new Producto();
            string desc;
            string provedor;
            desc = CriteriotextBox.Text;
            provedor = CriteriotextBox.Text;
            p.BuscarL(desc, provedor);
        }
    }
}
