namespace RegisterStore.Scripts
{
    partial class subfrmPedidos
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
            this.lbcontador = new System.Windows.Forms.Label();
            this.guna2Separator5 = new Guna.UI2.WinForms.Guna2Separator();
            this.lbpedidos = new System.Windows.Forms.Label();
            this.tbpedidos = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lbiconoContador = new System.Windows.Forms.Label();
            this.txtbuscar = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbpedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbcontador
            // 
            this.lbcontador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbcontador.AutoSize = true;
            this.lbcontador.BackColor = System.Drawing.Color.Transparent;
            this.lbcontador.Font = new System.Drawing.Font("Segoe UI", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcontador.ForeColor = System.Drawing.Color.Gray;
            this.lbcontador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbcontador.Location = new System.Drawing.Point(975, 22);
            this.lbcontador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbcontador.Name = "lbcontador";
            this.lbcontador.Size = new System.Drawing.Size(65, 74);
            this.lbcontador.TabIndex = 44;
            this.lbcontador.Text = "#";
            this.lbcontador.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // guna2Separator5
            // 
            this.guna2Separator5.BackColor = System.Drawing.Color.Transparent;
            this.guna2Separator5.FillColor = System.Drawing.Color.Gray;
            this.guna2Separator5.FillThickness = 3;
            this.guna2Separator5.Location = new System.Drawing.Point(469, 86);
            this.guna2Separator5.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Separator5.Name = "guna2Separator5";
            this.guna2Separator5.Size = new System.Drawing.Size(410, 10);
            this.guna2Separator5.TabIndex = 43;
            // 
            // lbpedidos
            // 
            this.lbpedidos.BackColor = System.Drawing.Color.Transparent;
            this.lbpedidos.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpedidos.ForeColor = System.Drawing.Color.Gray;
            this.lbpedidos.Location = new System.Drawing.Point(11, 19);
            this.lbpedidos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbpedidos.Name = "lbpedidos";
            this.lbpedidos.Size = new System.Drawing.Size(318, 77);
            this.lbpedidos.TabIndex = 42;
            this.lbpedidos.Text = "PEDIDOS";
            this.lbpedidos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbpedidos
            // 
            this.tbpedidos.AllowUserToAddRows = false;
            this.tbpedidos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.tbpedidos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tbpedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbpedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tbpedidos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.tbpedidos.BackgroundColor = System.Drawing.Color.White;
            this.tbpedidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbpedidos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tbpedidos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbpedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tbpedidos.ColumnHeadersHeight = 50;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tbpedidos.DefaultCellStyle = dataGridViewCellStyle3;
            this.tbpedidos.EnableHeadersVisualStyles = false;
            this.tbpedidos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tbpedidos.Location = new System.Drawing.Point(26, 111);
            this.tbpedidos.Name = "tbpedidos";
            this.tbpedidos.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbpedidos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.tbpedidos.RowHeadersVisible = false;
            this.tbpedidos.RowHeadersWidth = 30;
            this.tbpedidos.RowTemplate.Height = 40;
            this.tbpedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tbpedidos.Size = new System.Drawing.Size(1002, 411);
            this.tbpedidos.TabIndex = 40;
            this.tbpedidos.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.tbpedidos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.tbpedidos.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tbpedidos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.tbpedidos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.tbpedidos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.tbpedidos.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.tbpedidos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tbpedidos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.tbpedidos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tbpedidos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpedidos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tbpedidos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tbpedidos.ThemeStyle.HeaderStyle.Height = 50;
            this.tbpedidos.ThemeStyle.ReadOnly = true;
            this.tbpedidos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tbpedidos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tbpedidos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpedidos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.tbpedidos.ThemeStyle.RowsStyle.Height = 40;
            this.tbpedidos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tbpedidos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.tbpedidos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbpedidos_CellDoubleClick);
            // 
            // lbiconoContador
            // 
            this.lbiconoContador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbiconoContador.BackColor = System.Drawing.Color.Transparent;
            this.lbiconoContador.Font = new System.Drawing.Font("Segoe UI", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbiconoContador.ForeColor = System.Drawing.Color.Gray;
            this.lbiconoContador.Image = global::RegisterStore.Properties.Resources.contador_icono_48;
            this.lbiconoContador.Location = new System.Drawing.Point(906, 22);
            this.lbiconoContador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbiconoContador.Name = "lbiconoContador";
            this.lbiconoContador.Size = new System.Drawing.Size(65, 74);
            this.lbiconoContador.TabIndex = 45;
            this.lbiconoContador.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.txtbuscar.FillColor = System.Drawing.SystemColors.Control;
            this.txtbuscar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbuscar.FocusedState.Parent = this.txtbuscar;
            this.txtbuscar.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtbuscar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbuscar.HoverState.Parent = this.txtbuscar;
            this.txtbuscar.IconLeft = global::RegisterStore.Properties.Resources.buscar_32;
            this.txtbuscar.IconLeftOffset = new System.Drawing.Point(20, 0);
            this.txtbuscar.IconLeftSize = new System.Drawing.Size(25, 25);
            this.txtbuscar.Location = new System.Drawing.Point(469, 34);
            this.txtbuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.PasswordChar = '\0';
            this.txtbuscar.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtbuscar.PlaceholderText = "BUSCAR PEDIDOS";
            this.txtbuscar.SelectedText = "";
            this.txtbuscar.ShadowDecoration.Parent = this.txtbuscar;
            this.txtbuscar.Size = new System.Drawing.Size(410, 50);
            this.txtbuscar.TabIndex = 41;
            this.txtbuscar.TextOffset = new System.Drawing.Point(10, 0);
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // subfrmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 541);
            this.Controls.Add(this.lbiconoContador);
            this.Controls.Add(this.lbcontador);
            this.Controls.Add(this.guna2Separator5);
            this.Controls.Add(this.lbpedidos);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.tbpedidos);
            this.Name = "subfrmPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "subfrmPedidos";
            ((System.ComponentModel.ISupportInitialize)(this.tbpedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbiconoContador;
        private System.Windows.Forms.Label lbcontador;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator5;
        private System.Windows.Forms.Label lbpedidos;
        private Guna.UI2.WinForms.Guna2TextBox txtbuscar;
        private Guna.UI2.WinForms.Guna2DataGridView tbpedidos;
    }
}