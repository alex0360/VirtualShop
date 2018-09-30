namespace Precentacion
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.TSBCompras = new System.Windows.Forms.ToolStripButton();
            this.TSBVentas = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.TSSLEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.TSSLUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.TSMIVer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIHerramienta = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backUpBDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIVentanas = new System.Windows.Forms.ToolStripMenuItem();
            this.newWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrangeIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIayuda = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.TSMISistema = new System.Windows.Forms.ToolStripMenuItem();
            this.SalirTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIAlmacen = new System.Windows.Forms.ToolStripMenuItem();
            this.ArticulosTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.CategoriasTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.PresentacionTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMICompras = new System.Windows.Forms.ToolStripMenuItem();
            this.IngresosTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.ProveedorTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.VentasTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.ClienteTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIMantenimiento = new System.Windows.Forms.ToolStripMenuItem();
            this.TrabajadoresTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIConsultas = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasPorFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasPorFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockDeArticulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSBCompras,
            this.TSBVentas});
            this.toolStrip.Location = new System.Drawing.Point(0, 28);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(804, 27);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // TSBCompras
            // 
            this.TSBCompras.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBCompras.Image = ((System.Drawing.Image)(resources.GetObject("TSBCompras.Image")));
            this.TSBCompras.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBCompras.Name = "TSBCompras";
            this.TSBCompras.Size = new System.Drawing.Size(24, 24);
            this.TSBCompras.Text = "Compras";
            // 
            // TSBVentas
            // 
            this.TSBVentas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBVentas.Image = ((System.Drawing.Image)(resources.GetObject("TSBVentas.Image")));
            this.TSBVentas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBVentas.Name = "TSBVentas";
            this.TSBVentas.Size = new System.Drawing.Size(24, 24);
            this.TSBVentas.Text = "Ventas";
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSSLEstado,
            this.TSSLUsuario});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(804, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // TSSLEstado
            // 
            this.TSSLEstado.Name = "TSSLEstado";
            this.TSSLEstado.Size = new System.Drawing.Size(213, 17);
            this.TSSLEstado.Text = "Sistema de ventas www.constante.com";
            // 
            // TSSLUsuario
            // 
            this.TSSLUsuario.Name = "TSSLUsuario";
            this.TSSLUsuario.Size = new System.Drawing.Size(14, 17);
            this.TSSLUsuario.Text = "#";
            // 
            // TSMIVer
            // 
            this.TSMIVer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBarToolStripMenuItem,
            this.statusBarToolStripMenuItem});
            this.TSMIVer.Name = "TSMIVer";
            this.TSMIVer.Size = new System.Drawing.Size(35, 24);
            this.TSMIVer.Text = "&Ver";
            // 
            // toolBarToolStripMenuItem
            // 
            this.toolBarToolStripMenuItem.Checked = true;
            this.toolBarToolStripMenuItem.CheckOnClick = true;
            this.toolBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolBarToolStripMenuItem.Name = "toolBarToolStripMenuItem";
            this.toolBarToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.toolBarToolStripMenuItem.Text = "&Barra de herramientas";
            this.toolBarToolStripMenuItem.Click += new System.EventHandler(this.ToolBarToolStripMenuItem_Click);
            // 
            // statusBarToolStripMenuItem
            // 
            this.statusBarToolStripMenuItem.Checked = true;
            this.statusBarToolStripMenuItem.CheckOnClick = true;
            this.statusBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.statusBarToolStripMenuItem.Name = "statusBarToolStripMenuItem";
            this.statusBarToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.statusBarToolStripMenuItem.Text = "&Barra de estado";
            this.statusBarToolStripMenuItem.Click += new System.EventHandler(this.StatusBarToolStripMenuItem_Click);
            // 
            // TSMIHerramienta
            // 
            this.TSMIHerramienta.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.TSMIHerramienta.Image = ((System.Drawing.Image)(resources.GetObject("TSMIHerramienta.Image")));
            this.TSMIHerramienta.Name = "TSMIHerramienta";
            this.TSMIHerramienta.Size = new System.Drawing.Size(110, 24);
            this.TSMIHerramienta.Text = "&Herramientas";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backUpBDToolStripMenuItem});
            this.optionsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("optionsToolStripMenuItem.Image")));
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.optionsToolStripMenuItem.Text = "Base de Datos";
            // 
            // backUpBDToolStripMenuItem
            // 
            this.backUpBDToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("backUpBDToolStripMenuItem.Image")));
            this.backUpBDToolStripMenuItem.Name = "backUpBDToolStripMenuItem";
            this.backUpBDToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.backUpBDToolStripMenuItem.Text = "Back up BD";
            // 
            // TSMIVentanas
            // 
            this.TSMIVentanas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newWindowToolStripMenuItem,
            this.cascadeToolStripMenuItem,
            this.tileVerticalToolStripMenuItem,
            this.tileHorizontalToolStripMenuItem,
            this.closeAllToolStripMenuItem,
            this.arrangeIconsToolStripMenuItem});
            this.TSMIVentanas.Name = "TSMIVentanas";
            this.TSMIVentanas.Size = new System.Drawing.Size(66, 24);
            this.TSMIVentanas.Text = "&Ventanas";
            // 
            // newWindowToolStripMenuItem
            // 
            this.newWindowToolStripMenuItem.Name = "newWindowToolStripMenuItem";
            this.newWindowToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.newWindowToolStripMenuItem.Text = "&Nueva ventana";
            this.newWindowToolStripMenuItem.Click += new System.EventHandler(this.ShowNewForm);
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.cascadeToolStripMenuItem.Text = "&Cascada";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.CascadeToolStripMenuItem_Click);
            // 
            // tileVerticalToolStripMenuItem
            // 
            this.tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            this.tileVerticalToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.tileVerticalToolStripMenuItem.Text = "Mosaico &vertical";
            this.tileVerticalToolStripMenuItem.Click += new System.EventHandler(this.TileVerticalToolStripMenuItem_Click);
            // 
            // tileHorizontalToolStripMenuItem
            // 
            this.tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            this.tileHorizontalToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.tileHorizontalToolStripMenuItem.Text = "Mosaico &horizontal";
            this.tileHorizontalToolStripMenuItem.Click += new System.EventHandler(this.TileHorizontalToolStripMenuItem_Click);
            // 
            // closeAllToolStripMenuItem
            // 
            this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.closeAllToolStripMenuItem.Text = "C&errar todo";
            this.closeAllToolStripMenuItem.Click += new System.EventHandler(this.CloseAllToolStripMenuItem_Click);
            // 
            // arrangeIconsToolStripMenuItem
            // 
            this.arrangeIconsToolStripMenuItem.Name = "arrangeIconsToolStripMenuItem";
            this.arrangeIconsToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.arrangeIconsToolStripMenuItem.Text = "&Organizar iconos";
            this.arrangeIconsToolStripMenuItem.Click += new System.EventHandler(this.ArrangeIconsToolStripMenuItem_Click);
            // 
            // TSMIayuda
            // 
            this.TSMIayuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.indexToolStripMenuItem,
            this.toolStripSeparator8,
            this.aboutToolStripMenuItem});
            this.TSMIayuda.Name = "TSMIayuda";
            this.TSMIayuda.Size = new System.Drawing.Size(53, 24);
            this.TSMIayuda.Text = "Ay&uda";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("indexToolStripMenuItem.Image")));
            this.indexToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.indexToolStripMenuItem.Text = "&Índice";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(144, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.aboutToolStripMenuItem.Text = "&Acerca de... ...";
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMISistema,
            this.TSMIAlmacen,
            this.TSMICompras,
            this.TSMIVentas,
            this.TSMIMantenimiento,
            this.TSMIConsultas,
            this.TSMIVer,
            this.TSMIHerramienta,
            this.TSMIVentanas,
            this.TSMIayuda});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.TSMIVentanas;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(804, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // TSMISistema
            // 
            this.TSMISistema.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SalirTSMI});
            this.TSMISistema.Image = ((System.Drawing.Image)(resources.GetObject("TSMISistema.Image")));
            this.TSMISistema.Name = "TSMISistema";
            this.TSMISistema.Size = new System.Drawing.Size(80, 24);
            this.TSMISistema.Text = "Sistema";
            // 
            // SalirTSMI
            // 
            this.SalirTSMI.Image = ((System.Drawing.Image)(resources.GetObject("SalirTSMI.Image")));
            this.SalirTSMI.Name = "SalirTSMI";
            this.SalirTSMI.Size = new System.Drawing.Size(184, 26);
            this.SalirTSMI.Text = "Salir";
            this.SalirTSMI.Click += new System.EventHandler(this.SalirTSMI_Click);
            // 
            // TSMIAlmacen
            // 
            this.TSMIAlmacen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ArticulosTSMI,
            this.CategoriasTSMI,
            this.PresentacionTSMI});
            this.TSMIAlmacen.Image = global::Precentacion.Properties.Resources.Paquetes;
            this.TSMIAlmacen.Name = "TSMIAlmacen";
            this.TSMIAlmacen.Size = new System.Drawing.Size(86, 24);
            this.TSMIAlmacen.Text = "Almacen";
            // 
            // ArticulosTSMI
            // 
            this.ArticulosTSMI.Image = ((System.Drawing.Image)(resources.GetObject("ArticulosTSMI.Image")));
            this.ArticulosTSMI.Name = "ArticulosTSMI";
            this.ArticulosTSMI.Size = new System.Drawing.Size(184, 26);
            this.ArticulosTSMI.Text = "Articulos";
            this.ArticulosTSMI.Click += new System.EventHandler(this.ArticulosTSMI_Click);
            // 
            // CategoriasTSMI
            // 
            this.CategoriasTSMI.Image = ((System.Drawing.Image)(resources.GetObject("CategoriasTSMI.Image")));
            this.CategoriasTSMI.Name = "CategoriasTSMI";
            this.CategoriasTSMI.Size = new System.Drawing.Size(184, 26);
            this.CategoriasTSMI.Text = "Categorias";
            this.CategoriasTSMI.Click += new System.EventHandler(this.CategoriasTSMI_Click);
            // 
            // PresentacionTSMI
            // 
            this.PresentacionTSMI.Image = ((System.Drawing.Image)(resources.GetObject("PresentacionTSMI.Image")));
            this.PresentacionTSMI.Name = "PresentacionTSMI";
            this.PresentacionTSMI.Size = new System.Drawing.Size(184, 26);
            this.PresentacionTSMI.Text = "Presentacion";
            this.PresentacionTSMI.Click += new System.EventHandler(this.PresentacionTSMI_Click);
            // 
            // TSMICompras
            // 
            this.TSMICompras.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IngresosTSMI,
            this.ProveedorTSMI});
            this.TSMICompras.Image = ((System.Drawing.Image)(resources.GetObject("TSMICompras.Image")));
            this.TSMICompras.Name = "TSMICompras";
            this.TSMICompras.Size = new System.Drawing.Size(87, 24);
            this.TSMICompras.Text = "Compras";
            // 
            // IngresosTSMI
            // 
            this.IngresosTSMI.Image = ((System.Drawing.Image)(resources.GetObject("IngresosTSMI.Image")));
            this.IngresosTSMI.Name = "IngresosTSMI";
            this.IngresosTSMI.Size = new System.Drawing.Size(184, 26);
            this.IngresosTSMI.Text = "Ingresos";
            this.IngresosTSMI.Click += new System.EventHandler(this.IngresosTSMI_Click);
            // 
            // ProveedorTSMI
            // 
            this.ProveedorTSMI.Image = ((System.Drawing.Image)(resources.GetObject("ProveedorTSMI.Image")));
            this.ProveedorTSMI.Name = "ProveedorTSMI";
            this.ProveedorTSMI.Size = new System.Drawing.Size(184, 26);
            this.ProveedorTSMI.Text = "Proveedor";
            this.ProveedorTSMI.Click += new System.EventHandler(this.ProveedorTSMI_Click);
            // 
            // TSMIVentas
            // 
            this.TSMIVentas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VentasTSMI,
            this.ClienteTSMI});
            this.TSMIVentas.Image = ((System.Drawing.Image)(resources.GetObject("TSMIVentas.Image")));
            this.TSMIVentas.Name = "TSMIVentas";
            this.TSMIVentas.Size = new System.Drawing.Size(73, 24);
            this.TSMIVentas.Text = "Ventas";
            // 
            // VentasTSMI
            // 
            this.VentasTSMI.Image = ((System.Drawing.Image)(resources.GetObject("VentasTSMI.Image")));
            this.VentasTSMI.Name = "VentasTSMI";
            this.VentasTSMI.Size = new System.Drawing.Size(184, 26);
            this.VentasTSMI.Text = "Ventas";
            this.VentasTSMI.Click += new System.EventHandler(this.VentasTSMI_Click);
            // 
            // ClienteTSMI
            // 
            this.ClienteTSMI.Image = ((System.Drawing.Image)(resources.GetObject("ClienteTSMI.Image")));
            this.ClienteTSMI.Name = "ClienteTSMI";
            this.ClienteTSMI.Size = new System.Drawing.Size(184, 26);
            this.ClienteTSMI.Text = "Cliente";
            this.ClienteTSMI.Click += new System.EventHandler(this.ClienteTSMI_Click);
            // 
            // TSMIMantenimiento
            // 
            this.TSMIMantenimiento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TrabajadoresTSMI});
            this.TSMIMantenimiento.Image = ((System.Drawing.Image)(resources.GetObject("TSMIMantenimiento.Image")));
            this.TSMIMantenimiento.Name = "TSMIMantenimiento";
            this.TSMIMantenimiento.Size = new System.Drawing.Size(121, 24);
            this.TSMIMantenimiento.Text = "Mantenimiento";
            // 
            // TrabajadoresTSMI
            // 
            this.TrabajadoresTSMI.Image = ((System.Drawing.Image)(resources.GetObject("TrabajadoresTSMI.Image")));
            this.TrabajadoresTSMI.Name = "TrabajadoresTSMI";
            this.TrabajadoresTSMI.Size = new System.Drawing.Size(184, 26);
            this.TrabajadoresTSMI.Text = "Trabajadores";
            this.TrabajadoresTSMI.Click += new System.EventHandler(this.TrabajadoresTSMI_Click);
            // 
            // TSMIConsultas
            // 
            this.TSMIConsultas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventasPorFechaToolStripMenuItem,
            this.comprasPorFechaToolStripMenuItem,
            this.stockDeArticulosToolStripMenuItem});
            this.TSMIConsultas.Name = "TSMIConsultas";
            this.TSMIConsultas.Size = new System.Drawing.Size(71, 24);
            this.TSMIConsultas.Text = "Consultas";
            // 
            // ventasPorFechaToolStripMenuItem
            // 
            this.ventasPorFechaToolStripMenuItem.Name = "ventasPorFechaToolStripMenuItem";
            this.ventasPorFechaToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.ventasPorFechaToolStripMenuItem.Text = "Ventas Por fecha";
            // 
            // comprasPorFechaToolStripMenuItem
            // 
            this.comprasPorFechaToolStripMenuItem.Name = "comprasPorFechaToolStripMenuItem";
            this.comprasPorFechaToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.comprasPorFechaToolStripMenuItem.Text = "Compras por Fecha";
            // 
            // stockDeArticulosToolStripMenuItem
            // 
            this.stockDeArticulosToolStripMenuItem.Name = "stockDeArticulosToolStripMenuItem";
            this.stockDeArticulosToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.stockDeArticulosToolStripMenuItem.Text = "Stock de Articulos";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormPrincipal";
            this.Text = "Virtual Shop";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private Precentacion.Clases.Comunes Comunes = new Precentacion.Clases.Comunes();
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel TSSLEstado;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem TSMIVer;
        private System.Windows.Forms.ToolStripMenuItem toolBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMIHerramienta;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backUpBDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMIVentanas;
        private System.Windows.Forms.ToolStripMenuItem newWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrangeIconsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMIayuda;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem TSMISistema;
        private System.Windows.Forms.ToolStripMenuItem SalirTSMI;
        private System.Windows.Forms.ToolStripMenuItem TSMIAlmacen;
        private System.Windows.Forms.ToolStripMenuItem ArticulosTSMI;
        private System.Windows.Forms.ToolStripMenuItem CategoriasTSMI;
        private System.Windows.Forms.ToolStripMenuItem PresentacionTSMI;
        private System.Windows.Forms.ToolStripMenuItem TSMICompras;
        private System.Windows.Forms.ToolStripMenuItem IngresosTSMI;
        private System.Windows.Forms.ToolStripMenuItem ProveedorTSMI;
        private System.Windows.Forms.ToolStripMenuItem TSMIVentas;
        private System.Windows.Forms.ToolStripMenuItem VentasTSMI;
        private System.Windows.Forms.ToolStripMenuItem ClienteTSMI;
        private System.Windows.Forms.ToolStripMenuItem TSMIMantenimiento;
        private System.Windows.Forms.ToolStripMenuItem TrabajadoresTSMI;
        private System.Windows.Forms.ToolStripMenuItem TSMIConsultas;
        private System.Windows.Forms.ToolStripMenuItem ventasPorFechaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasPorFechaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockDeArticulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton TSBCompras;
        private System.Windows.Forms.ToolStripButton TSBVentas;
        private System.Windows.Forms.ToolStripStatusLabel TSSLUsuario;
    }
}



