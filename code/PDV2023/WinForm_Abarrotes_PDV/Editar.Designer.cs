namespace pruebaVENTA
{
    partial class Editar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editar));
            txtProductos = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            txtMarca = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            comboPresentacion = new ComboBox();
            txtImagen = new TextBox();
            txtCodBarras = new TextBox();
            txtPrecio = new TextBox();
            txtDesc = new TextBox();
            txtNom = new TextBox();
            btnCancelarEditar = new Button();
            btnAceptarEditar = new Button();
            buttonBuscar = new Button();
            label8 = new Label();
            textBoxbuscar = new TextBox();
            dataGridProductos = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Precion = new DataGridViewTextBoxColumn();
            Cod_Barras = new DataGridViewTextBoxColumn();
            Imagen = new DataGridViewTextBoxColumn();
            Marca = new DataGridViewTextBoxColumn();
            PresentacionProducto = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridProductos).BeginInit();
            SuspendLayout();
            // 
            // txtProductos
            // 
            txtProductos.AutoSize = true;
            txtProductos.Font = new Font("Century Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtProductos.Location = new Point(401, 9);
            txtProductos.Margin = new Padding(4, 0, 4, 0);
            txtProductos.Name = "txtProductos";
            txtProductos.Size = new Size(157, 36);
            txtProductos.TabIndex = 2;
            txtProductos.Text = "Productos";
            txtProductos.TextAlign = ContentAlignment.TopCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(826, 124);
            label7.Name = "label7";
            label7.Size = new Size(91, 17);
            label7.TabIndex = 27;
            label7.Text = "Presentacion";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(693, 124);
            label6.Name = "label6";
            label6.Size = new Size(49, 17);
            label6.TabIndex = 26;
            label6.Text = "Marca";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(559, 124);
            label5.Name = "label5";
            label5.Size = new Size(58, 17);
            label5.TabIndex = 25;
            label5.Text = "Imagen";
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(667, 152);
            txtMarca.Margin = new Padding(3, 2, 3, 2);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(110, 23);
            txtMarca.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(430, 124);
            label4.Name = "label4";
            label4.Size = new Size(79, 17);
            label4.TabIndex = 23;
            label4.Text = "Cod Barras";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(315, 124);
            label3.Name = "label3";
            label3.Size = new Size(48, 17);
            label3.TabIndex = 22;
            label3.Text = "Precio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(178, 124);
            label2.Name = "label2";
            label2.Size = new Size(83, 17);
            label2.TabIndex = 21;
            label2.Text = "Descripción";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(60, 124);
            label1.Name = "label1";
            label1.Size = new Size(61, 17);
            label1.TabIndex = 20;
            label1.Text = "Nombre";
            // 
            // comboPresentacion
            // 
            comboPresentacion.FormattingEnabled = true;
            comboPresentacion.Items.AddRange(new object[] { "CAJA", "KILO", "LITRO", "PIEZA" });
            comboPresentacion.Location = new Point(805, 151);
            comboPresentacion.Margin = new Padding(3, 2, 3, 2);
            comboPresentacion.Name = "comboPresentacion";
            comboPresentacion.Size = new Size(133, 23);
            comboPresentacion.TabIndex = 19;
            // 
            // txtImagen
            // 
            txtImagen.Location = new Point(536, 151);
            txtImagen.Margin = new Padding(3, 2, 3, 2);
            txtImagen.Name = "txtImagen";
            txtImagen.Size = new Size(110, 23);
            txtImagen.TabIndex = 18;
            // 
            // txtCodBarras
            // 
            txtCodBarras.Location = new Point(415, 151);
            txtCodBarras.Margin = new Padding(3, 2, 3, 2);
            txtCodBarras.Name = "txtCodBarras";
            txtCodBarras.Size = new Size(110, 23);
            txtCodBarras.TabIndex = 17;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(289, 151);
            txtPrecio.Margin = new Padding(3, 2, 3, 2);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(110, 23);
            txtPrecio.TabIndex = 16;
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(165, 151);
            txtDesc.Margin = new Padding(3, 2, 3, 2);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(110, 23);
            txtDesc.TabIndex = 15;
            // 
            // txtNom
            // 
            txtNom.Location = new Point(39, 151);
            txtNom.Margin = new Padding(3, 2, 3, 2);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(110, 23);
            txtNom.TabIndex = 14;
            // 
            // btnCancelarEditar
            // 
            btnCancelarEditar.BackColor = Color.FromArgb(88, 161, 200);
            btnCancelarEditar.FlatAppearance.BorderSize = 0;
            btnCancelarEditar.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btnCancelarEditar.FlatStyle = FlatStyle.Flat;
            btnCancelarEditar.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelarEditar.ForeColor = Color.White;
            btnCancelarEditar.Image = (Image)resources.GetObject("btnCancelarEditar.Image");
            btnCancelarEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelarEditar.Location = new Point(173, 484);
            btnCancelarEditar.Margin = new Padding(4, 3, 4, 3);
            btnCancelarEditar.Name = "btnCancelarEditar";
            btnCancelarEditar.Size = new Size(292, 52);
            btnCancelarEditar.TabIndex = 32;
            btnCancelarEditar.Text = "Cancelar";
            btnCancelarEditar.UseVisualStyleBackColor = false;
            btnCancelarEditar.Click += btnCancelarEditar_Click;
            // 
            // btnAceptarEditar
            // 
            btnAceptarEditar.BackColor = Color.FromArgb(88, 161, 200);
            btnAceptarEditar.FlatAppearance.BorderSize = 0;
            btnAceptarEditar.FlatAppearance.MouseOverBackColor = Color.Green;
            btnAceptarEditar.FlatStyle = FlatStyle.Flat;
            btnAceptarEditar.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptarEditar.ForeColor = Color.White;
            btnAceptarEditar.Image = (Image)resources.GetObject("btnAceptarEditar.Image");
            btnAceptarEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAceptarEditar.Location = new Point(516, 484);
            btnAceptarEditar.Margin = new Padding(4, 3, 4, 3);
            btnAceptarEditar.Name = "btnAceptarEditar";
            btnAceptarEditar.Size = new Size(292, 52);
            btnAceptarEditar.TabIndex = 31;
            btnAceptarEditar.Text = "Editar";
            btnAceptarEditar.UseVisualStyleBackColor = false;
            btnAceptarEditar.Click += button2_Click;
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
            buttonBuscar.Location = new Point(623, 83);
            buttonBuscar.Margin = new Padding(4, 3, 4, 3);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(28, 24);
            buttonBuscar.TabIndex = 47;
            buttonBuscar.UseVisualStyleBackColor = false;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(276, 84);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(109, 24);
            label8.TabIndex = 46;
            label8.Text = "Producto:";
            label8.Click += label8_Click;
            // 
            // textBoxbuscar
            // 
            textBoxbuscar.Location = new Point(392, 84);
            textBoxbuscar.Name = "textBoxbuscar";
            textBoxbuscar.Size = new Size(225, 23);
            textBoxbuscar.TabIndex = 45;
            textBoxbuscar.TextChanged += textBoxbuscar_TextChanged;
            textBoxbuscar.KeyPress += textBoxbuscar_KeyPress;
            // 
            // dataGridProductos
            // 
            dataGridProductos.BackgroundColor = Color.FromArgb(88, 161, 200);
            dataGridProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridProductos.Columns.AddRange(new DataGridViewColumn[] { ID, Nombre, Descripcion, Precion, Cod_Barras, Imagen, Marca, PresentacionProducto });
            dataGridProductos.GridColor = Color.FromArgb(88, 161, 200);
            dataGridProductos.Location = new Point(60, 209);
            dataGridProductos.Name = "dataGridProductos";
            dataGridProductos.RowTemplate.Height = 25;
            dataGridProductos.Size = new Size(841, 268);
            dataGridProductos.TabIndex = 48;
            dataGridProductos.CellContentClick += dataGridProductos_CellContentClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.Name = "Descripcion";
            // 
            // Precion
            // 
            Precion.HeaderText = "Precio";
            Precion.Name = "Precion";
            // 
            // Cod_Barras
            // 
            Cod_Barras.HeaderText = "Cod Barras";
            Cod_Barras.Name = "Cod_Barras";
            // 
            // Imagen
            // 
            Imagen.HeaderText = "Imagen";
            Imagen.Name = "Imagen";
            // 
            // Marca
            // 
            Marca.HeaderText = "Marca";
            Marca.Name = "Marca";
            // 
            // PresentacionProducto
            // 
            PresentacionProducto.HeaderText = "Presentacion";
            PresentacionProducto.Name = "PresentacionProducto";
            PresentacionProducto.Resizable = DataGridViewTriState.True;
            PresentacionProducto.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Editar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 81, 209);
            ClientSize = new Size(1015, 574);
            Controls.Add(dataGridProductos);
            Controls.Add(buttonBuscar);
            Controls.Add(label8);
            Controls.Add(textBoxbuscar);
            Controls.Add(btnCancelarEditar);
            Controls.Add(btnAceptarEditar);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtMarca);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboPresentacion);
            Controls.Add(txtImagen);
            Controls.Add(txtCodBarras);
            Controls.Add(txtPrecio);
            Controls.Add(txtDesc);
            Controls.Add(txtNom);
            Controls.Add(txtProductos);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Editar";
            Text = "Editar";
            ((System.ComponentModel.ISupportInitialize)dataGridProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label txtProductos;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox txtMarca;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox comboPresentacion;
        private TextBox txtImagen;
        private TextBox txtCodBarras;
        private TextBox txtPrecio;
        private TextBox txtDesc;
        private TextBox txtNom;
        private Button btnCancelarEditar;
        private Button btnAceptarEditar;
        private Button buttonBuscar;
        private Label label8;
        private TextBox textBoxbuscar;
        private DataGridView dataGridProductos;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Precion;
        private DataGridViewTextBoxColumn Cod_Barras;
        private DataGridViewTextBoxColumn Imagen;
        private DataGridViewTextBoxColumn Marca;
        private DataGridViewTextBoxColumn PresentacionProducto;
    }
}