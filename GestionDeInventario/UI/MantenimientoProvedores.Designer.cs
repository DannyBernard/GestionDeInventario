namespace GestionDeInventario.UI
{
    partial class MantenimientoProvedores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.CodigoProvedornumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.NombreDeLaEmpresatextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DirecciontextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TelefonomaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ChofertextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CodigoProvedornumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo Provedor";
            // 
            // CodigoProvedornumericUpDown
            // 
            this.CodigoProvedornumericUpDown.Location = new System.Drawing.Point(196, 39);
            this.CodigoProvedornumericUpDown.Name = "CodigoProvedornumericUpDown";
            this.CodigoProvedornumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.CodigoProvedornumericUpDown.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre De La Empresa";
            // 
            // NombreDeLaEmpresatextBox
            // 
            this.NombreDeLaEmpresatextBox.Location = new System.Drawing.Point(193, 103);
            this.NombreDeLaEmpresatextBox.Name = "NombreDeLaEmpresatextBox";
            this.NombreDeLaEmpresatextBox.Size = new System.Drawing.Size(264, 22);
            this.NombreDeLaEmpresatextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Direccion";
            // 
            // DirecciontextBox
            // 
            this.DirecciontextBox.Location = new System.Drawing.Point(193, 158);
            this.DirecciontextBox.Name = "DirecciontextBox";
            this.DirecciontextBox.Size = new System.Drawing.Size(264, 22);
            this.DirecciontextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefono";
            // 
            // TelefonomaskedTextBox
            // 
            this.TelefonomaskedTextBox.Location = new System.Drawing.Point(190, 218);
            this.TelefonomaskedTextBox.Mask = "(999)000-0000";
            this.TelefonomaskedTextBox.Name = "TelefonomaskedTextBox";
            this.TelefonomaskedTextBox.Size = new System.Drawing.Size(267, 22);
            this.TelefonomaskedTextBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Chofer";
            // 
            // ChofertextBox
            // 
            this.ChofertextBox.Location = new System.Drawing.Point(187, 274);
            this.ChofertextBox.Name = "ChofertextBox";
            this.ChofertextBox.Size = new System.Drawing.Size(270, 22);
            this.ChofertextBox.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Nuevobutton);
            this.groupBox1.Controls.Add(this.Guardarbutton);
            this.groupBox1.Controls.Add(this.Eliminarbutton);
            this.groupBox1.Location = new System.Drawing.Point(13, 321);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 100);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Botones";
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nuevobutton.ForeColor = System.Drawing.SystemColors.Control;
            this.Nuevobutton.Image = global::GestionDeInventario.Properties.Resources.icons8_agregar_propiedad_501;
            this.Nuevobutton.Location = new System.Drawing.Point(54, 21);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 73);
            this.Nuevobutton.TabIndex = 13;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Guardarbutton.ForeColor = System.Drawing.SystemColors.Control;
            this.Guardarbutton.Image = global::GestionDeInventario.Properties.Resources.icons8_guardar_501;
            this.Guardarbutton.Location = new System.Drawing.Point(193, 21);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 73);
            this.Guardarbutton.TabIndex = 14;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Eliminarbutton.ForeColor = System.Drawing.SystemColors.Control;
            this.Eliminarbutton.Image = global::GestionDeInventario.Properties.Resources.icons8_eliminar_vista_501;
            this.Eliminarbutton.Location = new System.Drawing.Point(343, 21);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 73);
            this.Eliminarbutton.TabIndex = 15;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Buscarbutton.ForeColor = System.Drawing.SystemColors.Control;
            this.Buscarbutton.Image = global::GestionDeInventario.Properties.Resources.icons8_búsqueda_501;
            this.Buscarbutton.Location = new System.Drawing.Point(331, 17);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(100, 65);
            this.Buscarbutton.TabIndex = 17;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // MantenimientoProvedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 441);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ChofertextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TelefonomaskedTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DirecciontextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NombreDeLaEmpresatextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CodigoProvedornumericUpDown);
            this.Controls.Add(this.label1);
            this.Name = "MantenimientoProvedores";
            this.Text = "MantenimientoProvedores";
            ((System.ComponentModel.ISupportInitialize)(this.CodigoProvedornumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown CodigoProvedornumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NombreDeLaEmpresatextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DirecciontextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox TelefonomaskedTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ChofertextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Buscarbutton;
    }
}