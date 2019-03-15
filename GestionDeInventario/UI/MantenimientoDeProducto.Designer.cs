namespace GestionDeInventario.UI
{
    partial class MantenimientoDeProducto
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CodigonumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.DescripciontextBox = new System.Windows.Forms.TextBox();
            this.CantidadnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.PrecionumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.ProvedorcomboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.Addbutton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CodigonumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecionumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo De Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(305, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha De Vencimiento";
            // 
            // CodigonumericUpDown
            // 
            this.CodigonumericUpDown.Location = new System.Drawing.Point(178, 77);
            this.CodigonumericUpDown.Name = "CodigonumericUpDown";
            this.CodigonumericUpDown.Size = new System.Drawing.Size(85, 22);
            this.CodigonumericUpDown.TabIndex = 5;
            // 
            // DescripciontextBox
            // 
            this.DescripciontextBox.Location = new System.Drawing.Point(178, 149);
            this.DescripciontextBox.Name = "DescripciontextBox";
            this.DescripciontextBox.Size = new System.Drawing.Size(285, 22);
            this.DescripciontextBox.TabIndex = 6;
            // 
            // CantidadnumericUpDown
            // 
            this.CantidadnumericUpDown.Location = new System.Drawing.Point(178, 214);
            this.CantidadnumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.CantidadnumericUpDown.Name = "CantidadnumericUpDown";
            this.CantidadnumericUpDown.Size = new System.Drawing.Size(102, 22);
            this.CantidadnumericUpDown.TabIndex = 7;
            // 
            // PrecionumericUpDown
            // 
            this.PrecionumericUpDown.DecimalPlaces = 2;
            this.PrecionumericUpDown.Location = new System.Drawing.Point(373, 214);
            this.PrecionumericUpDown.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.PrecionumericUpDown.Name = "PrecionumericUpDown";
            this.PrecionumericUpDown.Size = new System.Drawing.Size(94, 22);
            this.PrecionumericUpDown.TabIndex = 8;
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.CustomFormat = "yyyy/mmm/dd";
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechadateTimePicker.Location = new System.Drawing.Point(178, 320);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(285, 22);
            this.FechadateTimePicker.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Provedor";
            // 
            // ProvedorcomboBox
            // 
            this.ProvedorcomboBox.FormattingEnabled = true;
            this.ProvedorcomboBox.Location = new System.Drawing.Point(178, 264);
            this.ProvedorcomboBox.Name = "ProvedorcomboBox";
            this.ProvedorcomboBox.Size = new System.Drawing.Size(204, 24);
            this.ProvedorcomboBox.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Nuevobutton);
            this.groupBox1.Controls.Add(this.Guardarbutton);
            this.groupBox1.Controls.Add(this.Eliminarbutton);
            this.groupBox1.Location = new System.Drawing.Point(41, 358);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 100);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Botones";
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nuevobutton.ForeColor = System.Drawing.SystemColors.Control;
            this.Nuevobutton.Image = global::GestionDeInventario.Properties.Resources.icons8_agregar_propiedad_501;
            this.Nuevobutton.Location = new System.Drawing.Point(24, 21);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 73);
            this.Nuevobutton.TabIndex = 10;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Guardarbutton.ForeColor = System.Drawing.SystemColors.Control;
            this.Guardarbutton.Image = global::GestionDeInventario.Properties.Resources.icons8_guardar_501;
            this.Guardarbutton.Location = new System.Drawing.Point(173, 21);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 73);
            this.Guardarbutton.TabIndex = 11;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Eliminarbutton.ForeColor = System.Drawing.SystemColors.Control;
            this.Eliminarbutton.Image = global::GestionDeInventario.Properties.Resources.icons8_eliminar_vista_501;
            this.Eliminarbutton.Location = new System.Drawing.Point(347, 21);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 73);
            this.Eliminarbutton.TabIndex = 12;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Buscarbutton.ForeColor = System.Drawing.SystemColors.Control;
            this.Buscarbutton.Image = global::GestionDeInventario.Properties.Resources.icons8_búsqueda_501;
            this.Buscarbutton.Location = new System.Drawing.Point(335, 53);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(100, 65);
            this.Buscarbutton.TabIndex = 16;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // Addbutton
            // 
            this.Addbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Addbutton.ForeColor = System.Drawing.SystemColors.Control;
            this.Addbutton.Image = global::GestionDeInventario.Properties.Resources.add_file;
            this.Addbutton.Location = new System.Drawing.Point(392, 253);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(75, 45);
            this.Addbutton.TabIndex = 15;
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // MantenimientoDeProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 470);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.ProvedorcomboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.PrecionumericUpDown);
            this.Controls.Add(this.CantidadnumericUpDown);
            this.Controls.Add(this.DescripciontextBox);
            this.Controls.Add(this.CodigonumericUpDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MantenimientoDeProducto";
            this.Text = "MantenimientoDeProducto";
            ((System.ComponentModel.ISupportInitialize)(this.CodigonumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecionumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown CodigonumericUpDown;
        private System.Windows.Forms.TextBox DescripciontextBox;
        private System.Windows.Forms.NumericUpDown CantidadnumericUpDown;
        private System.Windows.Forms.NumericUpDown PrecionumericUpDown;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ProvedorcomboBox;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}