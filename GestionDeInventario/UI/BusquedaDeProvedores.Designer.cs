namespace GestionDeInventario.UI
{
    partial class BusquedaDeProvedores
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
            this.Cancbutton = new System.Windows.Forms.Button();
            this.Aceptarbutton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.CriteriotextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.provedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codigoProvedoresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDeLaEmpresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.choferDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provedoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Cancbutton
            // 
            this.Cancbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancbutton.ForeColor = System.Drawing.SystemColors.Control;
            this.Cancbutton.Image = global::GestionDeInventario.Properties.Resources.Cancel_icon_icons_com_73703;
            this.Cancbutton.Location = new System.Drawing.Point(466, 395);
            this.Cancbutton.Name = "Cancbutton";
            this.Cancbutton.Size = new System.Drawing.Size(75, 66);
            this.Cancbutton.TabIndex = 15;
            this.Cancbutton.UseVisualStyleBackColor = true;
            // 
            // Aceptarbutton
            // 
            this.Aceptarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Aceptarbutton.ForeColor = System.Drawing.SystemColors.Control;
            this.Aceptarbutton.Image = global::GestionDeInventario.Properties.Resources.Accept256_25070;
            this.Aceptarbutton.Location = new System.Drawing.Point(317, 395);
            this.Aceptarbutton.Name = "Aceptarbutton";
            this.Aceptarbutton.Size = new System.Drawing.Size(75, 66);
            this.Aceptarbutton.TabIndex = 14;
            this.Aceptarbutton.UseVisualStyleBackColor = true;
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
            this.codigoProvedoresDataGridViewTextBoxColumn,
            this.nombreDeLaEmpresaDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.choferDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.provedoresBindingSource;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.dataGridView1.Location = new System.Drawing.Point(28, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersWidth = 65;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(745, 303);
            this.dataGridView1.TabIndex = 16;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Buscarbutton.ForeColor = System.Drawing.SystemColors.Control;
            this.Buscarbutton.Image = global::GestionDeInventario.Properties.Resources.icons8_búsqueda_501;
            this.Buscarbutton.Location = new System.Drawing.Point(334, 1);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(97, 61);
            this.Buscarbutton.TabIndex = 13;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            // 
            // CriteriotextBox
            // 
            this.CriteriotextBox.Location = new System.Drawing.Point(116, 20);
            this.CriteriotextBox.Name = "CriteriotextBox";
            this.CriteriotextBox.Size = new System.Drawing.Size(200, 22);
            this.CriteriotextBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Criterio";
            // 
            // provedoresBindingSource
            // 
            this.provedoresBindingSource.DataSource = typeof(GestionDeInventario.Entidades.Provedores);
            // 
            // codigoProvedoresDataGridViewTextBoxColumn
            // 
            this.codigoProvedoresDataGridViewTextBoxColumn.DataPropertyName = "CodigoProvedores";
            this.codigoProvedoresDataGridViewTextBoxColumn.HeaderText = "CodigoProvedores";
            this.codigoProvedoresDataGridViewTextBoxColumn.Name = "codigoProvedoresDataGridViewTextBoxColumn";
            this.codigoProvedoresDataGridViewTextBoxColumn.Width = 153;
            // 
            // nombreDeLaEmpresaDataGridViewTextBoxColumn
            // 
            this.nombreDeLaEmpresaDataGridViewTextBoxColumn.DataPropertyName = "NombreDeLaEmpresa";
            this.nombreDeLaEmpresaDataGridViewTextBoxColumn.HeaderText = "NombreDeLaEmpresa";
            this.nombreDeLaEmpresaDataGridViewTextBoxColumn.Name = "nombreDeLaEmpresaDataGridViewTextBoxColumn";
            this.nombreDeLaEmpresaDataGridViewTextBoxColumn.Width = 176;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.Width = 95;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.Width = 92;
            // 
            // choferDataGridViewTextBoxColumn
            // 
            this.choferDataGridViewTextBoxColumn.DataPropertyName = "Chofer";
            this.choferDataGridViewTextBoxColumn.HeaderText = "Chofer";
            this.choferDataGridViewTextBoxColumn.Name = "choferDataGridViewTextBoxColumn";
            this.choferDataGridViewTextBoxColumn.Width = 78;
            // 
            // BusquedaDeProvedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 466);
            this.Controls.Add(this.Cancbutton);
            this.Controls.Add(this.Aceptarbutton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.CriteriotextBox);
            this.Controls.Add(this.label1);
            this.Name = "BusquedaDeProvedores";
            this.Text = "BusquedaDeProvedores";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provedoresBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancbutton;
        private System.Windows.Forms.Button Aceptarbutton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.TextBox CriteriotextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoProvedoresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDeLaEmpresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn choferDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource provedoresBindingSource;
    }
}