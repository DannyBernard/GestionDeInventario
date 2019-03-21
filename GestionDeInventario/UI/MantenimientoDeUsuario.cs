using GestionDeInventario.Entidades;
using System;
using System.Windows.Forms;

namespace GestionDeInventario
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        private Usuario LlenaClase()
        {
           
            Usuario usuario = new Usuario();
            usuario.CodigoUsuario = Convert.ToInt32(numericUpDown1.Value);
            usuario.Nombres = NombretextBox.Text;
            usuario.Cuenta = CuentatextBox.Text;
            usuario.Clave = ClavetextBox.Text;
            dateTimePicker1.CustomFormat = "yyy/MM/dd hh:mm:ss";
            usuario.FechaCreacion = dateTimePicker1.Value;
            if (UsuarioradioButton.Checked)
            {
                usuario.TipoDeCuenta = false;
            }
            else
            {
                usuario.TipoDeCuenta = true;
            }

            return usuario;

        }
        public void Llenarcampo(Usuario usuario)
        {
            numericUpDown1.Value = (int)usuario.CodigoUsuario;
            NombretextBox.Text = usuario.Nombres;
            CuentatextBox.Text = usuario.Cuenta;
            ClavetextBox.Text = usuario.Clave;
           dateTimePicker1.Value =Convert.ToDateTime( usuario.FechaCreacion);
            if (usuario.TipoDeCuenta == false)
            {
                UsuarioradioButton.Checked = true;
            }
            else if (usuario.TipoDeCuenta == true)
            {
                AdminradioButton.Checked = true;
            }
            /*  else if (usuario.TipoDeCuenta == null)
              {
                  AdminradioButton.Checked = false;
                  AdminradioButton.Checked = false;

              }
              */
        }
        public void Nuevo()
        {
            numericUpDown1.Value = 0;
            NombretextBox.Text = string.Empty;
            CuentatextBox.Text = string.Empty;
            ClavetextBox.Text = string.Empty;
            dateTimePicker1.Value = DateTime.Now;

        }

        private bool Validar()
        {
            bool paso = true;
            if (String.IsNullOrWhiteSpace(NombretextBox.Text))
            {
                errorProvider1.SetError(NombretextBox, "Campo Vacio");

            }
            if (String.IsNullOrWhiteSpace(CuentatextBox.Text))
            {
                errorProvider1.SetError(CuentatextBox, "Campo vacio");
            }
            if (String.IsNullOrWhiteSpace(ClavetextBox.Text))
            {
                errorProvider1.SetError(ClavetextBox, "Campo Vacio");
            }
            if (AdminradioButton.Checked == false && UsuarioradioButton.Checked == false)
            {
                errorProvider1.SetError(groupBox1, "seleccione un tipo de usuario");
            }
            paso = false;

            return paso;
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {

            bool paso = false;
            Usuario usuario;

            if (LlenaClase().Guardar())
            {
                MessageBox.Show("Exito!!", "Guardo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Nuevo();
            }
            else
                MessageBox.Show("Error no se Guardo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {

            Usuario usuario = new Usuario();
            usuario.CodigoUsuario = Convert.ToInt32(numericUpDown1.Value);
            // if (usuario.CodigoUsuario > 1 && usuario.CodigoUsuario != null)
            // {
            if (usuario.Buscar())
            {
                MessageBox.Show("Usuario Encotrado con Exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Llenarcampo(usuario);
            }
            // }
            else
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {

            Usuario usuario = new Usuario();
            usuario.CodigoUsuario = Convert.ToInt32(numericUpDown1.Value);
            usuario.Eliminar();
            Nuevo();
            MessageBox.Show("Elimino");

        }
    }
}
