namespace GestionDeInventario.UI
{
    partial class BuscarProducto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.CriteriotextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Cancbutton = new System.Windows.Forms.Button();
            this.Aceptarbutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.codigoProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDeVencimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Criterio";
            // 
            // CriteriotextBox
            // 
            this.CriteriotextBox.Location = new System.Drawing.Point(72, 34);
            this.CriteriotextBox.Name = "CriteriotextBox";
            this.CriteriotextBox.Size = new System.Drawing.Size(200, 22);
            this.CriteriotextBox.TabIndex = 1;
         
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoProductoDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.provedorDataGridViewTextBoxColumn,
            this.fechaDeVencimientoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productoBindingSource;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.dataGridView1.Location = new System.Drawing.Point(3, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersWidth = 65;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(745, 303);
            this.dataGridView1.TabIndex = 10;
            // 
            // Cancbutton
            // 
            this.Cancbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancbutton.ForeColor = System.Drawing.SystemColors.Control;
            this.Cancbutton.Image = global::GestionDeInventario.Properties.Resources.Cancel_icon_icons_com_73703;
            this.Cancbutton.Location = new System.Drawing.Point(441, 418);
            this.Cancbutton.Name = "Cancbutton";
            this.Cancbutton.Size = new System.Drawing.Size(75, 66);
            this.Cancbutton.TabIndex = 7;
            this.Cancbutton.UseVisualStyleBackColor = true;
            this.Cancbutton.Click += new System.EventHandler(this.Cancbutton_Click);
            // 
            // Aceptarbutton
            // 
            this.Aceptarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Aceptarbutton.ForeColor = System.Drawing.SystemColors.Control;
            this.Aceptarbutton.Image = global::GestionDeInventario.Properties.Resources.Accept256_25070;
            this.Aceptarbutton.Location = new System.Drawing.Point(298, 418);
            this.Aceptarbutton.Name = "Aceptarbutton";
            this.Aceptarbutton.Size = new System.Drawing.Size(75, 66);
            this.Aceptarbutton.TabIndex = 6;
            this.Aceptarbutton.UseVisualStyleBackColor = true;
            this.Aceptarbutton.Click += new System.EventHandler(this.Aceptarbutton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Buscarbutton.ForeColor = System.Drawing.SystemColors.Control;
            this.Buscarbutton.Image = global::GestionDeInventario.Properties.Resources.icons8_búsqueda_501;
            this.Buscarbutton.Location = new System.Drawing.Point(298, 12);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(97, 61);
            this.Buscarbutton.TabIndex = 4;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // codigoProductoDataGridViewTextBoxColumn
            // 
            this.codigoProductoDataGridViewTextBoxColumn.DataPropertyName = "CodigoProducto";
            this.codigoProductoDataGridViewTextBoxColumn.HeaderText = "CodigoProducto";
            this.codigoProductoDataGridViewTextBoxColumn.Name = "codigoProductoDataGridViewTextBoxColumn";
            this.codigoProductoDataGridViewTextBoxColumn.Width = 137;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.Width = 110;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.Width = 92;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            this.precioDataGridViewTextBoxColumn.Width = 76;
            // 
            // provedorDataGridViewTextBoxColumn
            // 
            this.provedorDataGridViewTextBoxColumn.DataPropertyName = "Provedor";
            this.provedorDataGridViewTextBoxColumn.HeaderText = "Provedor";
            this.provedorDataGridViewTextBoxColumn.Name = "provedorDataGridViewTextBoxColumn";
            this.provedorDataGridViewTextBoxColumn.Width = 94;
            // 
            // fechaDeVencimientoDataGridViewTextBoxColumn
            // 
            this.fechaDeVencimientoDataGridViewTextBoxColumn.DataPropertyName = "FechaDeVencimiento";
            this.fechaDeVencimientoDataGridViewTextBoxColumn.HeaderText = "FechaDeVencimiento";
            this.fechaDeVencimientoDataGridViewTextBoxColumn.Name = "fechaDeVencimientoDataGridViewTextBoxColumn";
            this.fechaDeVencimientoDataGridViewTextBoxColumn.Width = 170;
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataSource = typeof(GestionDeInventario.Entidades.Producto);
            // 
            // BuscarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 496);
            this.Controls.Add(this.Cancbutton);
            this.Controls.Add(this.Aceptarbutton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.CriteriotextBox);
            this.Controls.Add(this.label1);
            this.Name = "BuscarProducto";
            this.Text = "BuscarProducto";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CriteriotextBox;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn provedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDeVencimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private System.Windows.Forms.Button Aceptarbutton;
        private System.Windows.Forms.Button Cancbutton;
    }
}