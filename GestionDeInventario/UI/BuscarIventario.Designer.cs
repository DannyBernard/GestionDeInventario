namespace GestionDeInventario.UI
{
    partial class BuscarIventario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Cancbutton = new System.Windows.Forms.Button();
            this.Aceptarbutton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.CriteriotextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Cancbutton
            // 
            this.Cancbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancbutton.ForeColor = System.Drawing.SystemColors.Control;
            this.Cancbutton.Image = global::GestionDeInventario.Properties.Resources.Cancel_icon_icons_com_73703;
            this.Cancbutton.Location = new System.Drawing.Point(462, 412);
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
            this.Aceptarbutton.Location = new System.Drawing.Point(319, 412);
            this.Aceptarbutton.Name = "Aceptarbutton";
            this.Aceptarbutton.Size = new System.Drawing.Size(75, 66);
            this.Aceptarbutton.TabIndex = 14;
            this.Aceptarbutton.UseVisualStyleBackColor = true;
            this.Aceptarbutton.Click += new System.EventHandler(this.Aceptarbutton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.dataGridView1.Location = new System.Drawing.Point(24, 85);
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
            this.Buscarbutton.Location = new System.Drawing.Point(319, 6);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(97, 61);
            this.Buscarbutton.TabIndex = 13;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // CriteriotextBox
            // 
            this.CriteriotextBox.Location = new System.Drawing.Point(93, 28);
            this.CriteriotextBox.Name = "CriteriotextBox";
            this.CriteriotextBox.Size = new System.Drawing.Size(200, 22);
            this.CriteriotextBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Criterio";
            // 
            // BuscarIventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 489);
            this.Controls.Add(this.Cancbutton);
            this.Controls.Add(this.Aceptarbutton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.CriteriotextBox);
            this.Controls.Add(this.label1);
            this.Name = "BuscarIventario";
            this.Text = "BuscarIventario";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
    }
}