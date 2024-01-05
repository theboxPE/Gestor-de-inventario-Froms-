namespace CapaPresentacion
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Cerrar1 = new System.Windows.Forms.Button();
            this.contraseña1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.usuario1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Registrar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.Cerrar1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 29);
            this.panel1.TabIndex = 1;
            // 
            // Cerrar1
            // 
            this.Cerrar1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Cerrar1.FlatAppearance.BorderSize = 0;
            this.Cerrar1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Cerrar1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Cerrar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cerrar1.Image = ((System.Drawing.Image)(resources.GetObject("Cerrar1.Image")));
            this.Cerrar1.Location = new System.Drawing.Point(316, 0);
            this.Cerrar1.Name = "Cerrar1";
            this.Cerrar1.Size = new System.Drawing.Size(39, 29);
            this.Cerrar1.TabIndex = 0;
            this.Cerrar1.UseVisualStyleBackColor = true;
            this.Cerrar1.Click += new System.EventHandler(this.Cerrar1_Click);
            // 
            // contraseña1
            // 
            this.contraseña1.BackColor = System.Drawing.Color.White;
            this.contraseña1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.contraseña1.Depth = 0;
            this.contraseña1.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contraseña1.ForeColor = System.Drawing.SystemColors.Control;
            this.contraseña1.Hint = "";
            this.contraseña1.Location = new System.Drawing.Point(124, 188);
            this.contraseña1.MouseState = MaterialSkin.MouseState.HOVER;
            this.contraseña1.Name = "contraseña1";
            this.contraseña1.PasswordChar = '\0';
            this.contraseña1.SelectedText = "";
            this.contraseña1.SelectionLength = 0;
            this.contraseña1.SelectionStart = 0;
            this.contraseña1.Size = new System.Drawing.Size(179, 23);
            this.contraseña1.TabIndex = 6;
            this.contraseña1.UseSystemPasswordChar = false;
            // 
            // usuario1
            // 
            this.usuario1.BackColor = System.Drawing.Color.White;
            this.usuario1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.usuario1.Depth = 0;
            this.usuario1.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuario1.ForeColor = System.Drawing.SystemColors.Control;
            this.usuario1.Hint = "";
            this.usuario1.Location = new System.Drawing.Point(124, 133);
            this.usuario1.MouseState = MaterialSkin.MouseState.HOVER;
            this.usuario1.Name = "usuario1";
            this.usuario1.PasswordChar = '\0';
            this.usuario1.SelectedText = "";
            this.usuario1.SelectionLength = 0;
            this.usuario1.SelectionStart = 0;
            this.usuario1.Size = new System.Drawing.Size(179, 23);
            this.usuario1.TabIndex = 7;
            this.usuario1.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "contraseña:";
            // 
            // Registrar
            // 
            this.Registrar.BackColor = System.Drawing.Color.Red;
            this.Registrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Registrar.FlatAppearance.BorderSize = 0;
            this.Registrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Registrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Registrar.Font = new System.Drawing.Font("Yu Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registrar.ForeColor = System.Drawing.Color.White;
            this.Registrar.Location = new System.Drawing.Point(93, 280);
            this.Registrar.Name = "Registrar";
            this.Registrar.Size = new System.Drawing.Size(151, 39);
            this.Registrar.TabIndex = 10;
            this.Registrar.Text = "Registrar";
            this.Registrar.UseVisualStyleBackColor = false;
            this.Registrar.Click += new System.EventHandler(this.Registrar_Click);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(355, 434);
            this.Controls.Add(this.Registrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usuario1);
            this.Controls.Add(this.contraseña1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registro";
            this.Text = "Registro";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Cerrar1;
        private MaterialSkin.Controls.MaterialSingleLineTextField contraseña1;
        private MaterialSkin.Controls.MaterialSingleLineTextField usuario1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Registrar;
    }
}