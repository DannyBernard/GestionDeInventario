namespace GestionDeInventario.UI
{
    partial class ReporteProductosbajo_en_stock
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigoProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDeVencimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Imprimirbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Productos bajo en stock";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoProductoDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.provedorDataGridViewTextBoxColumn,
            this.fechaDeVencimientoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(22, 186);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(750, 283);
            this.dataGridView1.TabIndex = 2;
            // 
            // codigoProductoDataGridViewTextBoxColumn
            // 
            this.codigoProductoDataGridViewTextBoxColumn.DataPropertyName = "CodigoProducto";
            this.codigoProductoDataGridViewTextBoxColumn.HeaderText = "CodigoProducto";
            this.codigoProductoDataGridViewTextBoxColumn.Name = "codigoProductoDataGridViewTextBoxColumn";
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
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
            // provedorDataGridViewTextBoxColumn
            // 
            this.provedorDataGridViewTextBoxColumn.DataPropertyName = "Provedor";
            this.provedorDataGridViewTextBoxColumn.HeaderText = "Provedor";
            this.provedorDataGridViewTextBoxColumn.Name = "provedorDataGridViewTextBoxColumn";
            // 
            // fechaDeVencimientoDataGridViewTextBoxColumn
            // 
            this.fechaDeVencimientoDataGridViewTextBoxColumn.DataPropertyName = "FechaDeVencimiento";
            this.fechaDeVencimientoDataGridViewTextBoxColumn.HeaderText = "FechaDeVencimiento";
            this.fechaDeVencimientoDataGridViewTextBoxColumn.Name = "fechaDeVencimientoDataGridViewTextBoxColumn";
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataSource = typeof(GestionDeInventario.Entidades.Producto);
            // 
            // Imprimirbutton
            // 
            this.Imprimirbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Imprimirbutton.ForeColor = System.Drawing.SystemColors.Control;
            this.Imprimirbutton.Image = global::GestionDeInventario.Properties.Resources.printer_78349;
            this.Imprimirbutton.Location = new System.Drawing.Point(638, 475);
            this.Imprimirbutton.Name = "Imprimirbutton";
            this.Imprimirbutton.Size = new System.Drawing.Size(116, 45);
            this.Imprimirbutton.TabIndex = 3;
            this.Imprimirbutton.UseVisualStyleBackColor = true;
            this.Imprimirbutton.Click += new System.EventHandler(this.Imprimirbutton_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Image = global::GestionDeInventario.Properties.Resources.clipboard__1_;
            this.button1.Location = new System.Drawing.Point(240, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 82);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(64, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(656, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Boton";
            // 
            // ReporteProductosbajo_en_stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 532);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Imprimirbutton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "ReporteProductosbajo_en_stock";
            this.Text = "ReporteProductosbajo_en_stock";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Imprimirbutton;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn provedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDeVencimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}