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
    public partial class BusquedaDeProvedores : Form
    {
        public BusquedaDeProvedores()
        {
            InitializeComponent();
            CagarGrin();
 }

        public void CagarGrin()
        {
            Provedores p = new Provedores();
            dataGridView1.DataSource = p.BuscarL();
        }
    }
}
