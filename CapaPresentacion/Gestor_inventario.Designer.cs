namespace CapaPresentacion
{
    partial class Gestor_inventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestor_inventario));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBusqueda = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCan = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDescri = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrecio = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtid = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.BtnVolver);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(899, 75);
            this.panel1.TabIndex = 0;
            // 
            // BtnVolver
            // 
            this.BtnVolver.BackColor = System.Drawing.Color.White;
            this.BtnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnVolver.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnVolver.FlatAppearance.BorderSize = 0;
            this.BtnVolver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnVolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnVolver.Image = ((System.Drawing.Image)(resources.GetObject("BtnVolver.Image")));
            this.BtnVolver.Location = new System.Drawing.Point(767, 12);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(57, 50);
            this.BtnVolver.TabIndex = 2;
            this.BtnVolver.UseVisualStyleBackColor = false;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.White;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(830, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(57, 50);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(530, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema de gestion de inventario";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnEditar);
            this.panel5.Controls.Add(this.btnRegistro);
            this.panel5.Controls.Add(this.btnEliminar);
            this.panel5.Controls.Add(this.btnLimpiar);
            this.panel5.Location = new System.Drawing.Point(6, 300);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(325, 48);
            this.panel5.TabIndex = 0;
            // 
            // btnEditar
            // 
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(169, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 37);
            this.btnEditar.TabIndex = 11;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnRegistro
            // 
            this.btnRegistro.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnRegistro.FlatAppearance.BorderSize = 0;
            this.btnRegistro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnRegistro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnRegistro.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistro.Image")));
            this.btnRegistro.Location = new System.Drawing.Point(88, 4);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(75, 37);
            this.btnRegistro.TabIndex = 10;
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(250, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(67, 37);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.Location = new System.Drawing.Point(7, 4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 37);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel2.Controls.Add(this.txtBusqueda);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(334, 51);
            this.panel2.TabIndex = 1;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Depth = 0;
            this.txtBusqueda.Hint = "";
            this.txtBusqueda.Location = new System.Drawing.Point(65, 11);
            this.txtBusqueda.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.PasswordChar = '\0';
            this.txtBusqueda.SelectedText = "";
            this.txtBusqueda.SelectionLength = 0;
            this.txtBusqueda.SelectionStart = 0;
            this.txtBusqueda.Size = new System.Drawing.Size(258, 23);
            this.txtBusqueda.TabIndex = 1;
            this.txtBusqueda.UseSystemPasswordChar = false;
            this.txtBusqueda.Click += new System.EventHandler(this.txtBusqueda_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Buscar:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(352, 81);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(547, 418);
            this.panel3.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(547, 418);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Descripcion producto:";
            // 
            // txtCan
            // 
            this.txtCan.BackColor = System.Drawing.Color.White;
            this.txtCan.Depth = 0;
            this.txtCan.Hint = "";
            this.txtCan.Location = new System.Drawing.Point(113, 224);
            this.txtCan.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCan.Name = "txtCan";
            this.txtCan.PasswordChar = '\0';
            this.txtCan.SelectedText = "";
            this.txtCan.SelectionLength = 0;
            this.txtCan.SelectionStart = 0;
            this.txtCan.Size = new System.Drawing.Size(88, 23);
            this.txtCan.TabIndex = 4;
            this.txtCan.UseSystemPasswordChar = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre producto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Id:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel4.Controls.Add(this.txtid);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.txtNombre);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.txtDescri);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.txtPrecio);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.txtCan);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(12, 138);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(334, 361);
            this.panel4.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(49, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(223, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Ingrese los datos de los producto";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.Depth = 0;
            this.txtNombre.Hint = "";
            this.txtNombre.Location = new System.Drawing.Point(108, 107);
            this.txtNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.Size = new System.Drawing.Size(212, 23);
            this.txtNombre.TabIndex = 10;
            this.txtNombre.UseSystemPasswordChar = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Cantidad producto:";
            // 
            // txtDescri
            // 
            this.txtDescri.BackColor = System.Drawing.Color.White;
            this.txtDescri.Depth = 0;
            this.txtDescri.Hint = "";
            this.txtDescri.Location = new System.Drawing.Point(127, 150);
            this.txtDescri.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDescri.Name = "txtDescri";
            this.txtDescri.PasswordChar = '\0';
            this.txtDescri.SelectedText = "";
            this.txtDescri.SelectionLength = 0;
            this.txtDescri.SelectionStart = 0;
            this.txtDescri.Size = new System.Drawing.Size(193, 23);
            this.txtDescri.TabIndex = 8;
            this.txtDescri.UseSystemPasswordChar = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Precio producto:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.White;
            this.txtPrecio.Depth = 0;
            this.txtPrecio.Hint = "";
            this.txtPrecio.Location = new System.Drawing.Point(101, 189);
            this.txtPrecio.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.PasswordChar = '\0';
            this.txtPrecio.SelectedText = "";
            this.txtPrecio.SelectionLength = 0;
            this.txtPrecio.SelectionStart = 0;
            this.txtPrecio.Size = new System.Drawing.Size(100, 23);
            this.txtPrecio.TabIndex = 6;
            this.txtPrecio.UseSystemPasswordChar = false;
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(35, 75);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 12;
            // 
            // Gestor_inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(899, 511);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Gestor_inventario";
            this.Text = "Gestor_inventario";
            this.Load += new System.EventHandler(this.Gestor_inventario_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBusqueda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCan;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPrecio;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombre;
        private System.Windows.Forms.Label label7;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDescri;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button BtnVolver;
        private System.Windows.Forms.TextBox txtid;
    }
}