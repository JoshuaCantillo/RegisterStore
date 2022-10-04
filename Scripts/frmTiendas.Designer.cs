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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tlpderecha = new System.Windows.Forms.TableLayoutPanel();
            this.pninfo = new Guna.UI2.WinForms.Guna2Panel();
            this.lbpresentacion = new System.Windows.Forms.Label();
            this.txtnombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblaboratorio = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tlpIzquierda = new System.Windows.Forms.TableLayoutPanel();
            this.pntabla = new System.Windows.Forms.Panel();
            this.lbcontador = new System.Windows.Forms.Label();
            this.tbtiendas = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.lbid = new System.Windows.Forms.Label();
            this.txtbuscar = new Guna.UI2.WinForms.Guna2TextBox();
            this.btcancelar = new Guna.UI2.WinForms.Guna2Button();
            this.bteliminar = new Guna.UI2.WinForms.Guna2Button();
            this.bteditar = new Guna.UI2.WinForms.Guna2Button();
            this.btagregar = new Guna.UI2.WinForms.Guna2Button();
            this.iconoContador = new System.Windows.Forms.Label();
            this.lbbuscar = new System.Windows.Forms.Label();
            this.txtdireccion = new Guna.UI2.WinForms.Guna2TextBox();
            this.txttelefono = new Guna.UI2.WinForms.Guna2TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tlpderecha.SuspendLayout();
            this.pninfo.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tlpIzquierda.SuspendLayout();
            this.pntabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbtiendas)).BeginInit();
            this.guna2Panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 260F));
            this.tableLayoutPanel1.Controls.Add(this.tlpderecha, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tlpIzquierda, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 563F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1064, 563);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tlpderecha
            // 
            this.tlpderecha.ColumnCount = 1;
            this.tlpderecha.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpderecha.Controls.Add(this.pninfo, 0, 0);
            this.tlpderecha.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tlpderecha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpderecha.Location = new System.Drawing.Point(807, 3);
            this.tlpderecha.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.tlpderecha.Name = "tlpderecha";
            this.tlpderecha.RowCount = 2;
            this.tlpderecha.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 260F));
            this.tlpderecha.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpderecha.Size = new System.Drawing.Size(254, 550);
            this.tlpderecha.TabIndex = 2;
            // 
            // pninfo
            // 
            this.pninfo.BorderRadius = 10;
            this.pninfo.Controls.Add(this.txttelefono);
            this.pninfo.Controls.Add(this.txtdireccion);
            this.pninfo.Controls.Add(this.lbpresentacion);
            this.pninfo.Controls.Add(this.txtnombre);
            this.pninfo.Controls.Add(this.lblaboratorio);
            this.pninfo.Controls.Add(this.guna2Separator1);
            this.pninfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pninfo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.pninfo.Location = new System.Drawing.Point(10, 30);
            this.pninfo.Margin = new System.Windows.Forms.Padding(10, 30, 10, 10);
            this.pninfo.Name = "pninfo";
            this.pninfo.Size = new System.Drawing.Size(234, 220);
            this.pninfo.TabIndex = 0;
            // 
            // lbpresentacion
            // 
            this.lbpresentacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.lbpresentacion.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpresentacion.ForeColor = System.Drawing.Color.White;
            this.lbpresentacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbpresentacion.Location = new System.Drawing.Point(7, 60);
            this.lbpresentacion.Name = "lbpresentacion";
            this.lbpresentacion.Size = new System.Drawing.Size(218, 25);
            this.lbpresentacion.TabIndex = 21;
            this.lbpresentacion.Text = "DIRECCIÓN:";
            this.lbpresentacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtnombre
            // 
            this.txtnombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.txtnombre.BorderRadius = 5;
            this.txtnombre.BorderThickness = 0;
            this.txtnombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnombre.DefaultText = "";
            this.txtnombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.txtnombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.txtnombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnombre.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.txtnombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnombre.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.ForeColor = System.Drawing.Color.White;
            this.txtnombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnombre.Location = new System.Drawing.Point(9, 5);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.PasswordChar = '\0';
            this.txtnombre.PlaceholderText = "NOMBRE";
            this.txtnombre.SelectedText = "";
            this.txtnombre.Size = new System.Drawing.Size(216, 33);
            this.txtnombre.TabIndex = 19;
            this.txtnombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblaboratorio
            // 
            this.lblaboratorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.lblaboratorio.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaboratorio.ForeColor = System.Drawing.Color.White;
            this.lblaboratorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblaboratorio.Location = new System.Drawing.Point(7, 122);
            this.lblaboratorio.Name = "lblaboratorio";
            this.lblaboratorio.Size = new System.Drawing.Size(218, 25);
            this.lblaboratorio.TabIndex = 12;
            this.lblaboratorio.Text = "TELÉFONO:";
            this.lblaboratorio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Separator1.FillColor = System.Drawing.Color.White;
            this.guna2Separator1.FillThickness = 3;
            this.guna2Separator1.Location = new System.Drawing.Point(11, 37);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(208, 10);
            this.guna2Separator1.TabIndex = 11;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.btcancelar, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.bteliminar, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.bteditar, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btagregar, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 263);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(248, 284);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tlpIzquierda
            // 
            this.tlpIzquierda.ColumnCount = 1;
            this.tlpIzquierda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpIzquierda.Controls.Add(this.pntabla, 0, 1);
            this.tlpIzquierda.Controls.Add(this.guna2Panel4, 0, 0);
            this.tlpIzquierda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpIzquierda.Location = new System.Drawing.Point(0, 0);
            this.tlpIzquierda.Margin = new System.Windows.Forms.Padding(0);
            this.tlpIzquierda.Name = "tlpIzquierda";
            this.tlpIzquierda.RowCount = 2;
            this.tlpIzquierda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpIzquierda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tlpIzquierda.Size = new System.Drawing.Size(804, 563);
            this.tlpIzquierda.TabIndex = 1;
            // 
            // pntabla
            // 
            this.pntabla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pntabla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(74)))));
            this.pntabla.Controls.Add(this.iconoContador);
            this.pntabla.Controls.Add(this.lbcontador);
            this.pntabla.Controls.Add(this.tbtiendas);
            this.pntabla.Controls.Add(this.label2);
            this.pntabla.Location = new System.Drawing.Point(30, 84);
            this.pntabla.Margin = new System.Windows.Forms.Padding(30, 0, 30, 25);
            this.pntabla.Name = "pntabla";
            this.pntabla.Size = new System.Drawing.Size(744, 454);
            this.pntabla.TabIndex = 1;
            // 
            // lbcontador
            // 
            this.lbcontador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbcontador.AutoSize = true;
            this.lbcontador.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcontador.ForeColor = System.Drawing.Color.White;
            this.lbcontador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbcontador.Location = new System.Drawing.Point(695, 9);
            this.lbcontador.Name = "lbcontador";
            this.lbcontador.Size = new System.Drawing.Size(33, 37);
            this.lbcontador.TabIndex = 13;
            this.lbcontador.Text = "0";
            this.lbcontador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbtiendas
            // 
            this.tbtiendas.AllowUserToAddRows = false;
            this.tbtiendas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.tbtiendas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.tbtiendas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbtiendas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(74)))));
            this.tbtiendas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbtiendas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.tbtiendas.ColumnHeadersHeight = 30;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tbtiendas.DefaultCellStyle = dataGridViewCellStyle8;
            this.tbtiendas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(68)))));
            this.tbtiendas.Location = new System.Drawing.Point(0, 52);
            this.tbtiendas.Name = "tbtiendas";
            this.tbtiendas.ReadOnly = true;
            this.tbtiendas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbtiendas.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.tbtiendas.RowHeadersVisible = false;
            this.tbtiendas.RowHeadersWidth = 62;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.tbtiendas.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.tbtiendas.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(74)))));
            this.tbtiendas.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tbtiendas.RowTemplate.Height = 35;
            this.tbtiendas.Size = new System.Drawing.Size(744, 399);
            this.tbtiendas.TabIndex = 12;
            this.tbtiendas.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tbtiendas.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tbtiendas.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.tbtiendas.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tbtiendas.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.tbtiendas.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(74)))));
            this.tbtiendas.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(68)))));
            this.tbtiendas.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(74)))));
            this.tbtiendas.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tbtiendas.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbtiendas.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Gray;
            this.tbtiendas.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tbtiendas.ThemeStyle.HeaderStyle.Height = 30;
            this.tbtiendas.ThemeStyle.ReadOnly = true;
            this.tbtiendas.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(74)))));
            this.tbtiendas.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tbtiendas.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtiendas.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.tbtiendas.ThemeStyle.RowsStyle.Height = 35;
            this.tbtiendas.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tbtiendas.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.tbtiendas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbtiendas_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(13, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Registros de tiendas";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel4.BorderRadius = 10;
            this.guna2Panel4.Controls.Add(this.lbid);
            this.guna2Panel4.Controls.Add(this.txtbuscar);
            this.guna2Panel4.Controls.Add(this.lbbuscar);
            this.guna2Panel4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(74)))));
            this.guna2Panel4.Location = new System.Drawing.Point(30, 16);
            this.guna2Panel4.Margin = new System.Windows.Forms.Padding(30, 15, 30, 15);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(744, 51);
            this.guna2Panel4.TabIndex = 2;
            // 
            // lbid
            // 
            this.lbid.AutoSize = true;
            this.lbid.Location = new System.Drawing.Point(3, 22);
            this.lbid.Name = "lbid";
            this.lbid.Size = new System.Drawing.Size(24, 13);
            this.lbid.TabIndex = 17;
            this.lbid.Text = "lbId";
            this.lbid.Visible = false;
            // 
            // txtbuscar
            // 
            this.txtbuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbuscar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtbuscar.BorderRadius = 5;
            this.txtbuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbuscar.DefaultText = "";
            this.txtbuscar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbuscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbuscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbuscar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbuscar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(74)))));
            this.txtbuscar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtbuscar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbuscar.Location = new System.Drawing.Point(182, 13);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.PasswordChar = '\0';
            this.txtbuscar.PlaceholderText = "";
            this.txtbuscar.SelectedText = "";
            this.txtbuscar.Size = new System.Drawing.Size(475, 25);
            this.txtbuscar.TabIndex = 16;
            // 
            // btcancelar
            // 
            this.btcancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btcancelar.BorderRadius = 5;
            this.btcancelar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btcancelar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btcancelar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btcancelar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btcancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcancelar.ForeColor = System.Drawing.Color.White;
            this.btcancelar.Image = global::RegisterStore.Properties.Resources.icono_cancelar_blanco_32;
            this.btcancelar.ImageOffset = new System.Drawing.Point(2, 0);
            this.btcancelar.Location = new System.Drawing.Point(10, 216);
            this.btcancelar.Margin = new System.Windows.Forms.Padding(10, 3, 10, 10);
            this.btcancelar.Name = "btcancelar";
            this.btcancelar.Size = new System.Drawing.Size(228, 58);
            this.btcancelar.TabIndex = 3;
            this.btcancelar.Text = "CANCELAR";
            this.btcancelar.Click += new System.EventHandler(this.btcancelar_Click);
            // 
            // bteliminar
            // 
            this.bteliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bteliminar.BorderRadius = 5;
            this.bteliminar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bteliminar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bteliminar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bteliminar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bteliminar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bteliminar.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bteliminar.ForeColor = System.Drawing.Color.White;
            this.bteliminar.Image = global::RegisterStore.Properties.Resources.eliminar_blanco_48;
            this.bteliminar.Location = new System.Drawing.Point(10, 145);
            this.bteliminar.Margin = new System.Windows.Forms.Padding(10, 3, 10, 10);
            this.bteliminar.Name = "bteliminar";
            this.bteliminar.Size = new System.Drawing.Size(228, 58);
            this.bteliminar.TabIndex = 2;
            this.bteliminar.Text = "ELIMINAR";
            this.bteliminar.Click += new System.EventHandler(this.bteliminar_Click);
            // 
            // bteditar
            // 
            this.bteditar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bteditar.BorderRadius = 5;
            this.bteditar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bteditar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bteditar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bteditar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bteditar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bteditar.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bteditar.ForeColor = System.Drawing.Color.White;
            this.bteditar.Image = global::RegisterStore.Properties.Resources.editar_blanco_48;
            this.bteditar.ImageOffset = new System.Drawing.Point(-5, 0);
            this.bteditar.Location = new System.Drawing.Point(10, 74);
            this.bteditar.Margin = new System.Windows.Forms.Padding(10, 3, 10, 10);
            this.bteditar.Name = "bteditar";
            this.bteditar.Size = new System.Drawing.Size(228, 58);
            this.bteditar.TabIndex = 1;
            this.bteditar.Text = "EDITAR";
            this.bteditar.Click += new System.EventHandler(this.bteditar_Click);
            // 
            // btagregar
            // 
            this.btagregar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btagregar.BorderRadius = 5;
            this.btagregar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btagregar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btagregar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btagregar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btagregar.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.btagregar.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btagregar.ForeColor = System.Drawing.Color.White;
            this.btagregar.Image = global::RegisterStore.Properties.Resources.icono_agregar_blanco;
            this.btagregar.Location = new System.Drawing.Point(10, 3);
            this.btagregar.Margin = new System.Windows.Forms.Padding(10, 3, 10, 10);
            this.btagregar.Name = "btagregar";
            this.btagregar.Size = new System.Drawing.Size(228, 58);
            this.btagregar.TabIndex = 0;
            this.btagregar.Text = "AGREGAR";
            this.btagregar.Click += new System.EventHandler(this.btagregar_Click);
            // 
            // iconoContador
            // 
            this.iconoContador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconoContador.AutoSize = true;
            this.iconoContador.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconoContador.ForeColor = System.Drawing.Color.White;
            this.iconoContador.Image = global::RegisterStore.Properties.Resources.icons8_online_store_32;
            this.iconoContador.Location = new System.Drawing.Point(664, 9);
            this.iconoContador.Name = "iconoContador";
            this.iconoContador.Size = new System.Drawing.Size(25, 37);
            this.iconoContador.TabIndex = 14;
            this.iconoContador.Text = " ";
            this.iconoContador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbbuscar
            // 
            this.lbbuscar.BackColor = System.Drawing.Color.Transparent;
            this.lbbuscar.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbbuscar.ForeColor = System.Drawing.Color.White;
            this.lbbuscar.Image = global::RegisterStore.Properties.Resources.icono_buscar_blanco;
            this.lbbuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbbuscar.Location = new System.Drawing.Point(88, 13);
            this.lbbuscar.Name = "lbbuscar";
            this.lbbuscar.Size = new System.Drawing.Size(88, 25);
            this.lbbuscar.TabIndex = 15;
            this.lbbuscar.Text = "Buscar:";
            this.lbbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtdireccion
            // 
            this.txtdireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.txtdireccion.BorderRadius = 5;
            this.txtdireccion.BorderThickness = 0;
            this.txtdireccion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdireccion.DefaultText = "";
            this.txtdireccion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.txtdireccion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.txtdireccion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdireccion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdireccion.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.txtdireccion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdireccion.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtdireccion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdireccion.Location = new System.Drawing.Point(3, 90);
            this.txtdireccion.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.PasswordChar = '\0';
            this.txtdireccion.PlaceholderText = "ej. cll 0#0-0";
            this.txtdireccion.SelectedText = "";
            this.txtdireccion.Size = new System.Drawing.Size(228, 25);
            this.txtdireccion.TabIndex = 22;
            this.txtdireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txttelefono
            // 
            this.txttelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.txttelefono.BorderRadius = 5;
            this.txttelefono.BorderThickness = 0;
            this.txttelefono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttelefono.DefaultText = "";
            this.txttelefono.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.txttelefono.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.txttelefono.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttelefono.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttelefono.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.txttelefono.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttelefono.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txttelefono.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttelefono.Location = new System.Drawing.Point(12, 153);
            this.txttelefono.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.PasswordChar = '\0';
            this.txttelefono.PlaceholderText = "ej. 3101111111";
            this.txttelefono.SelectedText = "";
            this.txttelefono.Size = new System.Drawing.Size(207, 32);
            this.txttelefono.TabIndex = 23;
            this.txttelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txttelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttelefono_KeyPress_1);
            // 
            // frmTiendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1064, 563);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTiendas";
            this.Text = "frmTiendas";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tlpderecha.ResumeLayout(false);
            this.pninfo.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tlpIzquierda.ResumeLayout(false);
            this.pntabla.ResumeLayout(false);
            this.pntabla.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbtiendas)).EndInit();
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tlpderecha;
        private Guna.UI2.WinForms.Guna2Panel pninfo;
        private System.Windows.Forms.Label lbpresentacion;
        private Guna.UI2.WinForms.Guna2TextBox txtnombre;
        private System.Windows.Forms.Label lblaboratorio;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Guna.UI2.WinForms.Guna2Button btcancelar;
        private Guna.UI2.WinForms.Guna2Button bteliminar;
        private Guna.UI2.WinForms.Guna2Button bteditar;
        private Guna.UI2.WinForms.Guna2Button btagregar;
        private System.Windows.Forms.TableLayoutPanel tlpIzquierda;
        private System.Windows.Forms.Panel pntabla;
        private System.Windows.Forms.Label iconoContador;
        private System.Windows.Forms.Label lbcontador;
        private Guna.UI2.WinForms.Guna2DataGridView tbtiendas;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private System.Windows.Forms.Label lbid;
        private Guna.UI2.WinForms.Guna2TextBox txtbuscar;
        private System.Windows.Forms.Label lbbuscar;
        private Guna.UI2.WinForms.Guna2TextBox txttelefono;
        private Guna.UI2.WinForms.Guna2TextBox txtdireccion;
    }
}