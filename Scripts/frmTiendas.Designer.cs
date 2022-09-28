namespace RegisterStore.Scripts
{
    partial class frmTiendas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnizquierda = new Guna.UI2.WinForms.Guna2Panel();
            this.btcancelar = new Guna.UI2.WinForms.Guna2Button();
            this.bteliminar = new Guna.UI2.WinForms.Guna2Button();
            this.bteditar = new Guna.UI2.WinForms.Guna2Button();
            this.btagregar = new Guna.UI2.WinForms.Guna2Button();
            this.lbid = new System.Windows.Forms.Label();
            this.pninfo = new Guna.UI2.WinForms.Guna2Panel();
            this.txttelefono = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtdireccion = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtnombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbpresentacion = new System.Windows.Forms.Label();
            this.lblaboratorio = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.pntabla = new Guna.UI2.WinForms.Guna2Panel();
            this.lbiconoContador = new System.Windows.Forms.Label();
            this.lbcontador = new System.Windows.Forms.Label();
            this.guna2Separator5 = new Guna.UI2.WinForms.Guna2Separator();
            this.lbproductos = new System.Windows.Forms.Label();
            this.txtbuscar = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbtiendas = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnizquierda.SuspendLayout();
            this.pninfo.SuspendLayout();
            this.pntabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbtiendas)).BeginInit();
            this.SuspendLayout();
            // 
            // pnizquierda
            // 
            this.pnizquierda.Controls.Add(this.btcancelar);
            this.pnizquierda.Controls.Add(this.bteliminar);
            this.pnizquierda.Controls.Add(this.bteditar);
            this.pnizquierda.Controls.Add(this.btagregar);
            this.pnizquierda.Controls.Add(this.lbid);
            this.pnizquierda.Controls.Add(this.pninfo);
            this.pnizquierda.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnizquierda.Location = new System.Drawing.Point(1197, 0);
            this.pnizquierda.Name = "pnizquierda";
            this.pnizquierda.ShadowDecoration.Parent = this.pnizquierda;
            this.pnizquierda.Size = new System.Drawing.Size(450, 937);
            this.pnizquierda.TabIndex = 1;
            // 
            // btcancelar
            // 
            this.btcancelar.BorderRadius = 10;
            this.btcancelar.CheckedState.Parent = this.btcancelar;
            this.btcancelar.CustomImages.Parent = this.btcancelar;
            this.btcancelar.FillColor = System.Drawing.Color.Blue;
            this.btcancelar.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcancelar.ForeColor = System.Drawing.Color.White;
            this.btcancelar.HoverState.Parent = this.btcancelar;
            this.btcancelar.Image = global::RegisterStore.Properties.Resources.icono_cancelar_blanco_32;
            this.btcancelar.ImageSize = new System.Drawing.Size(40, 40);
            this.btcancelar.Location = new System.Drawing.Point(55, 805);
            this.btcancelar.Name = "btcancelar";
            this.btcancelar.ShadowDecoration.Parent = this.btcancelar;
            this.btcancelar.Size = new System.Drawing.Size(350, 103);
            this.btcancelar.TabIndex = 8;
            this.btcancelar.Text = "CANCELAR";
            this.btcancelar.Click += new System.EventHandler(this.btcancelar_Click);
            // 
            // bteliminar
            // 
            this.bteliminar.BorderRadius = 10;
            this.bteliminar.CheckedState.Parent = this.bteliminar;
            this.bteliminar.CustomImages.Parent = this.bteliminar;
            this.bteliminar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bteliminar.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bteliminar.ForeColor = System.Drawing.Color.White;
            this.bteliminar.HoverState.Parent = this.bteliminar;
            this.bteliminar.Image = global::RegisterStore.Properties.Resources.eliminar_blanco_48;
            this.bteliminar.ImageOffset = new System.Drawing.Point(-3, 0);
            this.bteliminar.ImageSize = new System.Drawing.Size(40, 40);
            this.bteliminar.Location = new System.Drawing.Point(55, 686);
            this.bteliminar.Name = "bteliminar";
            this.bteliminar.ShadowDecoration.Parent = this.bteliminar;
            this.bteliminar.Size = new System.Drawing.Size(350, 103);
            this.bteliminar.TabIndex = 7;
            this.bteliminar.Text = "ELIMINAR";
            this.bteliminar.Click += new System.EventHandler(this.bteliminar_Click);
            // 
            // bteditar
            // 
            this.bteditar.BorderRadius = 10;
            this.bteditar.CheckedState.Parent = this.bteditar;
            this.bteditar.CustomImages.Parent = this.bteditar;
            this.bteditar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bteditar.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bteditar.ForeColor = System.Drawing.Color.White;
            this.bteditar.HoverState.Parent = this.bteditar;
            this.bteditar.Image = global::RegisterStore.Properties.Resources.editar_blanco_48;
            this.bteditar.ImageOffset = new System.Drawing.Point(-13, 0);
            this.bteditar.ImageSize = new System.Drawing.Size(40, 40);
            this.bteditar.Location = new System.Drawing.Point(55, 568);
            this.bteditar.Name = "bteditar";
            this.bteditar.ShadowDecoration.Parent = this.bteditar;
            this.bteditar.Size = new System.Drawing.Size(350, 103);
            this.bteditar.TabIndex = 6;
            this.bteditar.Text = "EDITAR";
            this.bteditar.Click += new System.EventHandler(this.bteditar_Click);
            // 
            // btagregar
            // 
            this.btagregar.BorderRadius = 10;
            this.btagregar.CheckedState.Parent = this.btagregar;
            this.btagregar.CustomImages.Parent = this.btagregar;
            this.btagregar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btagregar.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btagregar.ForeColor = System.Drawing.Color.White;
            this.btagregar.HoverState.Parent = this.btagregar;
            this.btagregar.Image = global::RegisterStore.Properties.Resources.icono_mas_32;
            this.btagregar.ImageOffset = new System.Drawing.Point(-6, 0);
            this.btagregar.ImageSize = new System.Drawing.Size(40, 40);
            this.btagregar.Location = new System.Drawing.Point(55, 449);
            this.btagregar.Name = "btagregar";
            this.btagregar.ShadowDecoration.Parent = this.btagregar;
            this.btagregar.Size = new System.Drawing.Size(350, 103);
            this.btagregar.TabIndex = 5;
            this.btagregar.Text = "AGREGAR";
            this.btagregar.Click += new System.EventHandler(this.btagregar_Click);
            // 
            // lbid
            // 
            this.lbid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbid.BackColor = System.Drawing.Color.Transparent;
            this.lbid.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lbid.Location = new System.Drawing.Point(24, 9);
            this.lbid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbid.Name = "lbid";
            this.lbid.Size = new System.Drawing.Size(314, 38);
            this.lbid.TabIndex = 26;
            this.lbid.Text = "IDPRODUCTO";
            this.lbid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbid.Visible = false;
            // 
            // pninfo
            // 
            this.pninfo.BorderRadius = 10;
            this.pninfo.Controls.Add(this.txttelefono);
            this.pninfo.Controls.Add(this.txtdireccion);
            this.pninfo.Controls.Add(this.txtnombre);
            this.pninfo.Controls.Add(this.lbpresentacion);
            this.pninfo.Controls.Add(this.lblaboratorio);
            this.pninfo.Controls.Add(this.guna2Separator1);
            this.pninfo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.pninfo.Location = new System.Drawing.Point(55, 80);
            this.pninfo.Name = "pninfo";
            this.pninfo.ShadowDecoration.Parent = this.pninfo;
            this.pninfo.Size = new System.Drawing.Size(350, 333);
            this.pninfo.TabIndex = 0;
            // 
            // txttelefono
            // 
            this.txttelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.txttelefono.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.txttelefono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttelefono.DefaultText = "";
            this.txttelefono.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txttelefono.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txttelefono.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttelefono.DisabledState.Parent = this.txttelefono;
            this.txttelefono.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttelefono.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.txttelefono.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttelefono.FocusedState.Parent = this.txttelefono;
            this.txttelefono.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txttelefono.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttelefono.HoverState.Parent = this.txttelefono;
            this.txttelefono.Location = new System.Drawing.Point(19, 238);
            this.txttelefono.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.PasswordChar = '\0';
            this.txttelefono.PlaceholderText = "ej. 3101111111";
            this.txttelefono.SelectedText = "";
            this.txttelefono.ShadowDecoration.Parent = this.txttelefono;
            this.txttelefono.Size = new System.Drawing.Size(314, 46);
            this.txttelefono.TabIndex = 4;
            this.txttelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txttelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttelefono_KeyPress);
            // 
            // txtdireccion
            // 
            this.txtdireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.txtdireccion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.txtdireccion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdireccion.DefaultText = "";
            this.txtdireccion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtdireccion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtdireccion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdireccion.DisabledState.Parent = this.txtdireccion;
            this.txtdireccion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdireccion.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.txtdireccion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdireccion.FocusedState.Parent = this.txtdireccion;
            this.txtdireccion.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtdireccion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdireccion.HoverState.Parent = this.txtdireccion;
            this.txtdireccion.Location = new System.Drawing.Point(19, 144);
            this.txtdireccion.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.PasswordChar = '\0';
            this.txtdireccion.PlaceholderText = "ej. Cll # s # 0-0";
            this.txtdireccion.SelectedText = "";
            this.txtdireccion.ShadowDecoration.Parent = this.txtdireccion;
            this.txtdireccion.Size = new System.Drawing.Size(314, 46);
            this.txtdireccion.TabIndex = 3;
            this.txtdireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtnombre
            // 
            this.txtnombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.txtnombre.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.txtnombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnombre.DefaultText = "";
            this.txtnombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtnombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtnombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnombre.DisabledState.Parent = this.txtnombre;
            this.txtnombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnombre.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.txtnombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnombre.FocusedState.Parent = this.txtnombre;
            this.txtnombre.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.ForeColor = System.Drawing.Color.White;
            this.txtnombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnombre.HoverState.Parent = this.txtnombre;
            this.txtnombre.Location = new System.Drawing.Point(19, 21);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.PasswordChar = '\0';
            this.txtnombre.PlaceholderText = "NOMBRE TIENDA";
            this.txtnombre.SelectedText = "";
            this.txtnombre.ShadowDecoration.Parent = this.txtnombre;
            this.txtnombre.Size = new System.Drawing.Size(314, 51);
            this.txtnombre.TabIndex = 2;
            this.txtnombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbpresentacion
            // 
            this.lbpresentacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbpresentacion.BackColor = System.Drawing.Color.Transparent;
            this.lbpresentacion.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpresentacion.ForeColor = System.Drawing.Color.White;
            this.lbpresentacion.Location = new System.Drawing.Point(19, 195);
            this.lbpresentacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbpresentacion.Name = "lbpresentacion";
            this.lbpresentacion.Size = new System.Drawing.Size(314, 38);
            this.lbpresentacion.TabIndex = 19;
            this.lbpresentacion.Text = "Teléfono:";
            this.lbpresentacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblaboratorio
            // 
            this.lblaboratorio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblaboratorio.BackColor = System.Drawing.Color.Transparent;
            this.lblaboratorio.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaboratorio.ForeColor = System.Drawing.Color.White;
            this.lblaboratorio.Location = new System.Drawing.Point(19, 101);
            this.lblaboratorio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblaboratorio.Name = "lblaboratorio";
            this.lblaboratorio.Size = new System.Drawing.Size(314, 38);
            this.lblaboratorio.TabIndex = 17;
            this.lblaboratorio.Text = "Dirección:";
            this.lblaboratorio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Separator1.FillColor = System.Drawing.Color.White;
            this.guna2Separator1.FillThickness = 3;
            this.guna2Separator1.Location = new System.Drawing.Point(19, 70);
            this.guna2Separator1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(314, 10);
            this.guna2Separator1.TabIndex = 16;
            // 
            // pntabla
            // 
            this.pntabla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pntabla.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(172)))));
            this.pntabla.BorderRadius = 10;
            this.pntabla.BorderThickness = 2;
            this.pntabla.Controls.Add(this.lbiconoContador);
            this.pntabla.Controls.Add(this.lbcontador);
            this.pntabla.Controls.Add(this.guna2Separator5);
            this.pntabla.Controls.Add(this.lbproductos);
            this.pntabla.Controls.Add(this.txtbuscar);
            this.pntabla.Controls.Add(this.tbtiendas);
            this.pntabla.FillColor = System.Drawing.Color.White;
            this.pntabla.Location = new System.Drawing.Point(46, 48);
            this.pntabla.Name = "pntabla";
            this.pntabla.ShadowDecoration.Parent = this.pntabla;
            this.pntabla.Size = new System.Drawing.Size(1110, 814);
            this.pntabla.TabIndex = 25;
            // 
            // lbiconoContador
            // 
            this.lbiconoContador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbiconoContador.BackColor = System.Drawing.Color.Transparent;
            this.lbiconoContador.Font = new System.Drawing.Font("Segoe UI", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbiconoContador.ForeColor = System.Drawing.Color.Gray;
            this.lbiconoContador.Image = global::RegisterStore.Properties.Resources.contador_icono_48;
            this.lbiconoContador.Location = new System.Drawing.Point(902, 20);
            this.lbiconoContador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbiconoContador.Name = "lbiconoContador";
            this.lbiconoContador.Size = new System.Drawing.Size(65, 74);
            this.lbiconoContador.TabIndex = 27;
            this.lbiconoContador.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbcontador
            // 
            this.lbcontador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbcontador.AutoSize = true;
            this.lbcontador.BackColor = System.Drawing.Color.Transparent;
            this.lbcontador.Font = new System.Drawing.Font("Segoe UI", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcontador.ForeColor = System.Drawing.Color.Gray;
            this.lbcontador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbcontador.Location = new System.Drawing.Point(971, 20);
            this.lbcontador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbcontador.Name = "lbcontador";
            this.lbcontador.Size = new System.Drawing.Size(65, 74);
            this.lbcontador.TabIndex = 26;
            this.lbcontador.Text = "#";
            this.lbcontador.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // guna2Separator5
            // 
            this.guna2Separator5.BackColor = System.Drawing.Color.Transparent;
            this.guna2Separator5.FillColor = System.Drawing.Color.Gray;
            this.guna2Separator5.FillThickness = 3;
            this.guna2Separator5.Location = new System.Drawing.Point(349, 95);
            this.guna2Separator5.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Separator5.Name = "guna2Separator5";
            this.guna2Separator5.Size = new System.Drawing.Size(410, 10);
            this.guna2Separator5.TabIndex = 25;
            // 
            // lbproductos
            // 
            this.lbproductos.BackColor = System.Drawing.Color.Transparent;
            this.lbproductos.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbproductos.ForeColor = System.Drawing.Color.Gray;
            this.lbproductos.Location = new System.Drawing.Point(2, 16);
            this.lbproductos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbproductos.Name = "lbproductos";
            this.lbproductos.Size = new System.Drawing.Size(341, 77);
            this.lbproductos.TabIndex = 24;
            this.lbproductos.Text = "TIENDAS";
            this.lbproductos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtbuscar
            // 
            this.txtbuscar.Animated = true;
            this.txtbuscar.BackColor = System.Drawing.Color.Transparent;
            this.txtbuscar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(74)))));
            this.txtbuscar.BorderRadius = 10;
            this.txtbuscar.BorderThickness = 0;
            this.txtbuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbuscar.DefaultText = "";
            this.txtbuscar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbuscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbuscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbuscar.DisabledState.Parent = this.txtbuscar;
            this.txtbuscar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbuscar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbuscar.FocusedState.Parent = this.txtbuscar;
            this.txtbuscar.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtbuscar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbuscar.HoverState.Parent = this.txtbuscar;
            this.txtbuscar.IconLeft = global::RegisterStore.Properties.Resources.buscar_32;
            this.txtbuscar.IconLeftOffset = new System.Drawing.Point(20, 0);
            this.txtbuscar.IconLeftSize = new System.Drawing.Size(25, 25);
            this.txtbuscar.Location = new System.Drawing.Point(349, 43);
            this.txtbuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.PasswordChar = '\0';
            this.txtbuscar.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtbuscar.PlaceholderText = "BUSCAR TIENDAS";
            this.txtbuscar.SelectedText = "";
            this.txtbuscar.ShadowDecoration.Parent = this.txtbuscar;
            this.txtbuscar.Size = new System.Drawing.Size(410, 50);
            this.txtbuscar.TabIndex = 0;
            this.txtbuscar.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // tbtiendas
            // 
            this.tbtiendas.AllowUserToAddRows = false;
            this.tbtiendas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.tbtiendas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tbtiendas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbtiendas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tbtiendas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.tbtiendas.BackgroundColor = System.Drawing.Color.White;
            this.tbtiendas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbtiendas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tbtiendas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbtiendas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tbtiendas.ColumnHeadersHeight = 50;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tbtiendas.DefaultCellStyle = dataGridViewCellStyle3;
            this.tbtiendas.EnableHeadersVisualStyles = false;
            this.tbtiendas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tbtiendas.Location = new System.Drawing.Point(3, 110);
            this.tbtiendas.Name = "tbtiendas";
            this.tbtiendas.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbtiendas.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.tbtiendas.RowHeadersVisible = false;
            this.tbtiendas.RowHeadersWidth = 30;
            this.tbtiendas.RowTemplate.Height = 40;
            this.tbtiendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tbtiendas.Size = new System.Drawing.Size(1104, 686);
            this.tbtiendas.TabIndex = 1;
            this.tbtiendas.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.tbtiendas.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.tbtiendas.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tbtiendas.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.tbtiendas.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.tbtiendas.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.tbtiendas.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.tbtiendas.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tbtiendas.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.tbtiendas.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tbtiendas.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtiendas.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tbtiendas.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tbtiendas.ThemeStyle.HeaderStyle.Height = 50;
            this.tbtiendas.ThemeStyle.ReadOnly = true;
            this.tbtiendas.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tbtiendas.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tbtiendas.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtiendas.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.tbtiendas.ThemeStyle.RowsStyle.Height = 40;
            this.tbtiendas.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tbtiendas.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.tbtiendas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbtiendas_CellContentClick);
            // 
            // frmTiendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1647, 937);
            this.Controls.Add(this.pntabla);
            this.Controls.Add(this.pnizquierda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTiendas";
            this.Text = "frmTiendas";
            this.pnizquierda.ResumeLayout(false);
            this.pninfo.ResumeLayout(false);
            this.pntabla.ResumeLayout(false);
            this.pntabla.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbtiendas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnizquierda;
        private System.Windows.Forms.Label lbid;
        private Guna.UI2.WinForms.Guna2Panel pninfo;
        private Guna.UI2.WinForms.Guna2TextBox txttelefono;
        private Guna.UI2.WinForms.Guna2TextBox txtdireccion;
        private Guna.UI2.WinForms.Guna2TextBox txtnombre;
        private System.Windows.Forms.Label lbpresentacion;
        private System.Windows.Forms.Label lblaboratorio;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2Button btcancelar;
        private Guna.UI2.WinForms.Guna2Button bteliminar;
        private Guna.UI2.WinForms.Guna2Button bteditar;
        private Guna.UI2.WinForms.Guna2Button btagregar;
        private Guna.UI2.WinForms.Guna2Panel pntabla;
        private System.Windows.Forms.Label lbiconoContador;
        private System.Windows.Forms.Label lbcontador;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator5;
        private System.Windows.Forms.Label lbproductos;
        public Guna.UI2.WinForms.Guna2TextBox txtbuscar;
        private Guna.UI2.WinForms.Guna2DataGridView tbtiendas;
    }
}