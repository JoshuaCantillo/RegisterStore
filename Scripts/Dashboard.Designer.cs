namespace RegisterStore.Scripts
{
    partial class Dashboard
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btusuarios = new Guna.UI2.WinForms.Guna2Button();
            this.bttiendas = new Guna.UI2.WinForms.Guna2Button();
            this.btventas = new Guna.UI2.WinForms.Guna2Button();
            this.pnfecha = new Guna.UI2.WinForms.Guna2Panel();
            this.lbfecha = new System.Windows.Forms.Label();
            this.lbhora = new System.Windows.Forms.Label();
            this.btpedidos = new Guna.UI2.WinForms.Guna2Button();
            this.btproveedores = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.lbtienda = new System.Windows.Forms.Label();
            this.btproductos = new Guna.UI2.WinForms.Guna2Button();
            this.btsalir = new Guna.UI2.WinForms.Guna2Button();
            this.separador = new Guna.UI2.WinForms.Guna2Separator();
            this.lbregister = new System.Windows.Forms.Label();
            this.lbrs = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btcerrar = new Guna.UI2.WinForms.Guna2Button();
            this.txtusuario = new Guna.UI2.WinForms.Guna2Button();
            this.pnescritorio = new Guna.UI2.WinForms.Guna2Panel();
            this.Reloj = new System.Windows.Forms.Timer(this.components);
            this.guna2Panel1.SuspendLayout();
            this.pnfecha.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Controls.Add(this.btusuarios);
            this.guna2Panel1.Controls.Add(this.bttiendas);
            this.guna2Panel1.Controls.Add(this.btventas);
            this.guna2Panel1.Controls.Add(this.pnfecha);
            this.guna2Panel1.Controls.Add(this.btpedidos);
            this.guna2Panel1.Controls.Add(this.btproveedores);
            this.guna2Panel1.Controls.Add(this.guna2Separator1);
            this.guna2Panel1.Controls.Add(this.lbtienda);
            this.guna2Panel1.Controls.Add(this.btproductos);
            this.guna2Panel1.Controls.Add(this.btsalir);
            this.guna2Panel1.Controls.Add(this.separador);
            this.guna2Panel1.Controls.Add(this.lbregister);
            this.guna2Panel1.Controls.Add(this.lbrs);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(44)))), ((int)(((byte)(72)))));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel1.MinimumSize = new System.Drawing.Size(150, 615);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(200, 627);
            this.guna2Panel1.TabIndex = 0;
            // 
            // btusuarios
            // 
            this.btusuarios.BorderRadius = 5;
            this.btusuarios.CheckedState.Parent = this.btusuarios;
            this.btusuarios.CustomImages.Parent = this.btusuarios;
            this.btusuarios.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(44)))), ((int)(((byte)(72)))));
            this.btusuarios.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btusuarios.ForeColor = System.Drawing.Color.White;
            this.btusuarios.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.btusuarios.HoverState.Parent = this.btusuarios;
            this.btusuarios.Image = global::RegisterStore.Properties.Resources.icono_usuario_blanco;
            this.btusuarios.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btusuarios.ImageOffset = new System.Drawing.Point(3, 0);
            this.btusuarios.ImageSize = new System.Drawing.Size(25, 25);
            this.btusuarios.Location = new System.Drawing.Point(9, 248);
            this.btusuarios.Name = "btusuarios";
            this.btusuarios.ShadowDecoration.Parent = this.btusuarios;
            this.btusuarios.Size = new System.Drawing.Size(180, 45);
            this.btusuarios.TabIndex = 20;
            this.btusuarios.Text = "Usuarios";
            this.btusuarios.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btusuarios.TextOffset = new System.Drawing.Point(10, 0);
            this.btusuarios.Click += new System.EventHandler(this.btusuarios_Click);
            // 
            // bttiendas
            // 
            this.bttiendas.BorderRadius = 5;
            this.bttiendas.CheckedState.Parent = this.bttiendas;
            this.bttiendas.CustomImages.Parent = this.bttiendas;
            this.bttiendas.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(44)))), ((int)(((byte)(72)))));
            this.bttiendas.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttiendas.ForeColor = System.Drawing.Color.White;
            this.bttiendas.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.bttiendas.HoverState.Parent = this.bttiendas;
            this.bttiendas.Image = global::RegisterStore.Properties.Resources.icono_inventario_blanco;
            this.bttiendas.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bttiendas.ImageOffset = new System.Drawing.Point(3, 0);
            this.bttiendas.ImageSize = new System.Drawing.Size(25, 25);
            this.bttiendas.Location = new System.Drawing.Point(9, 356);
            this.bttiendas.Name = "bttiendas";
            this.bttiendas.ShadowDecoration.Parent = this.bttiendas;
            this.bttiendas.Size = new System.Drawing.Size(180, 45);
            this.bttiendas.TabIndex = 19;
            this.bttiendas.Text = "Tiendas";
            this.bttiendas.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bttiendas.TextOffset = new System.Drawing.Point(10, 0);
            this.bttiendas.Click += new System.EventHandler(this.guna2Button1_Click_1);
            // 
            // btventas
            // 
            this.btventas.BorderRadius = 5;
            this.btventas.CheckedState.Parent = this.btventas;
            this.btventas.CustomImages.Parent = this.btventas;
            this.btventas.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(44)))), ((int)(((byte)(72)))));
            this.btventas.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btventas.ForeColor = System.Drawing.Color.White;
            this.btventas.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.btventas.HoverState.Parent = this.btventas;
            this.btventas.Image = global::RegisterStore.Properties.Resources.icono_ventas_blanco;
            this.btventas.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btventas.ImageOffset = new System.Drawing.Point(3, 0);
            this.btventas.ImageSize = new System.Drawing.Size(25, 25);
            this.btventas.Location = new System.Drawing.Point(9, 410);
            this.btventas.Name = "btventas";
            this.btventas.ShadowDecoration.Parent = this.btventas;
            this.btventas.Size = new System.Drawing.Size(180, 45);
            this.btventas.TabIndex = 18;
            this.btventas.Text = "Ventas";
            this.btventas.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btventas.TextOffset = new System.Drawing.Point(10, 0);
            this.btventas.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // pnfecha
            // 
            this.pnfecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnfecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(44)))), ((int)(((byte)(72)))));
            this.pnfecha.Controls.Add(this.lbfecha);
            this.pnfecha.Controls.Add(this.lbhora);
            this.pnfecha.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.pnfecha.Location = new System.Drawing.Point(0, 488);
            this.pnfecha.Name = "pnfecha";
            this.pnfecha.ShadowDecoration.Parent = this.pnfecha;
            this.pnfecha.Size = new System.Drawing.Size(200, 95);
            this.pnfecha.TabIndex = 8;
            // 
            // lbfecha
            // 
            this.lbfecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbfecha.BackColor = System.Drawing.Color.Transparent;
            this.lbfecha.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbfecha.ForeColor = System.Drawing.Color.White;
            this.lbfecha.Location = new System.Drawing.Point(2, 47);
            this.lbfecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbfecha.Name = "lbfecha";
            this.lbfecha.Size = new System.Drawing.Size(198, 44);
            this.lbfecha.TabIndex = 12;
            this.lbfecha.Text = "dd/MM/AA";
            this.lbfecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbhora
            // 
            this.lbhora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbhora.BackColor = System.Drawing.Color.Transparent;
            this.lbhora.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbhora.ForeColor = System.Drawing.Color.White;
            this.lbhora.Location = new System.Drawing.Point(2, 3);
            this.lbhora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbhora.Name = "lbhora";
            this.lbhora.Size = new System.Drawing.Size(198, 44);
            this.lbhora.TabIndex = 11;
            this.lbhora.Text = "00:\'00 aa";
            this.lbhora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btpedidos
            // 
            this.btpedidos.BorderRadius = 5;
            this.btpedidos.CheckedState.Parent = this.btpedidos;
            this.btpedidos.CustomImages.Parent = this.btpedidos;
            this.btpedidos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(44)))), ((int)(((byte)(72)))));
            this.btpedidos.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btpedidos.ForeColor = System.Drawing.Color.White;
            this.btpedidos.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.btpedidos.HoverState.Parent = this.btpedidos;
            this.btpedidos.Image = global::RegisterStore.Properties.Resources.icono_pedidos_blanco;
            this.btpedidos.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btpedidos.ImageOffset = new System.Drawing.Point(3, 0);
            this.btpedidos.ImageSize = new System.Drawing.Size(25, 25);
            this.btpedidos.Location = new System.Drawing.Point(9, 302);
            this.btpedidos.Name = "btpedidos";
            this.btpedidos.ShadowDecoration.Parent = this.btpedidos;
            this.btpedidos.Size = new System.Drawing.Size(180, 45);
            this.btpedidos.TabIndex = 17;
            this.btpedidos.Text = "Pedidos";
            this.btpedidos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btpedidos.TextOffset = new System.Drawing.Point(10, 0);
            this.btpedidos.Click += new System.EventHandler(this.btpedidos_Click);
            // 
            // btproveedores
            // 
            this.btproveedores.BorderRadius = 5;
            this.btproveedores.CheckedState.Parent = this.btproveedores;
            this.btproveedores.CustomImages.Parent = this.btproveedores;
            this.btproveedores.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(44)))), ((int)(((byte)(72)))));
            this.btproveedores.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btproveedores.ForeColor = System.Drawing.Color.White;
            this.btproveedores.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.btproveedores.HoverState.Parent = this.btproveedores;
            this.btproveedores.Image = global::RegisterStore.Properties.Resources.icono_proveedores_blanco_32;
            this.btproveedores.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btproveedores.ImageOffset = new System.Drawing.Point(3, 0);
            this.btproveedores.ImageSize = new System.Drawing.Size(25, 25);
            this.btproveedores.Location = new System.Drawing.Point(9, 140);
            this.btproveedores.Name = "btproveedores";
            this.btproveedores.ShadowDecoration.Parent = this.btproveedores;
            this.btproveedores.Size = new System.Drawing.Size(180, 45);
            this.btproveedores.TabIndex = 16;
            this.btproveedores.Text = "Proveedores";
            this.btproveedores.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btproveedores.TextOffset = new System.Drawing.Point(10, 0);
            this.btproveedores.Click += new System.EventHandler(this.btproveedores_Click);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Separator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(172)))));
            this.guna2Separator1.FillThickness = 3;
            this.guna2Separator1.Location = new System.Drawing.Point(11, 125);
            this.guna2Separator1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(180, 10);
            this.guna2Separator1.TabIndex = 15;
            // 
            // lbtienda
            // 
            this.lbtienda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbtienda.BackColor = System.Drawing.Color.Transparent;
            this.lbtienda.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtienda.ForeColor = System.Drawing.Color.Silver;
            this.lbtienda.Location = new System.Drawing.Point(12, 74);
            this.lbtienda.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbtienda.Name = "lbtienda";
            this.lbtienda.Size = new System.Drawing.Size(180, 49);
            this.lbtienda.TabIndex = 14;
            this.lbtienda.Text = "NARANAT";
            this.lbtienda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btproductos
            // 
            this.btproductos.BorderRadius = 5;
            this.btproductos.CheckedState.Parent = this.btproductos;
            this.btproductos.CustomImages.Parent = this.btproductos;
            this.btproductos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(44)))), ((int)(((byte)(72)))));
            this.btproductos.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btproductos.ForeColor = System.Drawing.Color.White;
            this.btproductos.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.btproductos.HoverState.Parent = this.btproductos;
            this.btproductos.Image = global::RegisterStore.Properties.Resources.icono_producto_blanco;
            this.btproductos.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btproductos.ImageOffset = new System.Drawing.Point(3, 0);
            this.btproductos.ImageSize = new System.Drawing.Size(25, 25);
            this.btproductos.Location = new System.Drawing.Point(9, 194);
            this.btproductos.Name = "btproductos";
            this.btproductos.ShadowDecoration.Parent = this.btproductos;
            this.btproductos.Size = new System.Drawing.Size(180, 45);
            this.btproductos.TabIndex = 13;
            this.btproductos.Text = "Productos";
            this.btproductos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btproductos.TextOffset = new System.Drawing.Point(10, 0);
            this.btproductos.Click += new System.EventHandler(this.btproductos_Click);
            // 
            // btsalir
            // 
            this.btsalir.Animated = true;
            this.btsalir.BackColor = System.Drawing.Color.Transparent;
            this.btsalir.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btsalir.BorderRadius = 3;
            this.btsalir.CheckedState.Parent = this.btsalir;
            this.btsalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btsalir.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btsalir.CustomImages.Parent = this.btsalir;
            this.btsalir.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btsalir.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btsalir.ForeColor = System.Drawing.Color.White;
            this.btsalir.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btsalir.HoverState.Parent = this.btsalir;
            this.btsalir.Image = global::RegisterStore.Properties.Resources.logout_blanco_16;
            this.btsalir.ImageSize = new System.Drawing.Size(16, 16);
            this.btsalir.Location = new System.Drawing.Point(165, 14);
            this.btsalir.Margin = new System.Windows.Forms.Padding(2);
            this.btsalir.Name = "btsalir";
            this.btsalir.PressedColor = System.Drawing.Color.Empty;
            this.btsalir.ShadowDecoration.BorderRadius = 10;
            this.btsalir.ShadowDecoration.Parent = this.btsalir;
            this.btsalir.Size = new System.Drawing.Size(38, 32);
            this.btsalir.TabIndex = 12;
            this.btsalir.Click += new System.EventHandler(this.btsalir_Click);
            // 
            // separador
            // 
            this.separador.BackColor = System.Drawing.Color.Transparent;
            this.separador.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(172)))));
            this.separador.FillThickness = 3;
            this.separador.Location = new System.Drawing.Point(12, 62);
            this.separador.Margin = new System.Windows.Forms.Padding(2);
            this.separador.Name = "separador";
            this.separador.Size = new System.Drawing.Size(180, 10);
            this.separador.TabIndex = 11;
            // 
            // lbregister
            // 
            this.lbregister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbregister.AutoSize = true;
            this.lbregister.BackColor = System.Drawing.Color.Transparent;
            this.lbregister.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbregister.ForeColor = System.Drawing.Color.White;
            this.lbregister.Location = new System.Drawing.Point(77, 9);
            this.lbregister.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbregister.Name = "lbregister";
            this.lbregister.Size = new System.Drawing.Size(84, 50);
            this.lbregister.TabIndex = 10;
            this.lbregister.Text = "Register\r\nStore";
            // 
            // lbrs
            // 
            this.lbrs.AutoSize = true;
            this.lbrs.BackColor = System.Drawing.Color.Transparent;
            this.lbrs.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbrs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(172)))));
            this.lbrs.Location = new System.Drawing.Point(5, 8);
            this.lbrs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbrs.Name = "lbrs";
            this.lbrs.Size = new System.Drawing.Size(68, 51);
            this.lbrs.TabIndex = 9;
            this.lbrs.Text = "RS";
            this.lbrs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.btcerrar);
            this.guna2Panel2.Controls.Add(this.txtusuario);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(200, 0);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(870, 48);
            this.guna2Panel2.TabIndex = 1;
            // 
            // btcerrar
            // 
            this.btcerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btcerrar.Animated = true;
            this.btcerrar.BackColor = System.Drawing.Color.Transparent;
            this.btcerrar.BorderRadius = 3;
            this.btcerrar.CheckedState.Parent = this.btcerrar;
            this.btcerrar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btcerrar.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btcerrar.CustomImages.Parent = this.btcerrar;
            this.btcerrar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.btcerrar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btcerrar.ForeColor = System.Drawing.Color.White;
            this.btcerrar.HoverState.FillColor = System.Drawing.Color.Red;
            this.btcerrar.HoverState.Parent = this.btcerrar;
            this.btcerrar.Image = global::RegisterStore.Properties.Resources.cerrar_blanco_16;
            this.btcerrar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btcerrar.ImageSize = new System.Drawing.Size(15, 15);
            this.btcerrar.Location = new System.Drawing.Point(785, 16);
            this.btcerrar.Margin = new System.Windows.Forms.Padding(2);
            this.btcerrar.MinimumSize = new System.Drawing.Size(67, 24);
            this.btcerrar.Name = "btcerrar";
            this.btcerrar.PressedColor = System.Drawing.Color.Red;
            this.btcerrar.ShadowDecoration.BorderRadius = 30;
            this.btcerrar.ShadowDecoration.Depth = 100;
            this.btcerrar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btcerrar.ShadowDecoration.Parent = this.btcerrar;
            this.btcerrar.Size = new System.Drawing.Size(86, 30);
            this.btcerrar.TabIndex = 7;
            this.btcerrar.Text = "CERRAR";
            this.btcerrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btcerrar.Click += new System.EventHandler(this.btcerrar_Click);
            // 
            // txtusuario
            // 
            this.txtusuario.CheckedState.Parent = this.txtusuario;
            this.txtusuario.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtusuario.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtusuario.CustomImages.Parent = this.txtusuario;
            this.txtusuario.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.txtusuario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtusuario.ForeColor = System.Drawing.Color.White;
            this.txtusuario.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.txtusuario.HoverState.Parent = this.txtusuario;
            this.txtusuario.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtusuario.Location = new System.Drawing.Point(-2, 14);
            this.txtusuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.PressedColor = System.Drawing.Color.Transparent;
            this.txtusuario.PressedDepth = 0;
            this.txtusuario.ShadowDecoration.BorderRadius = 10;
            this.txtusuario.ShadowDecoration.Depth = 50;
            this.txtusuario.ShadowDecoration.Parent = this.txtusuario;
            this.txtusuario.Size = new System.Drawing.Size(156, 32);
            this.txtusuario.TabIndex = 6;
            this.txtusuario.Text = "USUARIO / TIPO";
            this.txtusuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pnescritorio
            // 
            this.pnescritorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnescritorio.Location = new System.Drawing.Point(200, 48);
            this.pnescritorio.Name = "pnescritorio";
            this.pnescritorio.ShadowDecoration.Parent = this.pnescritorio;
            this.pnescritorio.Size = new System.Drawing.Size(870, 579);
            this.pnescritorio.TabIndex = 2;
            // 
            // Reloj
            // 
            this.Reloj.Enabled = true;
            this.Reloj.Tick += new System.EventHandler(this.Reloj_Tick);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 627);
            this.Controls.Add(this.pnescritorio);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.pnfecha.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Separator separador;
        private System.Windows.Forms.Label lbregister;
        protected internal System.Windows.Forms.Label lbrs;
        private Guna.UI2.WinForms.Guna2Button btsalir;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btcerrar;
        public Guna.UI2.WinForms.Guna2Button txtusuario;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2Button btproductos;
        private Guna.UI2.WinForms.Guna2Panel pnescritorio;
        private Guna.UI2.WinForms.Guna2Button btproveedores;
        private Guna.UI2.WinForms.Guna2Button btpedidos;
        public System.Windows.Forms.Label lbtienda;
        private System.Windows.Forms.Timer Reloj;
        private Guna.UI2.WinForms.Guna2Panel pnfecha;
        public System.Windows.Forms.Label lbfecha;
        public System.Windows.Forms.Label lbhora;
        private Guna.UI2.WinForms.Guna2Button btventas;
        private Guna.UI2.WinForms.Guna2Button bttiendas;
        private Guna.UI2.WinForms.Guna2Button btusuarios;
    }
}