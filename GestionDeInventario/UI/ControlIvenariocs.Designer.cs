namespace GestionDeInventario.UI
{
    partial class ControlIvenariocs
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TipoDeInventariocomboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ObservaciontextBox = new System.Windows.Forms.TextBox();
            this.CodigoProductonumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.DescripciontextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.GondolacomboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PrecionumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.CantidadnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.AlmacencomboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigoIventarioProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDelProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gondolaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.almacenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoIventarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalleIventarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.CodigoRegistronumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.AddALGrinbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.AddGondolabutton = new System.Windows.Forms.Button();
            this.BuscarProductobutton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CodigoProductonumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecionumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleIventarioBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CodigoRegistronumericUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tipo De Inventario";
            // 
            // TipoDeInventariocomboBox
            // 
            this.TipoDeInventariocomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoDeInventariocomboBox.FormattingEnabled = true;
            this.TipoDeInventariocomboBox.Items.AddRange(new object[] {
            "Fisico ",
            "Logico"});
            this.TipoDeInventariocomboBox.Location = new System.Drawing.Point(399, 40);
            this.TipoDeInventariocomboBox.Name = "TipoDeInventariocomboBox";
            this.TipoDeInventariocomboBox.Size = new System.Drawing.Size(121, 24);
            this.TipoDeInventariocomboBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Observacion";
            // 
            // ObservaciontextBox
            // 
            this.ObservaciontextBox.Location = new System.Drawing.Point(116, 89);
            this.ObservaciontextBox.Name = "ObservaciontextBox";
            this.ObservaciontextBox.Size = new System.Drawing.Size(174, 22);
            this.ObservaciontextBox.TabIndex = 6;
            // 
            // CodigoProductonumericUpDown
            // 
            this.CodigoProductonumericUpDown.BackColor = System.Drawing.Color.Aqua;
            this.CodigoProductonumericUpDown.Enabled = false;
            this.CodigoProductonumericUpDown.Location = new System.Drawing.Point(164, 21);
            this.CodigoProductonumericUpDown.Name = "CodigoProductonumericUpDown";
            this.CodigoProductonumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.CodigoProductonumericUpDown.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Codigo Producto";
            // 
            // DescripciontextBox
            // 
            this.DescripciontextBox.BackColor = System.Drawing.Color.Aqua;
            this.DescripciontextBox.Enabled = false;
            this.DescripciontextBox.Location = new System.Drawing.Point(400, 24);
            this.DescripciontextBox.Name = "DescripciontextBox";
            this.DescripciontextBox.Size = new System.Drawing.Size(174, 22);
            this.DescripciontextBox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(306, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Descripcion";
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
            this.GondolacomboBox.Location = new System.Drawing.Point(626, 37);
            this.GondolacomboBox.Name = "GondolacomboBox";
            this.GondolacomboBox.Size = new System.Drawing.Size(121, 24);
            this.GondolacomboBox.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(548, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Gondola";
            // 
            // PrecionumericUpDown
            // 
            this.PrecionumericUpDown.BackColor = System.Drawing.Color.Aqua;
            this.PrecionumericUpDown.Enabled = false;
            this.PrecionumericUpDown.Location = new System.Drawing.Point(164, 83);
            this.PrecionumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.PrecionumericUpDown.Name = "PrecionumericUpDown";
            this.PrecionumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.PrecionumericUpDown.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Precio Producto";
            // 
            // CantidadnumericUpDown
            // 
            this.CantidadnumericUpDown.BackColor = System.Drawing.Color.Aqua;
            this.CantidadnumericUpDown.Location = new System.Drawing.Point(400, 84);
            this.CantidadnumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.CantidadnumericUpDown.Name = "CantidadnumericUpDown";
            this.CantidadnumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.CantidadnumericUpDown.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(306, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "Cantidad";
            // 
            // AlmacencomboBox
            // 
            this.AlmacencomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AlmacencomboBox.FormattingEnabled = true;
            this.AlmacencomboBox.Items.AddRange(new object[] {
            "Almacen 1",
            "Almacan 2",
            "Tienda"});
            this.AlmacencomboBox.Location = new System.Drawing.Point(405, 91);
            this.AlmacencomboBox.Name = "AlmacencomboBox";
            this.AlmacencomboBox.Size = new System.Drawing.Size(121, 24);
            this.AlmacencomboBox.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(327, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "Almacen";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoIventarioProductoDataGridViewTextBoxColumn,
            this.codigoProductoDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.descripcionDelProductoDataGridViewTextBoxColumn,
            this.gondolaDataGridViewTextBoxColumn,
            this.almacenDataGridViewTextBoxColumn,
            this.codigoIventarioDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.detalleIventarioBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 283);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(884, 219);
            this.dataGridView1.TabIndex = 19;
            // 
            // codigoIventarioProductoDataGridViewTextBoxColumn
            // 
            this.codigoIventarioProductoDataGridViewTextBoxColumn.DataPropertyName = "CodigoIventarioProducto";
            this.codigoIventarioProductoDataGridViewTextBoxColumn.HeaderText = "CodigoIventarioProducto";
            this.codigoIventarioProductoDataGridViewTextBoxColumn.Name = "codigoIventarioProductoDataGridViewTextBoxColumn";
            // 
            // codigoProductoDataGridViewTextBoxColumn
            // 
            this.codigoProductoDataGridViewTextBoxColumn.DataPropertyName = "CodigoProducto";
            this.codigoProductoDataGridViewTextBoxColumn.HeaderText = "CodigoProducto";
            this.codigoProductoDataGridViewTextBoxColumn.Name = "codigoProductoDataGridViewTextBoxColumn";
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            // 
            // descripcionDelProductoDataGridViewTextBoxColumn
            // 
            this.descripcionDelProductoDataGridViewTextBoxColumn.DataPropertyName = "DescripcionDelProducto";
            this.descripcionDelProductoDataGridViewTextBoxColumn.HeaderText = "DescripcionDelProducto";
            this.descripcionDelProductoDataGridViewTextBoxColumn.Name = "descripcionDelProductoDataGridViewTextBoxColumn";
            // 
            // gondolaDataGridViewTextBoxColumn
            // 
            this.gondolaDataGridViewTextBoxColumn.DataPropertyName = "Gondola";
            this.gondolaDataGridViewTextBoxColumn.HeaderText = "Gondola";
            this.gondolaDataGridViewTextBoxColumn.Name = "gondolaDataGridViewTextBoxColumn";
            // 
            // almacenDataGridViewTextBoxColumn
            // 
            this.almacenDataGridViewTextBoxColumn.DataPropertyName = "Almacen";
            this.almacenDataGridViewTextBoxColumn.HeaderText = "Almacen";
            this.almacenDataGridViewTextBoxColumn.Name = "almacenDataGridViewTextBoxColumn";
            // 
            // codigoIventarioDataGridViewTextBoxColumn
            // 
            this.codigoIventarioDataGridViewTextBoxColumn.DataPropertyName = "CodigoIventario";
            this.codigoIventarioDataGridViewTextBoxColumn.HeaderText = "CodigoIventario";
            this.codigoIventarioDataGridViewTextBoxColumn.Name = "codigoIventarioDataGridViewTextBoxColumn";
            // 
            // detalleIventarioBindingSource
            // 
            this.detalleIventarioBindingSource.DataSource = typeof(GestionDeInventario.Entidades.DetalleIventario);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Nuevobutton);
            this.groupBox1.Controls.Add(this.Guardarbutton);
            this.groupBox1.Location = new System.Drawing.Point(25, 508);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(839, 91);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Botones";
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nuevobutton.ForeColor = System.Drawing.SystemColors.Control;
            this.Nuevobutton.Image = global::GestionDeInventario.Properties.Resources.icons8_agregar_propiedad_501;
            this.Nuevobutton.Location = new System.Drawing.Point(374, 12);
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
            this.Guardarbutton.Location = new System.Drawing.Point(479, 11);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 73);
            this.Guardarbutton.TabIndex = 14;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // CodigoRegistronumericUpDown
            // 
            this.CodigoRegistronumericUpDown.Location = new System.Drawing.Point(128, 37);
            this.CodigoRegistronumericUpDown.Name = "CodigoRegistronumericUpDown";
            this.CodigoRegistronumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.CodigoRegistronumericUpDown.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 17);
            this.label11.TabIndex = 23;
            this.label11.Text = "Codigo Registro";
            // 
            // AddALGrinbutton
            // 
            this.AddALGrinbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddALGrinbutton.ForeColor = System.Drawing.SystemColors.Control;
            this.AddALGrinbutton.Image = global::GestionDeInventario.Properties.Resources.icons8_plus_math_48;
            this.AddALGrinbutton.Location = new System.Drawing.Point(621, 83);
            this.AddALGrinbutton.Name = "AddALGrinbutton";
            this.AddALGrinbutton.Size = new System.Drawing.Size(75, 59);
            this.AddALGrinbutton.TabIndex = 27;
            this.AddALGrinbutton.UseVisualStyleBackColor = true;
            this.AddALGrinbutton.Click += new System.EventHandler(this.AddALGrinbutton_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Image = global::GestionDeInventario.Properties.Resources.add_file;
            this.button1.Location = new System.Drawing.Point(532, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 45);
            this.button1.TabIndex = 22;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AddGondolabutton
            // 
            this.AddGondolabutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddGondolabutton.ForeColor = System.Drawing.SystemColors.Control;
            this.AddGondolabutton.Image = global::GestionDeInventario.Properties.Resources.add_file;
            this.AddGondolabutton.Location = new System.Drawing.Point(753, 29);
            this.AddGondolabutton.Name = "AddGondolabutton";
            this.AddGondolabutton.Size = new System.Drawing.Size(75, 45);
            this.AddGondolabutton.TabIndex = 21;
            this.AddGondolabutton.UseVisualStyleBackColor = true;
            // 
            // BuscarProductobutton
            // 
            this.BuscarProductobutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuscarProductobutton.ForeColor = System.Drawing.SystemColors.Control;
            this.BuscarProductobutton.Image = global::GestionDeInventario.Properties.Resources.icons8_búsqueda_501;
            this.BuscarProductobutton.Location = new System.Drawing.Point(605, 21);
            this.BuscarProductobutton.Name = "BuscarProductobutton";
            this.BuscarProductobutton.Size = new System.Drawing.Size(100, 57);
            this.BuscarProductobutton.TabIndex = 18;
            this.BuscarProductobutton.UseVisualStyleBackColor = true;
            this.BuscarProductobutton.Click += new System.EventHandler(this.BuscarProductobutton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CodigoProductonumericUpDown);
            this.groupBox2.Controls.Add(this.BuscarProductobutton);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.AddALGrinbutton);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.DescripciontextBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.PrecionumericUpDown);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.CantidadnumericUpDown);
            this.groupBox2.Location = new System.Drawing.Point(5, 135);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(892, 142);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Producto Para Iventario";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ControlIvenariocs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 611);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.CodigoRegistronumericUpDown);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.AddGondolabutton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AlmacencomboBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.GondolacomboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ObservaciontextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TipoDeInventariocomboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "ControlIvenariocs";
            this.Text = "ControlIvenariocs";
            ((System.ComponentModel.ISupportInitialize)(this.CodigoProductonumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecionumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleIventarioBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CodigoRegistronumericUpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox TipoDeInventariocomboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ObservaciontextBox;
        private System.Windows.Forms.NumericUpDown CodigoProductonumericUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DescripciontextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox GondolacomboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown PrecionumericUpDown;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown CantidadnumericUpDown;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox AlmacencomboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button AddGondolabutton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown CodigoRegistronumericUpDown;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button AddALGrinbutton;
        private System.Windows.Forms.Button BuscarProductobutton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoIventarioProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDelProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gondolaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn almacenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoIventarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource detalleIventarioBindingSource;
    }
}