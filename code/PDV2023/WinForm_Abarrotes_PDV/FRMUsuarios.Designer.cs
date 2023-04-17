namespace WinForm_Abarrotes_PDV
{
    partial class FRMUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMUsuarios));
            btnElimianrUsuarios = new Button();
            buttonGuardarUsuarios = new Button();
            txtusuarios = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtpasswordusuario = new TextBox();
            txtcorreousuario = new TextBox();
            txtnombreusuario = new TextBox();
            label1 = new Label();
            txtimagenusuario = new TextBox();
            buttonBuscar = new Button();
            textoUsuarios = new Label();
            textBoxbuscarusuario = new TextBox();
            dataGridView1 = new DataGridView();
            IDusuarios = new DataGridViewTextBoxColumn();
            NombreUsuarios = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Contraseña = new DataGridViewTextBoxColumn();
            Imagen = new DataGridViewTextBoxColumn();
            buttonEditarUsuarios = new Button();
            txtID = new Label();
            textBoxIDusuario = new TextBox();
            buttoncancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnElimianrUsuarios
            // 
            btnElimianrUsuarios.BackColor = Color.FromArgb(88, 161, 200);
            btnElimianrUsuarios.FlatAppearance.BorderSize = 0;
            btnElimianrUsuarios.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btnElimianrUsuarios.FlatStyle = FlatStyle.Flat;
            btnElimianrUsuarios.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnElimianrUsuarios.ForeColor = Color.White;
            btnElimianrUsuarios.Image = (Image)resources.GetObject("btnElimianrUsuarios.Image");
            btnElimianrUsuarios.ImageAlign = ContentAlignment.MiddleLeft;
            btnElimianrUsuarios.Location = new Point(22, 244);
            btnElimianrUsuarios.Margin = new Padding(4, 3, 4, 3);
            btnElimianrUsuarios.Name = "btnElimianrUsuarios";
            btnElimianrUsuarios.Size = new Size(137, 52);
            btnElimianrUsuarios.TabIndex = 40;
            btnElimianrUsuarios.Text = "   Eliminar";
            btnElimianrUsuarios.UseVisualStyleBackColor = false;
            btnElimianrUsuarios.Click += btnElimianrUsuarios_Click;
            // 
            // buttonGuardarUsuarios
            // 
            buttonGuardarUsuarios.BackColor = Color.FromArgb(88, 161, 200);
            buttonGuardarUsuarios.FlatAppearance.BorderSize = 0;
            buttonGuardarUsuarios.FlatAppearance.MouseOverBackColor = Color.Green;
            buttonGuardarUsuarios.FlatStyle = FlatStyle.Flat;
            buttonGuardarUsuarios.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonGuardarUsuarios.ForeColor = Color.White;
            buttonGuardarUsuarios.Image = (Image)resources.GetObject("buttonGuardarUsuarios.Image");
            buttonGuardarUsuarios.ImageAlign = ContentAlignment.MiddleLeft;
            buttonGuardarUsuarios.Location = new Point(636, 334);
            buttonGuardarUsuarios.Margin = new Padding(4, 3, 4, 3);
            buttonGuardarUsuarios.Name = "buttonGuardarUsuarios";
            buttonGuardarUsuarios.Size = new Size(148, 52);
            buttonGuardarUsuarios.TabIndex = 39;
            buttonGuardarUsuarios.Text = "   Guardar";
            buttonGuardarUsuarios.UseVisualStyleBackColor = false;
            buttonGuardarUsuarios.Click += buttonGuardarUsuarios_Click;
            // 
            // txtusuarios
            // 
            txtusuarios.AutoSize = true;
            txtusuarios.Font = new Font("Century Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtusuarios.Location = new Point(327, -1);
            txtusuarios.Margin = new Padding(4, 0, 4, 0);
            txtusuarios.Name = "txtusuarios";
            txtusuarios.Size = new Size(300, 36);
            txtusuarios.TabIndex = 38;
            txtusuarios.Text = "Registro De Usuarios";
            txtusuarios.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(495, 85);
            label5.Name = "label5";
            label5.Size = new Size(84, 17);
            label5.TabIndex = 37;
            label5.Text = "Contraseña";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(359, 85);
            label4.Name = "label4";
            label4.Size = new Size(53, 17);
            label4.TabIndex = 36;
            label4.Text = "Correo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(201, 85);
            label3.Name = "label3";
            label3.Size = new Size(61, 17);
            label3.TabIndex = 35;
            label3.Text = "Nombre";
            // 
            // txtpasswordusuario
            // 
            txtpasswordusuario.Location = new Point(483, 112);
            txtpasswordusuario.Margin = new Padding(3, 2, 3, 2);
            txtpasswordusuario.Name = "txtpasswordusuario";
            txtpasswordusuario.Size = new Size(110, 23);
            txtpasswordusuario.TabIndex = 34;
            // 
            // txtcorreousuario
            // 
            txtcorreousuario.Location = new Point(329, 112);
            txtcorreousuario.Margin = new Padding(3, 2, 3, 2);
            txtcorreousuario.Name = "txtcorreousuario";
            txtcorreousuario.Size = new Size(110, 23);
            txtcorreousuario.TabIndex = 33;
            // 
            // txtnombreusuario
            // 
            txtnombreusuario.Location = new Point(180, 112);
            txtnombreusuario.Margin = new Padding(3, 2, 3, 2);
            txtnombreusuario.Name = "txtnombreusuario";
            txtnombreusuario.Size = new Size(110, 23);
            txtnombreusuario.TabIndex = 32;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(669, 85);
            label1.Name = "label1";
            label1.Size = new Size(58, 17);
            label1.TabIndex = 42;
            label1.Text = "imagen";
            // 
            // txtimagenusuario
            // 
            txtimagenusuario.Location = new Point(627, 112);
            txtimagenusuario.Margin = new Padding(3, 2, 3, 2);
            txtimagenusuario.Name = "txtimagenusuario";
            txtimagenusuario.Size = new Size(153, 23);
            txtimagenusuario.TabIndex = 41;
            // 
            // buttonBuscar
            // 
            buttonBuscar.BackColor = Color.FromArgb(88, 161, 200);
            buttonBuscar.FlatAppearance.BorderSize = 0;
            buttonBuscar.FlatAppearance.MouseOverBackColor = Color.Green;
            buttonBuscar.FlatStyle = FlatStyle.Flat;
            buttonBuscar.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonBuscar.ForeColor = Color.White;
            buttonBuscar.Image = (Image)resources.GetObject("buttonBuscar.Image");
            buttonBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            buttonBuscar.Location = new Point(636, 48);
            buttonBuscar.Margin = new Padding(4, 3, 4, 3);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(28, 24);
            buttonBuscar.TabIndex = 50;
            buttonBuscar.UseVisualStyleBackColor = false;
            buttonBuscar.Click += buttonBuscar_Click;
            buttonBuscar.KeyPress += buttonBuscar_KeyPress;
            // 
            // textoUsuarios
            // 
            textoUsuarios.AutoSize = true;
            textoUsuarios.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textoUsuarios.ForeColor = Color.White;
            textoUsuarios.Location = new Point(289, 49);
            textoUsuarios.Margin = new Padding(4, 0, 4, 0);
            textoUsuarios.Name = "textoUsuarios";
            textoUsuarios.Size = new Size(86, 24);
            textoUsuarios.TabIndex = 49;
            textoUsuarios.Text = "Usuario:";
            // 
            // textBoxbuscarusuario
            // 
            textBoxbuscarusuario.Location = new Point(405, 49);
            textBoxbuscarusuario.Name = "textBoxbuscarusuario";
            textBoxbuscarusuario.Size = new Size(225, 23);
            textBoxbuscarusuario.TabIndex = 48;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IDusuarios, NombreUsuarios, Correo, Contraseña, Imagen });
            dataGridView1.Location = new Point(180, 140);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(600, 188);
            dataGridView1.TabIndex = 51;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // IDusuarios
            // 
            IDusuarios.HeaderText = "ID";
            IDusuarios.Name = "IDusuarios";
            // 
            // NombreUsuarios
            // 
            NombreUsuarios.HeaderText = "Nombre";
            NombreUsuarios.Name = "NombreUsuarios";
            // 
            // Correo
            // 
            Correo.HeaderText = "Correo";
            Correo.Name = "Correo";
            // 
            // Contraseña
            // 
            Contraseña.HeaderText = "Contraseña";
            Contraseña.Name = "Contraseña";
            // 
            // Imagen
            // 
            Imagen.HeaderText = "Imagen";
            Imagen.Name = "Imagen";
            // 
            // buttonEditarUsuarios
            // 
            buttonEditarUsuarios.BackColor = Color.FromArgb(88, 161, 200);
            buttonEditarUsuarios.FlatAppearance.BorderSize = 0;
            buttonEditarUsuarios.FlatAppearance.MouseOverBackColor = Color.Green;
            buttonEditarUsuarios.FlatStyle = FlatStyle.Flat;
            buttonEditarUsuarios.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEditarUsuarios.ForeColor = Color.White;
            buttonEditarUsuarios.Image = (Image)resources.GetObject("buttonEditarUsuarios.Image");
            buttonEditarUsuarios.ImageAlign = ContentAlignment.MiddleLeft;
            buttonEditarUsuarios.Location = new Point(405, 334);
            buttonEditarUsuarios.Margin = new Padding(4, 3, 4, 3);
            buttonEditarUsuarios.Name = "buttonEditarUsuarios";
            buttonEditarUsuarios.Size = new Size(148, 52);
            buttonEditarUsuarios.TabIndex = 52;
            buttonEditarUsuarios.Text = "   Editar";
            buttonEditarUsuarios.UseVisualStyleBackColor = false;
            buttonEditarUsuarios.Click += buttonEditarUsuarios_Click;
            // 
            // txtID
            // 
            txtID.AutoSize = true;
            txtID.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtID.Location = new Point(60, 159);
            txtID.Name = "txtID";
            txtID.Size = new Size(71, 17);
            txtID.TabIndex = 54;
            txtID.Text = "ID Usuario";
            // 
            // textBoxIDusuario
            // 
            textBoxIDusuario.Location = new Point(39, 186);
            textBoxIDusuario.Margin = new Padding(3, 2, 3, 2);
            textBoxIDusuario.Name = "textBoxIDusuario";
            textBoxIDusuario.Size = new Size(110, 23);
            textBoxIDusuario.TabIndex = 53;
            // 
            // buttoncancelar
            // 
            buttoncancelar.BackColor = Color.FromArgb(88, 161, 200);
            buttoncancelar.FlatAppearance.BorderSize = 0;
            buttoncancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            buttoncancelar.FlatStyle = FlatStyle.Flat;
            buttoncancelar.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttoncancelar.ForeColor = Color.White;
            buttoncancelar.Image = (Image)resources.GetObject("buttoncancelar.Image");
            buttoncancelar.ImageAlign = ContentAlignment.MiddleLeft;
            buttoncancelar.Location = new Point(201, 334);
            buttoncancelar.Margin = new Padding(4, 3, 4, 3);
            buttoncancelar.Name = "buttoncancelar";
            buttoncancelar.Size = new Size(137, 52);
            buttoncancelar.TabIndex = 55;
            buttoncancelar.Text = "   Cancelar";
            buttoncancelar.UseVisualStyleBackColor = false;
            buttoncancelar.Click += buttoncancelar_Click;
            // 
            // FRMUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 81, 209);
            ClientSize = new Size(924, 537);
            Controls.Add(buttoncancelar);
            Controls.Add(txtID);
            Controls.Add(textBoxIDusuario);
            Controls.Add(buttonEditarUsuarios);
            Controls.Add(dataGridView1);
            Controls.Add(buttonBuscar);
            Controls.Add(textoUsuarios);
            Controls.Add(textBoxbuscarusuario);
            Controls.Add(label1);
            Controls.Add(txtimagenusuario);
            Controls.Add(btnElimianrUsuarios);
            Controls.Add(buttonGuardarUsuarios);
            Controls.Add(txtusuarios);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtpasswordusuario);
            Controls.Add(txtcorreousuario);
            Controls.Add(txtnombreusuario);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FRMUsuarios";
            Text = "Usuarios";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnElimianrUsuarios;
        private Button buttonGuardarUsuarios;
        private Label txtusuarios;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtpasswordusuario;
        private TextBox txtcorreousuario;
        private TextBox txtnombreusuario;
        private Label label1;
        private TextBox txtimagenusuario;
        private Button buttonBuscar;
        private Label textoUsuarios;
        private TextBox textBoxbuscarusuario;
        private DataGridView dataGridView1;
        private Button buttonEditarUsuarios;
        private Label txtID;
        private TextBox textBoxIDusuario;
        private DataGridViewTextBoxColumn IDusuarios;
        private DataGridViewTextBoxColumn NombreUsuarios;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Contraseña;
        private DataGridViewTextBoxColumn Imagen;
        private Button buttoncancelar;
    }
}