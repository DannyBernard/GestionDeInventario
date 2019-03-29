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
        public void LlenaCampo(DetalleIventario detalle)
        {
            // DetalleIventario detalle = new DetalleIventario();

            CodigoProductonumericUpDown.Value = Convert.ToInt32(detalle.CodigoProducto) ;
            DescripciontextBox.Text = detalle.DescripcionDelProducto;
           CantidadActualnumericUpDown.Value  = Convert.ToInt32(detalle.Cantidad);
            AlmacentextBox.Text= detalle.Almacen;
            GondolatextBox.Text = detalle.Gondola  ;
            /*
            detalle.CodigoProducto = Convert.ToInt32(CodigoProductonumericUpDown.Value);
            detalle.DescripcionDelProducto = DescripciontextBox.Text;
            detalle.Cantidad = Convert.ToInt32(CantidadActualnumericUpDown.Value);
            detalle.Almacen = AlmacentextBox.Text;
            detalle.Gondola = GondolatextBox.Text;
            */
        }
        public void Llenacampoi(Iventario i)
        {
           // Iventario i = new Iventario();
     CodigoIventarionumericUpDown.Value  = Convert.ToInt32(i.CodigoInvetario);  ;
          TipoDeIventariotextBox.Text  = i.TipoDeIventario;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DetalleIventario di = new DetalleIventario();
            Iventario i = new Iventario();
            int id = Convert.ToInt32(CodigoIventarionumericUpDown.Value);
           
                i.Buscarp(id);
                Llenacampoi(i);


                di.BuscarA(id);
                LlenaCampo(di);
           
        }

        public DetalleIventario LlenaClase()
        {
            DetalleIventario detalle = new DetalleIventario();
            detalle.CodigoProducto = Convert.ToInt32(CodigoProductonumericUpDown.Value);
            detalle.DescripcionDelProducto = DescripciontextBox.Text;
            detalle.Cantidad = Convert.ToInt32(CantidadAunumericUpDown.Value);
            detalle.Almacen = AlmacentextBox.Text;
            detalle.Gondola = GondolatextBox.Text;
            detalle.CodigoIventario = Convert.ToInt32(CodigoIventarionumericUpDown.Value);
            return detalle;
        }
        public void Nuevo()
        {
            CodigoIventarionumericUpDown.Value =0;
            CodigoProductonumericUpDown.Value = 0;
            DescripciontextBox.Text = string.Empty;
            CantidadActualnumericUpDown.Value = 0;
            CantidadAunumericUpDown.Value = 0;
            AlmacentextBox.Text = string.Empty;
            GondolatextBox.Text = string.Empty;
            TipoDeIventariotextBox.Text = string.Empty;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DetalleIventario di = new DetalleIventario();
          
           
                if (LlenaClase().Modificara())
                {
                    MessageBox.Show("Listo");
                    Nuevo();
                }
           
            else
            {
                MessageBox.Show("No existe");
            }
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Nuevo();
        }
    } }

   
