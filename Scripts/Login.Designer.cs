namespace RegisterStore.Scripts
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pninfo = new Guna.UI2.WinForms.Guna2Panel();
            this.lberror = new System.Windows.Forms.Label();
            this.lbclave = new System.Windows.Forms.Label();
            this.lbusuario = new System.Windows.Forms.Label();
            this.btver = new Guna.UI2.WinForms.Guna2Button();
            this.btingresar = new Guna.UI2.WinForms.Guna2Button();
            this.txtclave = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtusuario = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblogin = new System.Windows.Forms.Label();
            this.btcerrar = new Guna.UI2.WinForms.Guna2CircleButton();
            this.pnimg = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pninfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pninfo
            // 
            this.pninfo.Controls.Add(this.lberror);
            this.pninfo.Controls.Add(this.lbclave);
            this.pninfo.Controls.Add(this.lbusuario);
            this.pninfo.Controls.Add(this.btver);
            this.pninfo.Controls.Add(this.btingresar);
            this.pninfo.Controls.Add(this.txtclave);
            this.pninfo.Controls.Add(this.txtusuario);
            this.pninfo.Controls.Add(this.lblogin);
            this.pninfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pninfo.Location = new System.Drawing.Point(0, 0);
            this.pninfo.Name = "pninfo";
            this.pninfo.Size = new System.Drawing.Size(251, 400);
            this.pninfo.TabIndex = 2;
            // 
            // lberror
            // 
            this.lberror.AutoSize = true;
            this.lberror.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lberror.ForeColor = System.Drawing.Color.Red;
            this.lberror.Location = new System.Drawing.Point(58, 230);
            this.lberror.Name = "lberror";
            this.lberror.Size = new System.Drawing.Size(134, 19);
            this.lberror.TabIndex = 11;
            this.lberror.Text = "Verifique sus datos";
            // 
            // lbclave
            // 
            this.lbclave.AutoSize = true;
            this.lbclave.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbclave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(178)))), ((int)(((byte)(173)))));
            this.lbclave.Location = new System.Drawing.Point(66, 169);
            this.lbclave.Name = "lbclave";
            this.lbclave.Size = new System.Drawing.Size(118, 25);
            this.lbclave.TabIndex = 10;
            this.lbclave.Text = "Contraseña:";
            // 
            // lbusuario
            // 
            this.lbusuario.AutoSize = true;
            this.lbusuario.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbusuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(178)))), ((int)(((byte)(173)))));
            this.lbusuario.Location = new System.Drawing.Point(82, 92);
            this.lbusuario.Name = "lbusuario";
            this.lbusuario.Size = new System.Drawing.Size(86, 25);
            this.lbusuario.TabIndex = 9;
            this.lbusuario.Text = "Usuario:";
            // 
            // btver
            // 
            this.btver.Animated = true;
            this.btver.BackColor = System.Drawing.Color.Transparent;
            this.btver.BorderColor = System.Drawing.Color.Transparent;
            this.btver.BorderRadius = 10;
            this.btver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btver.FillColor = System.Drawing.Color.Transparent;
            this.btver.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btver.ForeColor = System.Drawing.Color.White;
            this.btver.Image = global::RegisterStore.Properties.Resources.icono_ver_rosado;
            this.btver.Location = new System.Drawing.Point(202, 200);
            this.btver.Margin = new System.Windows.Forms.Padding(0);
            this.btver.Name = "btver";
            this.btver.PressedColor = System.Drawing.Color.Transparent;
            this.btver.Size = new System.Drawing.Size(25, 25);
            this.btver.TabIndex = 8;
            this.btver.UseTransparentBackground = true;
            this.btver.Click += new System.EventHandler(this.btver_Click);
            // 
            // btingresar
            // 
            this.btingresar.Animated = true;
            this.btingresar.AutoRoundedCorners = true;
            this.btingresar.BorderColor = System.Drawing.Color.Transparent;
            this.btingresar.BorderRadius = 19;
            this.btingresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btingresar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btingresar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btingresar.ForeColor = System.Drawing.Color.White;
            this.btingresar.Location = new System.Drawing.Point(47, 270);
            this.btingresar.Name = "btingresar";
            this.btingresar.Size = new System.Drawing.Size(156, 40);
            this.btingresar.TabIndex = 6;
            this.btingresar.Text = "INGRESAR";
            this.btingresar.Click += new System.EventHandler(this.btingresar_Click);
            // 
            // txtclave
            // 
            this.txtclave.Animated = true;
            this.txtclave.AutoRoundedCorners = true;
            this.txtclave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtclave.BorderRadius = 14;
            this.txtclave.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtclave.DefaultText = "";
            this.txtclave.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtclave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtclave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtclave.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtclave.FillColor = System.Drawing.Color.Transparent;
            this.txtclave.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtclave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtclave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtclave.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtclave.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.txtclave.Location = new System.Drawing.Point(25, 197);
            this.txtclave.Name = "txtclave";
            this.txtclave.PasswordChar = '●';
            this.txtclave.PlaceholderText = "";
            this.txtclave.SelectedText = "";
            this.txtclave.Size = new System.Drawing.Size(200, 30);
            this.txtclave.TabIndex = 5;
            this.txtclave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtclave.UseSystemPasswordChar = true;
            this.txtclave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtclave_KeyPress);
            // 
            // txtusuario
            // 
            this.txtusuario.Animated = true;
            this.txtusuario.AutoRoundedCorners = true;
            this.txtusuario.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtusuario.BorderRadius = 14;
            this.txtusuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtusuario.DefaultText = "";
            this.txtusuario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtusuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtusuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtusuario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtusuario.FillColor = System.Drawing.Color.Transparent;
            this.txtusuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtusuario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtusuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtusuario.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtusuario.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.txtusuario.Location = new System.Drawing.Point(25, 120);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.PasswordChar = '\0';
            this.txtusuario.PlaceholderText = "";
            this.txtusuario.SelectedText = "";
            this.txtusuario.Size = new System.Drawing.Size(200, 30);
            this.txtusuario.TabIndex = 3;
            this.txtusuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtusuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtusuario_KeyPress);
            // 
            // lblogin
            // 
            this.lblogin.AutoSize = true;
            this.lblogin.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(178)))), ((int)(((byte)(173)))));
            this.lblogin.Location = new System.Drawing.Point(67, 10);
            this.lblogin.Name = "lblogin";
            this.lblogin.Size = new System.Drawing.Size(117, 45);
            this.lblogin.TabIndex = 0;
            this.lblogin.Text = "LOGIN";
            // 
            // btcerrar
            // 
            this.btcerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.btcerrar.BorderColor = System.Drawing.Color.Transparent;
            this.btcerrar.FillColor = System.Drawing.Color.Transparent;
            this.btcerrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btcerrar.ForeColor = System.Drawing.Color.White;
            this.btcerrar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btcerrar.Location = new System.Drawing.Point(567, 2);
            this.btcerrar.Name = "btcerrar";
            this.btcerrar.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btcerrar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btcerrar.Size = new System.Drawing.Size(31, 32);
            this.btcerrar.TabIndex = 0;
            this.btcerrar.Text = "X";
            this.btcerrar.Click += new System.EventHandler(this.btcerrar_Click);
            // 
            // pnimg
            // 
            this.pnimg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnimg.BackgroundImage")));
            this.pnimg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnimg.Location = new System.Drawing.Point(249, 0);
            this.pnimg.Name = "pnimg";
            this.pnimg.Size = new System.Drawing.Size(319, 400);
            this.pnimg.TabIndex = 3;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.btcerrar);
            this.Controls.Add(this.pnimg);
            this.Controls.Add(this.pninfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.pninfo.ResumeLayout(false);
            this.pninfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pninfo;
        private System.Windows.Forms.Label lberror;
        private System.Windows.Forms.Label lbclave;
        private System.Windows.Forms.Label lbusuario;
        private Guna.UI2.WinForms.Guna2Button btver;
        private Guna.UI2.WinForms.Guna2Button btingresar;
        private Guna.UI2.WinForms.Guna2TextBox txtclave;
        private Guna.UI2.WinForms.Guna2TextBox txtusuario;
        private System.Windows.Forms.Label lblogin;
        private Guna.UI2.WinForms.Guna2Panel pnimg;
        private Guna.UI2.WinForms.Guna2CircleButton btcerrar;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}