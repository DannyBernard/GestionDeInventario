namespace GestionDeInventario.UI
{
    partial class PanelPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mantenimeintoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.provedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlDeInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importarIventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosBajoEnStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaProvedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreNosotrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productoProximoAVencerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.auditoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimeintoToolStripMenuItem,
            this.herramientasToolStripMenuItem,
            this.repotesToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.sobreNosotrosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1446, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mantenimeintoToolStripMenuItem
            // 
            this.mantenimeintoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productoToolStripMenuItem,
            this.provedoresToolStripMenuItem});
            this.mantenimeintoToolStripMenuItem.Image = global::GestionDeInventario.Properties.Resources.new_add_user_16734;
            this.mantenimeintoToolStripMenuItem.Name = "mantenimeintoToolStripMenuItem";
            this.mantenimeintoToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.mantenimeintoToolStripMenuItem.Text = "Mantenimeinto";
            // 
            // productoToolStripMenuItem
            // 
            this.productoToolStripMenuItem.Image = global::GestionDeInventario.Properties.Resources.shopping_basket_add256_24909;
            this.productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            this.productoToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.productoToolStripMenuItem.Text = "Producto";
            this.productoToolStripMenuItem.Click += new System.EventHandler(this.productoToolStripMenuItem_Click);
            // 
            // provedoresToolStripMenuItem
            // 
            this.provedoresToolStripMenuItem.Image = global::GestionDeInventario.Properties.Resources.new_add_user_info_16706;
            this.provedoresToolStripMenuItem.Name = "provedoresToolStripMenuItem";
            this.provedoresToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.provedoresToolStripMenuItem.Text = "Provedores";
            this.provedoresToolStripMenuItem.Click += new System.EventHandler(this.provedoresToolStripMenuItem_Click);
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.controlDeInventarioToolStripMenuItem,
            this.importarIventarioToolStripMenuItem,
            this.auditoriaToolStripMenuItem});
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // controlDeInventarioToolStripMenuItem
            // 
            this.controlDeInventarioToolStripMenuItem.Name = "controlDeInventarioToolStripMenuItem";
            this.controlDeInventarioToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.controlDeInventarioToolStripMenuItem.Text = "Control de Inventario";
            this.controlDeInventarioToolStripMenuItem.Click += new System.EventHandler(this.controlDeInventarioToolStripMenuItem_Click_1);
            // 
            // importarIventarioToolStripMenuItem
            // 
            this.importarIventarioToolStripMenuItem.Name = "importarIventarioToolStripMenuItem";
            this.importarIventarioToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.importarIventarioToolStripMenuItem.Text = "Importar Iventario";
            this.importarIventarioToolStripMenuItem.Click += new System.EventHandler(this.importarIventarioToolStripMenuItem_Click);
            // 
            // repotesToolStripMenuItem
            // 
            this.repotesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosBajoEnStockToolStripMenuItem,
            this.productoProximoAVencerToolStripMenuItem});
            this.repotesToolStripMenuItem.Name = "repotesToolStripMenuItem";
            this.repotesToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.repotesToolStripMenuItem.Text = "Repotes ";
            // 
            // productosBajoEnStockToolStripMenuItem
            // 
            this.productosBajoEnStockToolStripMenuItem.Name = "productosBajoEnStockToolStripMenuItem";
            this.productosBajoEnStockToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.productosBajoEnStockToolStripMenuItem.Text = "Productos Bajo en stock";
            this.productosBajoEnStockToolStripMenuItem.Click += new System.EventHandler(this.productosBajoEnStockToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaProductoToolStripMenuItem,
            this.consultaProvedorToolStripMenuItem,
            this.consultaInventarioToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // consultaProductoToolStripMenuItem
            // 
            this.consultaProductoToolStripMenuItem.Name = "consultaProductoToolStripMenuItem";
            this.consultaProductoToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.consultaProductoToolStripMenuItem.Text = "Consulta Producto";
            this.consultaProductoToolStripMenuItem.Click += new System.EventHandler(this.consultaProductoToolStripMenuItem_Click);
            // 
            // consultaProvedorToolStripMenuItem
            // 
            this.consultaProvedorToolStripMenuItem.Name = "consultaProvedorToolStripMenuItem";
            this.consultaProvedorToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.consultaProvedorToolStripMenuItem.Text = "Consulta Provedor";
            this.consultaProvedorToolStripMenuItem.Click += new System.EventHandler(this.consultaProvedorToolStripMenuItem_Click);
            // 
            // consultaInventarioToolStripMenuItem
            // 
            this.consultaInventarioToolStripMenuItem.Name = "consultaInventarioToolStripMenuItem";
            this.consultaInventarioToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.consultaInventarioToolStripMenuItem.Text = "Consulta Inventario";
            this.consultaInventarioToolStripMenuItem.Click += new System.EventHandler(this.consultaInventarioToolStripMenuItem_Click);
            // 
            // sobreNosotrosToolStripMenuItem
            // 
            this.sobreNosotrosToolStripMenuItem.Name = "sobreNosotrosToolStripMenuItem";
            this.sobreNosotrosToolStripMenuItem.Size = new System.Drawing.Size(120, 24);
            this.sobreNosotrosToolStripMenuItem.Text = "SobreNosotros";
            // 
            // productoProximoAVencerToolStripMenuItem
            // 
            this.productoProximoAVencerToolStripMenuItem.Name = "productoProximoAVencerToolStripMenuItem";
            this.productoProximoAVencerToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.productoProximoAVencerToolStripMenuItem.Text = "Producto Proximo A Vencer";
            this.productoProximoAVencerToolStripMenuItem.Click += new System.EventHandler(this.productoProximoAVencerToolStripMenuItem_Click);
            // 
            // auditoriaToolStripMenuItem
            // 
            this.auditoriaToolStripMenuItem.Name = "auditoriaToolStripMenuItem";
            this.auditoriaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.auditoriaToolStripMenuItem.Text = "Auditoria";
            this.auditoriaToolStripMenuItem.Click += new System.EventHandler(this.auditoriaToolStripMenuItem_Click);
            // 
            // PanelPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1446, 685);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "PanelPrincipal";
            this.Text = "PanelPrincipal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mantenimeintoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repotesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreNosotrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlDeInventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem provedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaProvedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importarIventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosBajoEnStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaInventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productoProximoAVencerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem auditoriaToolStripMenuItem;
    }
}