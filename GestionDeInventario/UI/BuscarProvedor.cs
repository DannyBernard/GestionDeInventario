﻿using GestionDeInventario.Entidades;
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
    public partial class BuscarProvedor : Form
    {
        public BuscarProvedor()
        {
            InitializeComponent();
            CagarGrin();
        }
        public void CagarGrin()
        {
            Provedores p = new Provedores();
            dataGridView1.DataSource = p.BuscarL();
        }
        public Provedores Productoselec { get; set; }
        private void Aceptarbutton_Click(object sender, EventArgs e)
        {
            Provedores p = new Provedores();
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                Productoselec = p.Buscarp(Id);
                this.Close();

            }
        }
    }
}
