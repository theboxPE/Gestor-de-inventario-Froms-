namespace CapaPresentacion
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Cerrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.usuario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.con = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.entrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.Cerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 29);
            this.panel1.TabIndex = 0;
            // 
            // Cerrar
            // 
            this.Cerrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Cerrar.FlatAppearance.BorderSize = 0;
            this.Cerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Cerrar.Image")));
            this.Cerrar.Location = new System.Drawing.Point(345, 0);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(39, 29);
            this.Cerrar.TabIndex = 0;
            this.Cerrar.UseVisualStyleBackColor = true;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(110, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // usuario
            // 
            this.usuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.usuario.Depth = 0;
            this.usuario.Font = new System.Drawing.Font("Yu Gothic Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuario.ForeColor = System.Drawing.SystemColors.Control;
            this.usuario.Hint = "";
            this.usuario.Location = new System.Drawing.Point(99, 221);
            this.usuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.usuario.Name = "usuario";
            this.usuario.PasswordChar = '\0';
            this.usuario.SelectedText = "";
            this.usuario.SelectionLength = 0;
            this.usuario.SelectionStart = 0;
            this.usuario.Size = new System.Drawing.Size(179, 23);
            this.usuario.TabIndex = 2;
            this.usuario.Text = "Ingrese su usuario:";
            this.usuario.UseSystemPasswordChar = false;
            // 
            // con
            // 
            this.con.BackColor = System.Drawing.Color.White;
            this.con.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.con.Depth = 0;
            this.con.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.con.ForeColor = System.Drawing.SystemColors.Control;
            this.con.Hint = "";
            this.con.Location = new System.Drawing.Point(99, 267);
            this.con.MouseState = MaterialSkin.MouseState.HOVER;
            this.con.Name = "con";
            this.con.PasswordChar = '\0';
            this.con.SelectedText = "";
            this.con.SelectionLength = 0;
            this.con.SelectionStart = 0;
            this.con.Size = new System.Drawing.Size(179, 23);
            this.con.TabIndex = 4;
            this.con.Text = "Ingrese su contraseña:";
            this.con.UseSystemPasswordChar = false;
            // 
            // entrar
            // 
            this.entrar.BackColor = System.Drawing.Color.Red;
            this.entrar.Cursor = System.Windows.Forms.Cursors.Default;
            this.entrar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.entrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.entrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.entrar.Font = new System.Drawing.Font("Yu Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entrar.ForeColor = System.Drawing.Color.White;
            this.entrar.Location = new System.Drawing.Point(99, 357);
            this.entrar.Name = "entrar";
            this.entrar.Size = new System.Drawing.Size(179, 39);
            this.entrar.TabIndex = 7;
            this.entrar.Text = "Entrar";
            this.entrar.UseVisualStyleBackColor = false;
            this.entrar.Click += new System.EventHandler(this.entrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 423);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "¿No estas registrado?";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(136, 459);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 26);
            this.button1.TabIndex = 9;
            this.button1.Text = "Registrarme";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 532);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.entrar);
            this.Controls.Add(this.con);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Cerrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField usuario;
        private MaterialSkin.Controls.MaterialSingleLineTextField con;
        private System.Windows.Forms.Button entrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

