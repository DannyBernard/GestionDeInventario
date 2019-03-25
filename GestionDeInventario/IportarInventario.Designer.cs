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
            this.Cargarbutton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.detalleIventarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleIventarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(799, 294);
            this.dataGridView1.TabIndex = 0;
            // 
            // Cargarbutton
            // 
            this.Cargarbutton.Location = new System.Drawing.Point(293, 387);
            this.Cargarbutton.Name = "Cargarbutton";
            this.Cargarbutton.Size = new System.Drawing.Size(83, 51);
            this.Cargarbutton.TabIndex = 1;
            this.Cargarbutton.Text = "Cargar";
            this.Cargarbutton.UseVisualStyleBackColor = true;
            this.Cargarbutton.Click += new System.EventHandler(this.Cargarbutton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // detalleIventarioBindingSource
            // 
            this.detalleIventarioBindingSource.DataSource = typeof(GestionDeInventario.Entidades.DetalleIventario);
            // 
            // IportarInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Cargarbutton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "IportarInventario";
            this.Text = "IportarInventario";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleIventarioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource detalleIventarioBindingSource;
        private System.Windows.Forms.Button Cargarbutton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}