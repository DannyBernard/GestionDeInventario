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
            this.label1 = new System.Windows.Forms.Label();
            this.CodigoIventarionumericUpDown = new System.Windows.Forms.NumericUpDown();
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
            this.CodigoIventarioProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionDelProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gondola = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Almacen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoIventario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CodigoRegistronumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.prenumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.AddALGrinbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.AddGondolabutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.codigoProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalleIventarioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detalleIventarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CodigoIventarionumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CodigoProductonumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecionumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CodigoRegistronumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prenumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleIventarioBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleIventarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo Iventario";
            // 
            // CodigoIventarionumericUpDown
            // 
            this.CodigoIventarionumericUpDown.Location = new System.Drawing.Point(128, 88);
            this.CodigoIventarionumericUpDown.Name = "CodigoIventarionumericUpDown";
            this.CodigoIventarionumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.CodigoIventarionumericUpDown.TabIndex = 1;
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
            this.label4.Location = new System.Drawing.Point(270, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Observacion";
            // 
            // ObservaciontextBox
            // 
            this.ObservaciontextBox.Location = new System.Drawing.Point(364, 91);
            this.ObservaciontextBox.Name = "ObservaciontextBox";
            this.ObservaciontextBox.Size = new System.Drawing.Size(174, 22);
            this.ObservaciontextBox.TabIndex = 6;
            // 
            // CodigoProductonumericUpDown
            // 
            this.CodigoProductonumericUpDown.Location = new System.Drawing.Point(128, 150);
            this.CodigoProductonumericUpDown.Name = "CodigoProductonumericUpDown";
            this.CodigoProductonumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.CodigoProductonumericUpDown.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Codigo Producto";
            // 
            // DescripciontextBox
            // 
            this.DescripciontextBox.Location = new System.Drawing.Point(364, 153);
            this.DescripciontextBox.Name = "DescripciontextBox";
            this.DescripciontextBox.Size = new System.Drawing.Size(174, 22);
            this.DescripciontextBox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(270, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Descripcion";
            // 
            // GondolacomboBox
            // 
            this.GondolacomboBox.FormattingEnabled = true;
            this.GondolacomboBox.Items.AddRange(new object[] {
            "Fisico ",
            "Logico"});
            this.GondolacomboBox.Location = new System.Drawing.Point(628, 88);
            this.GondolacomboBox.Name = "GondolacomboBox";
            this.GondolacomboBox.Size = new System.Drawing.Size(121, 24);
            this.GondolacomboBox.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(550, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Gondola";
            // 
            // PrecionumericUpDown
            // 
            this.PrecionumericUpDown.Location = new System.Drawing.Point(128, 212);
            this.PrecionumericUpDown.Name = "PrecionumericUpDown";
            this.PrecionumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.PrecionumericUpDown.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Precio Producto";
            // 
            // CantidadnumericUpDown
            // 
            this.CantidadnumericUpDown.Location = new System.Drawing.Point(364, 213);
            this.CantidadnumericUpDown.Name = "CantidadnumericUpDown";
            this.CantidadnumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.CantidadnumericUpDown.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(270, 215);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "Cantidad";
            // 
            // AlmacencomboBox
            // 
            this.AlmacencomboBox.FormattingEnabled = true;
            this.AlmacencomboBox.Items.AddRange(new object[] {
            "Fisico ",
            "Logico"});
            this.AlmacencomboBox.Location = new System.Drawing.Point(628, 146);
            this.AlmacencomboBox.Name = "AlmacencomboBox";
            this.AlmacencomboBox.Size = new System.Drawing.Size(121, 24);
            this.AlmacencomboBox.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(550, 149);
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
            this.codigoProductoDataGridViewTextBoxColumn,
            this.CodigoIventarioProducto,
            this.Precio,
            this.DescripcionDelProducto,
            this.Gondola,
            this.Almacen,
            this.CodigoIventario,
            this.cantidadDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.detalleIventarioBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(13, 260);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(884, 227);
            this.dataGridView1.TabIndex = 19;
            // 
            // CodigoIventarioProducto
            // 
            this.CodigoIventarioProducto.DataPropertyName = "CodigoIventarioProducto";
            this.CodigoIventarioProducto.HeaderText = "CodigoIventarioProducto";
            this.CodigoIventarioProducto.Name = "CodigoIventarioProducto";
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // DescripcionDelProducto
            // 
            this.DescripcionDelProducto.DataPropertyName = "DescripcionDelProducto";
            this.DescripcionDelProducto.HeaderText = "DescripcionDelProducto";
            this.DescripcionDelProducto.Name = "DescripcionDelProducto";
            // 
            // Gondola
            // 
            this.Gondola.DataPropertyName = "Gondola";
            this.Gondola.HeaderText = "Gondola";
            this.Gondola.Name = "Gondola";
            // 
            // Almacen
            // 
            this.Almacen.DataPropertyName = "Almacen";
            this.Almacen.HeaderText = "Almacen";
            this.Almacen.Name = "Almacen";
            // 
            // CodigoIventario
            // 
            this.CodigoIventario.DataPropertyName = "CodigoIventario";
            this.CodigoIventario.HeaderText = "CodigoIventario";
            this.CodigoIventario.Name = "CodigoIventario";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Buscarbutton);
            this.groupBox1.Controls.Add(this.Nuevobutton);
            this.groupBox1.Controls.Add(this.Guardarbutton);
            this.groupBox1.Controls.Add(this.Eliminarbutton);
            this.groupBox1.Location = new System.Drawing.Point(25, 508);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(839, 84);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Botones";
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
            // prenumericUpDown
            // 
            this.prenumericUpDown.DecimalPlaces = 2;
            this.prenumericUpDown.Location = new System.Drawing.Point(642, 210);
            this.prenumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.prenumericUpDown.Name = "prenumericUpDown";
            this.prenumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.prenumericUpDown.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(548, 212);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 17);
            this.label12.TabIndex = 25;
            this.label12.Text = "Precio";
            // 
            // AddALGrinbutton
            // 
            this.AddALGrinbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddALGrinbutton.ForeColor = System.Drawing.SystemColors.Control;
            this.AddALGrinbutton.Image = global::GestionDeInventario.Properties.Resources.icons8_plus_math_48;
            this.AddALGrinbutton.Location = new System.Drawing.Point(789, 191);
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
            this.button1.Location = new System.Drawing.Point(789, 128);
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
            this.AddGondolabutton.Location = new System.Drawing.Point(789, 77);
            this.AddGondolabutton.Name = "AddGondolabutton";
            this.AddGondolabutton.Size = new System.Drawing.Size(75, 45);
            this.AddGondolabutton.TabIndex = 21;
            this.AddGondolabutton.UseVisualStyleBackColor = true;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Buscarbutton.ForeColor = System.Drawing.SystemColors.Control;
            this.Buscarbutton.Image = global::GestionDeInventario.Properties.Resources.icons8_búsqueda_501;
            this.Buscarbutton.Location = new System.Drawing.Point(603, 21);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(100, 57);
            this.Buscarbutton.TabIndex = 17;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nuevobutton.ForeColor = System.Drawing.SystemColors.Control;
            this.Nuevobutton.Image = global::GestionDeInventario.Properties.Resources.icons8_agregar_propiedad_501;
            this.Nuevobutton.Location = new System.Drawing.Point(164, 11);
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
            this.Guardarbutton.Location = new System.Drawing.Point(313, 11);
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
            this.Eliminarbutton.Location = new System.Drawing.Point(487, 11);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 73);
            this.Eliminarbutton.TabIndex = 15;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
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
            // detalleIventarioBindingSource1
            // 
            this.detalleIventarioBindingSource1.DataSource = typeof(GestionDeInventario.Entidades.DetalleIventario);
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataSource = typeof(GestionDeInventario.Entidades.Producto);
            // 
            // detalleIventarioBindingSource
            // 
            this.detalleIventarioBindingSource.DataSource = typeof(GestionDeInventario.Entidades.DetalleIventario);
            // 
            // ControlIvenariocs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 604);
            this.Controls.Add(this.AddALGrinbutton);
            this.Controls.Add(this.prenumericUpDown);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.CodigoRegistronumericUpDown);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AddGondolabutton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.AlmacencomboBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CantidadnumericUpDown);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.PrecionumericUpDown);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.GondolacomboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DescripciontextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CodigoProductonumericUpDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ObservaciontextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TipoDeInventariocomboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CodigoIventarionumericUpDown);
            this.Controls.Add(this.label1);
            this.Name = "ControlIvenariocs";
            this.Text = "ControlIvenariocs";
            ((System.ComponentModel.ISupportInitialize)(this.CodigoIventarionumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CodigoProductonumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecionumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CodigoRegistronumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prenumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleIventarioBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleIventarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown CodigoIventarionumericUpDown;
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
        private System.Windows.Forms.BindingSource productoBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Button AddGondolabutton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown CodigoRegistronumericUpDown;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown prenumericUpDown;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.BindingSource detalleIventarioBindingSource1;
        private System.Windows.Forms.BindingSource detalleIventarioBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoIventarioProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionDelProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gondola;
        private System.Windows.Forms.DataGridViewTextBoxColumn Almacen;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoIventario;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button AddALGrinbutton;
    }
}