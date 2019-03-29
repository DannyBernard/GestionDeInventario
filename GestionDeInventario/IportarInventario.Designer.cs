namespace GestionDeInventario
{
    partial class IportarInventario
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Cargarbutton = new System.Windows.Forms.Button();
            this.CodigoRegistronumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.AddGondolabutton = new System.Windows.Forms.Button();
            this.AlmacencomboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.GondolacomboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ObservaciontextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TipoDeInventariocomboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.detalleIventarioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.detalleIventarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CodigoRegistronumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detalleIventarioBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleIventarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 205);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(799, 262);
            this.dataGridView1.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Cargarbutton
            // 
            this.Cargarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cargarbutton.ForeColor = System.Drawing.SystemColors.Control;
            this.Cargarbutton.Image = global::GestionDeInventario.Properties.Resources.cargar;
            this.Cargarbutton.Location = new System.Drawing.Point(53, 18);
            this.Cargarbutton.Name = "Cargarbutton";
            this.Cargarbutton.Size = new System.Drawing.Size(83, 76);
            this.Cargarbutton.TabIndex = 1;
            this.Cargarbutton.UseVisualStyleBackColor = true;
            this.Cargarbutton.Click += new System.EventHandler(this.Cargarbutton_Click);
            // 
            // CodigoRegistronumericUpDown
            // 
            this.CodigoRegistronumericUpDown.Location = new System.Drawing.Point(156, 51);
            this.CodigoRegistronumericUpDown.Name = "CodigoRegistronumericUpDown";
            this.CodigoRegistronumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.CodigoRegistronumericUpDown.TabIndex = 37;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(40, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 17);
            this.label11.TabIndex = 36;
            this.label11.Text = "Codigo Registro";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Image = global::GestionDeInventario.Properties.Resources.add_file;
            this.button1.Location = new System.Drawing.Point(560, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 45);
            this.button1.TabIndex = 35;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AddGondolabutton
            // 
            this.AddGondolabutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddGondolabutton.ForeColor = System.Drawing.SystemColors.Control;
            this.AddGondolabutton.Image = global::GestionDeInventario.Properties.Resources.add_file;
            this.AddGondolabutton.Location = new System.Drawing.Point(781, 43);
            this.AddGondolabutton.Name = "AddGondolabutton";
            this.AddGondolabutton.Size = new System.Drawing.Size(75, 45);
            this.AddGondolabutton.TabIndex = 34;
            this.AddGondolabutton.UseVisualStyleBackColor = true;
            // 
            // AlmacencomboBox
            // 
            this.AlmacencomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AlmacencomboBox.FormattingEnabled = true;
            this.AlmacencomboBox.Items.AddRange(new object[] {
            "Almacen 1",
            "Almacan 2",
            "Tienda"});
            this.AlmacencomboBox.Location = new System.Drawing.Point(433, 105);
            this.AlmacencomboBox.Name = "AlmacencomboBox";
            this.AlmacencomboBox.Size = new System.Drawing.Size(121, 24);
            this.AlmacencomboBox.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(355, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 17);
            this.label10.TabIndex = 32;
            this.label10.Text = "Almacen";
            // 
            // GondolacomboBox
            // 
            this.GondolacomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GondolacomboBox.FormattingEnabled = true;
            this.GondolacomboBox.Items.AddRange(new object[] {
            "A1",
            "A2",
            "B1",
            "B2"});
            this.GondolacomboBox.Location = new System.Drawing.Point(654, 51);
            this.GondolacomboBox.Name = "GondolacomboBox";
            this.GondolacomboBox.Size = new System.Drawing.Size(121, 24);
            this.GondolacomboBox.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(576, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 30;
            this.label7.Text = "Gondola";
            // 
            // ObservaciontextBox
            // 
            this.ObservaciontextBox.Location = new System.Drawing.Point(144, 103);
            this.ObservaciontextBox.Name = "ObservaciontextBox";
            this.ObservaciontextBox.Size = new System.Drawing.Size(174, 22);
            this.ObservaciontextBox.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "Observacion";
            // 
            // TipoDeInventariocomboBox
            // 
            this.TipoDeInventariocomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoDeInventariocomboBox.FormattingEnabled = true;
            this.TipoDeInventariocomboBox.Items.AddRange(new object[] {
            "Fisico ",
            "Logico"});
            this.TipoDeInventariocomboBox.Location = new System.Drawing.Point(427, 54);
            this.TipoDeInventariocomboBox.Name = "TipoDeInventariocomboBox";
            this.TipoDeInventariocomboBox.Size = new System.Drawing.Size(121, 24);
            this.TipoDeInventariocomboBox.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "Tipo De Inventario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 25;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Nuevobutton);
            this.groupBox1.Controls.Add(this.Guardarbutton);
            this.groupBox1.Location = new System.Drawing.Point(11, 495);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(839, 91);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Botones";
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nuevobutton.ForeColor = System.Drawing.SystemColors.Control;
            this.Nuevobutton.Image = global::GestionDeInventario.Properties.Resources.icons8_agregar_propiedad_501;
            this.Nuevobutton.Location = new System.Drawing.Point(369, 12);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 73);
            this.Nuevobutton.TabIndex = 13;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Guardarbutton.ForeColor = System.Drawing.SystemColors.Control;
            this.Guardarbutton.Image = global::GestionDeInventario.Properties.Resources.icons8_guardar_501;
            this.Guardarbutton.Location = new System.Drawing.Point(479, 11);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 73);
            this.Guardarbutton.TabIndex = 14;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Cargarbutton);
            this.groupBox2.Location = new System.Drawing.Point(623, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Importar";
            // 
            // detalleIventarioBindingSource1
            // 
            this.detalleIventarioBindingSource1.DataSource = typeof(GestionDeInventario.Entidades.DetalleIventario);
            // 
            // detalleIventarioBindingSource
            // 
            this.detalleIventarioBindingSource.DataSource = typeof(GestionDeInventario.Entidades.DetalleIventario);
            // 
            // IportarInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 611);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CodigoRegistronumericUpDown);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AddGondolabutton);
            this.Controls.Add(this.AlmacencomboBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.GondolacomboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ObservaciontextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TipoDeInventariocomboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "IportarInventario";
            this.Text = "IportarInventario";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CodigoRegistronumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.detalleIventarioBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleIventarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource detalleIventarioBindingSource;
        private System.Windows.Forms.Button Cargarbutton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.NumericUpDown CodigoRegistronumericUpDown;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button AddGondolabutton;
        private System.Windows.Forms.ComboBox AlmacencomboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox GondolacomboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ObservaciontextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox TipoDeInventariocomboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource detalleIventarioBindingSource1;
    }
}