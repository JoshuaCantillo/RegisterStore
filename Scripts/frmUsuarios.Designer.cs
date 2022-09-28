namespace RegisterStore.Scripts
{
    partial class frmUsuarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnizquierda = new Guna.UI2.WinForms.Guna2Panel();
            this.btcancelar = new Guna.UI2.WinForms.Guna2Button();
            this.bteliminar = new Guna.UI2.WinForms.Guna2Button();
            this.bteditar = new Guna.UI2.WinForms.Guna2Button();
            this.btagregar = new Guna.UI2.WinForms.Guna2Button();
            this.lbid = new System.Windows.Forms.Label();
            this.pninfo = new Guna.UI2.WinForms.Guna2Panel();
            this.cbtienda = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tiendasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this._registerstore_dbDataSet = new RegisterStore._registerstore_dbDataSet();
            this.lbtienda = new System.Windows.Forms.Label();
            this.cbtipo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtclave = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtnombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbtipo = new System.Windows.Forms.Label();
            this.lbclave = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.tiendasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registerstoreDataSet = new RegisterStore.registerstoreDataSet();
            this.tiendasTableAdapter = new RegisterStore.registerstoreDataSetTableAdapters.tiendasTableAdapter();
            this.pntabla = new Guna.UI2.WinForms.Guna2Panel();
            this.lbiconoContador = new System.Windows.Forms.Label();
            this.lbcontador = new System.Windows.Forms.Label();
            this.guna2Separator5 = new Guna.UI2.WinForms.Guna2Separator();
            this.lbproductos = new System.Windows.Forms.Label();
            this.txtbuscar = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbusuarios = new Guna.UI2.WinForms.Guna2DataGridView();
            this.tiendasTableAdapter1 = new RegisterStore._registerstore_dbDataSetTableAdapters.tiendasTableAdapter();
            this.pnizquierda.SuspendLayout();
            this.pninfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tiendasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._registerstore_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiendasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerstoreDataSet)).BeginInit();
            this.pntabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbusuarios)).BeginInit();
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
            this.pnizquierda.Location = new System.Drawing.Point(986, 0);
            this.pnizquierda.Name = "pnizquierda";
            this.pnizquierda.ShadowDecoration.Parent = this.pnizquierda;
            this.pnizquierda.Size = new System.Drawing.Size(450, 1013);
            this.pnizquierda.TabIndex = 2;
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
            this.btcancelar.Location = new System.Drawing.Point(55, 854);
            this.btcancelar.Name = "btcancelar";
            this.btcancelar.ShadowDecoration.Parent = this.btcancelar;
            this.btcancelar.Size = new System.Drawing.Size(350, 103);
            this.btcancelar.TabIndex = 8;
            this.btcancelar.Text = "CANCELAR";
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
            this.bteliminar.Location = new System.Drawing.Point(55, 735);
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
            this.bteditar.Location = new System.Drawing.Point(55, 617);
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
            this.btagregar.Location = new System.Drawing.Point(55, 498);
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
            this.lbid.Location = new System.Drawing.Point(74, 446);
            this.lbid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbid.Name = "lbid";
            this.lbid.Size = new System.Drawing.Size(314, 38);
            this.lbid.TabIndex = 26;
            this.lbid.Text = "IDUSUARIO";
            this.lbid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbid.Visible = false;
            // 
            // pninfo
            // 
            this.pninfo.BorderRadius = 10;
            this.pninfo.Controls.Add(this.cbtienda);
            this.pninfo.Controls.Add(this.lbtienda);
            this.pninfo.Controls.Add(this.cbtipo);
            this.pninfo.Controls.Add(this.txtclave);
            this.pninfo.Controls.Add(this.txtnombre);
            this.pninfo.Controls.Add(this.lbtipo);
            this.pninfo.Controls.Add(this.lbclave);
            this.pninfo.Controls.Add(this.guna2Separator1);
            this.pninfo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.pninfo.Location = new System.Drawing.Point(55, 37);
            this.pninfo.Name = "pninfo";
            this.pninfo.ShadowDecoration.Parent = this.pninfo;
            this.pninfo.Size = new System.Drawing.Size(350, 391);
            this.pninfo.TabIndex = 0;
            // 
            // cbtienda
            // 
            this.cbtienda.BackColor = System.Drawing.Color.Transparent;
            this.cbtienda.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.cbtienda.BorderThickness = 0;
            this.cbtienda.DataSource = this.tiendasBindingSource1;
            this.cbtienda.DisplayMember = "nombre";
            this.cbtienda.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbtienda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtienda.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.cbtienda.FocusedColor = System.Drawing.Color.Empty;
            this.cbtienda.FocusedState.Parent = this.cbtienda;
            this.cbtienda.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.cbtienda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbtienda.FormattingEnabled = true;
            this.cbtienda.HoverState.Parent = this.cbtienda;
            this.cbtienda.ItemHeight = 30;
            this.cbtienda.ItemsAppearance.Parent = this.cbtienda;
            this.cbtienda.Location = new System.Drawing.Point(24, 312);
            this.cbtienda.Name = "cbtienda";
            this.cbtienda.ShadowDecoration.Parent = this.cbtienda;
            this.cbtienda.Size = new System.Drawing.Size(309, 36);
            this.cbtienda.TabIndex = 22;
            this.cbtienda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tiendasBindingSource1
            // 
            this.tiendasBindingSource1.DataMember = "tiendas";
            this.tiendasBindingSource1.DataSource = this._registerstore_dbDataSet;
            // 
            // _registerstore_dbDataSet
            // 
            this._registerstore_dbDataSet.DataSetName = "_registerstore_dbDataSet";
            this._registerstore_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbtienda
            // 
            this.lbtienda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbtienda.BackColor = System.Drawing.Color.Transparent;
            this.lbtienda.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtienda.ForeColor = System.Drawing.Color.White;
            this.lbtienda.Location = new System.Drawing.Point(19, 271);
            this.lbtienda.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbtienda.Name = "lbtienda";
            this.lbtienda.Size = new System.Drawing.Size(314, 38);
            this.lbtienda.TabIndex = 21;
            this.lbtienda.Text = "Tienda:";
            this.lbtienda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbtipo
            // 
            this.cbtipo.BackColor = System.Drawing.Color.Transparent;
            this.cbtipo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.cbtipo.BorderThickness = 0;
            this.cbtipo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbtipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtipo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.cbtipo.FocusedColor = System.Drawing.Color.Empty;
            this.cbtipo.FocusedState.Parent = this.cbtipo;
            this.cbtipo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.cbtipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbtipo.FormattingEnabled = true;
            this.cbtipo.HoverState.Parent = this.cbtipo;
            this.cbtipo.ItemHeight = 30;
            this.cbtipo.Items.AddRange(new object[] {
            "USUARIO",
            "ADMINISTRADOR",
            "SUPERADMIN"});
            this.cbtipo.ItemsAppearance.Parent = this.cbtipo;
            this.cbtipo.Location = new System.Drawing.Point(24, 232);
            this.cbtipo.Name = "cbtipo";
            this.cbtipo.ShadowDecoration.Parent = this.cbtipo;
            this.cbtipo.Size = new System.Drawing.Size(309, 36);
            this.cbtipo.StartIndex = 0;
            this.cbtipo.TabIndex = 20;
            this.cbtipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtclave
            // 
            this.txtclave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.txtclave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.txtclave.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtclave.DefaultText = "";
            this.txtclave.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtclave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtclave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtclave.DisabledState.Parent = this.txtclave;
            this.txtclave.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtclave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.txtclave.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtclave.FocusedState.Parent = this.txtclave;
            this.txtclave.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtclave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtclave.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtclave.HoverState.Parent = this.txtclave;
            this.txtclave.Location = new System.Drawing.Point(19, 142);
            this.txtclave.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtclave.Name = "txtclave";
            this.txtclave.PasswordChar = '\0';
            this.txtclave.PlaceholderText = "ej. Cll # s # 0-0";
            this.txtclave.SelectedText = "";
            this.txtclave.ShadowDecoration.Parent = this.txtclave;
            this.txtclave.Size = new System.Drawing.Size(314, 46);
            this.txtclave.TabIndex = 3;
            this.txtclave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtclave.UseSystemPasswordChar = true;
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
            this.txtnombre.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.ForeColor = System.Drawing.Color.White;
            this.txtnombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnombre.HoverState.Parent = this.txtnombre;
            this.txtnombre.Location = new System.Drawing.Point(19, 21);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.PasswordChar = '\0';
            this.txtnombre.PlaceholderText = "NOMBRE USUARIO";
            this.txtnombre.SelectedText = "";
            this.txtnombre.ShadowDecoration.Parent = this.txtnombre;
            this.txtnombre.Size = new System.Drawing.Size(314, 51);
            this.txtnombre.TabIndex = 2;
            this.txtnombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbtipo
            // 
            this.lbtipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbtipo.BackColor = System.Drawing.Color.Transparent;
            this.lbtipo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtipo.ForeColor = System.Drawing.Color.White;
            this.lbtipo.Location = new System.Drawing.Point(19, 191);
            this.lbtipo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbtipo.Name = "lbtipo";
            this.lbtipo.Size = new System.Drawing.Size(314, 38);
            this.lbtipo.TabIndex = 19;
            this.lbtipo.Text = "Tipo de usuario:";
            this.lbtipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbclave
            // 
            this.lbclave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbclave.BackColor = System.Drawing.Color.Transparent;
            this.lbclave.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbclave.ForeColor = System.Drawing.Color.White;
            this.lbclave.Location = new System.Drawing.Point(19, 101);
            this.lbclave.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbclave.Name = "lbclave";
            this.lbclave.Size = new System.Drawing.Size(314, 38);
            this.lbclave.TabIndex = 17;
            this.lbclave.Text = "Contraseña:";
            this.lbclave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // tiendasBindingSource
            // 
            this.tiendasBindingSource.DataMember = "tiendas";
            this.tiendasBindingSource.DataSource = this.registerstoreDataSet;
            // 
            // registerstoreDataSet
            // 
            this.registerstoreDataSet.DataSetName = "registerstoreDataSet";
            this.registerstoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tiendasTableAdapter
            // 
            this.tiendasTableAdapter.ClearBeforeFill = true;
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
            this.pntabla.Controls.Add(this.tbusuarios);
            this.pntabla.FillColor = System.Drawing.Color.White;
            this.pntabla.Location = new System.Drawing.Point(56, 37);
            this.pntabla.Name = "pntabla";
            this.pntabla.ShadowDecoration.Parent = this.pntabla;
            this.pntabla.Size = new System.Drawing.Size(924, 920);
            this.pntabla.TabIndex = 26;
            // 
            // lbiconoContador
            // 
            this.lbiconoContador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbiconoContador.BackColor = System.Drawing.Color.Transparent;
            this.lbiconoContador.Font = new System.Drawing.Font("Segoe UI", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbiconoContador.ForeColor = System.Drawing.Color.Gray;
            this.lbiconoContador.Image = global::RegisterStore.Properties.Resources.contador_icono_48;
            this.lbiconoContador.Location = new System.Drawing.Point(748, 20);
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
            this.lbcontador.Location = new System.Drawing.Point(817, 20);
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
            this.guna2Separator5.Location = new System.Drawing.Point(378, 81);
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
            this.lbproductos.Size = new System.Drawing.Size(372, 77);
            this.lbproductos.TabIndex = 24;
            this.lbproductos.Text = "USUARIOS";
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
            this.txtbuscar.Location = new System.Drawing.Point(378, 29);
            this.txtbuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.PasswordChar = '\0';
            this.txtbuscar.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtbuscar.PlaceholderText = "BUSCAR USUARIOS";
            this.txtbuscar.SelectedText = "";
            this.txtbuscar.ShadowDecoration.Parent = this.txtbuscar;
            this.txtbuscar.Size = new System.Drawing.Size(410, 50);
            this.txtbuscar.TabIndex = 0;
            this.txtbuscar.TextOffset = new System.Drawing.Point(10, 0);
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // tbusuarios
            // 
            this.tbusuarios.AllowUserToAddRows = false;
            this.tbusuarios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.tbusuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.tbusuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbusuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tbusuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.tbusuarios.BackgroundColor = System.Drawing.Color.White;
            this.tbusuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbusuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tbusuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbusuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.tbusuarios.ColumnHeadersHeight = 50;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tbusuarios.DefaultCellStyle = dataGridViewCellStyle15;
            this.tbusuarios.EnableHeadersVisualStyles = false;
            this.tbusuarios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tbusuarios.Location = new System.Drawing.Point(3, 110);
            this.tbusuarios.Name = "tbusuarios";
            this.tbusuarios.ReadOnly = true;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbusuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.tbusuarios.RowHeadersVisible = false;
            this.tbusuarios.RowHeadersWidth = 30;
            this.tbusuarios.RowTemplate.Height = 40;
            this.tbusuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tbusuarios.Size = new System.Drawing.Size(918, 792);
            this.tbusuarios.TabIndex = 1;
            this.tbusuarios.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.tbusuarios.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.tbusuarios.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tbusuarios.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.tbusuarios.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.tbusuarios.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.tbusuarios.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.tbusuarios.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tbusuarios.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.tbusuarios.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tbusuarios.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbusuarios.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tbusuarios.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tbusuarios.ThemeStyle.HeaderStyle.Height = 50;
            this.tbusuarios.ThemeStyle.ReadOnly = true;
            this.tbusuarios.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tbusuarios.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tbusuarios.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbusuarios.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.tbusuarios.ThemeStyle.RowsStyle.Height = 40;
            this.tbusuarios.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tbusuarios.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.tbusuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbusuarios_CellContentClick);
            // 
            // tiendasTableAdapter1
            // 
            this.tiendasTableAdapter1.ClearBeforeFill = true;
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1436, 1013);
            this.Controls.Add(this.pntabla);
            this.Controls.Add(this.pnizquierda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUsuarios";
            this.Text = "frmUsuarios";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            this.pnizquierda.ResumeLayout(false);
            this.pninfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tiendasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._registerstore_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiendasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerstoreDataSet)).EndInit();
            this.pntabla.ResumeLayout(false);
            this.pntabla.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbusuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnizquierda;
        private Guna.UI2.WinForms.Guna2Button btcancelar;
        private Guna.UI2.WinForms.Guna2Button bteliminar;
        private Guna.UI2.WinForms.Guna2Button bteditar;
        private Guna.UI2.WinForms.Guna2Button btagregar;
        private System.Windows.Forms.Label lbid;
        private Guna.UI2.WinForms.Guna2Panel pninfo;
        private Guna.UI2.WinForms.Guna2TextBox txtclave;
        private Guna.UI2.WinForms.Guna2TextBox txtnombre;
        private System.Windows.Forms.Label lbtipo;
        private System.Windows.Forms.Label lbclave;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2ComboBox cbtipo;
        private Guna.UI2.WinForms.Guna2ComboBox cbtienda;
        private System.Windows.Forms.Label lbtienda;
        private registerstoreDataSet registerstoreDataSet;
        private System.Windows.Forms.BindingSource tiendasBindingSource;
        private registerstoreDataSetTableAdapters.tiendasTableAdapter tiendasTableAdapter;
        private Guna.UI2.WinForms.Guna2Panel pntabla;
        private System.Windows.Forms.Label lbiconoContador;
        private System.Windows.Forms.Label lbcontador;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator5;
        private System.Windows.Forms.Label lbproductos;
        public Guna.UI2.WinForms.Guna2TextBox txtbuscar;
        private Guna.UI2.WinForms.Guna2DataGridView tbusuarios;
        private _registerstore_dbDataSet _registerstore_dbDataSet;
        private System.Windows.Forms.BindingSource tiendasBindingSource1;
        private _registerstore_dbDataSetTableAdapters.tiendasTableAdapter tiendasTableAdapter1;
    }
}