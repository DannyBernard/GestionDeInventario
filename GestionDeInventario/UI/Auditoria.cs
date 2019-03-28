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
    public partial class Auditoria : Form
    {
        public Auditoria()
        {
            InitializeComponent();
        }
        public void LlenaCampo()
        {
            DetalleIventario detalle = new DetalleIventario();
            Iventario i = new Iventario();
            i.CodigoInvetario = Convert.ToInt32(CodigoIventarionumericUpDown.Value);
            i.TipoDeIventario = TipoDeIventariotextBox.Text;

        }
    } }

   
