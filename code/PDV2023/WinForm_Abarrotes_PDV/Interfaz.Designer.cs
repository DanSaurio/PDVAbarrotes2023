namespace pruebaVENTA
{
    partial class Interfaz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Interfaz));
            MenuVertical = new Panel();
            btnUsuarios = new Button();
            btnVentas = new Button();
            btnAddProducto = new Button();
            EliminarProductos = new Button();
            Editar = new Button();
            Productos = new Button();
            pictureBoxLogo = new PictureBox();
            BarraTitulo = new Panel();
            iconminimizar = new PictureBox();
            iconrestaurar = new PictureBox();
            iconmaximizar = new PictureBox();
            iconcerrar = new PictureBox();
            btnMenu = new PictureBox();
            panelContenedor = new Panel();
            MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconminimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconrestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconmaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconcerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMenu).BeginInit();
            SuspendLayout();
            // 
            // MenuVertical
            // 
            MenuVertical.BackColor = Color.FromArgb(88, 161, 200);
            MenuVertical.Controls.Add(btnUsuarios);
            MenuVertical.Controls.Add(btnVentas);
            MenuVertical.Controls.Add(btnAddProducto);
            MenuVertical.Controls.Add(EliminarProductos);
            MenuVertical.Controls.Add(Editar);
            MenuVertical.Controls.Add(Productos);
            MenuVertical.Controls.Add(pictureBoxLogo);
            MenuVertical.Dock = DockStyle.Left;
            MenuVertical.Location = new Point(0, 0);
            MenuVertical.Margin = new Padding(4, 3, 4, 3);
            MenuVertical.Name = "MenuVertical";
            MenuVertical.Size = new Size(292, 750);
            MenuVertical.TabIndex = 0;
            // 
            // btnUsuarios
            // 
            btnUsuarios.FlatAppearance.BorderSize = 0;
            btnUsuarios.FlatAppearance.MouseOverBackColor = Color.Olive;
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnUsuarios.ForeColor = Color.White;
            btnUsuarios.Image = (Image)resources.GetObject("btnUsuarios.Image");
            btnUsuarios.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsuarios.Location = new Point(0, 407);
            btnUsuarios.Margin = new Padding(4, 3, 4, 3);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(292, 52);
            btnUsuarios.TabIndex = 5;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnVentas
            // 
            btnVentas.FlatAppearance.BorderSize = 0;
            btnVentas.FlatAppearance.MouseOverBackColor = Color.Olive;
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnVentas.ForeColor = Color.White;
            btnVentas.Image = (Image)resources.GetObject("btnVentas.Image");
            btnVentas.ImageAlign = ContentAlignment.MiddleLeft;
            btnVentas.Location = new Point(0, 359);
            btnVentas.Margin = new Padding(4, 3, 4, 3);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(292, 52);
            btnVentas.TabIndex = 4;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnAddProducto
            // 
            btnAddProducto.FlatAppearance.BorderSize = 0;
            btnAddProducto.FlatAppearance.MouseOverBackColor = Color.Green;
            btnAddProducto.FlatStyle = FlatStyle.Flat;
            btnAddProducto.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddProducto.ForeColor = Color.White;
            btnAddProducto.Image = (Image)resources.GetObject("btnAddProducto.Image");
            btnAddProducto.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddProducto.Location = new Point(0, 205);
            btnAddProducto.Margin = new Padding(4, 3, 4, 3);
            btnAddProducto.Name = "btnAddProducto";
            btnAddProducto.Size = new Size(292, 52);
            btnAddProducto.TabIndex = 3;
            btnAddProducto.Text = "Agregar Producto";
            btnAddProducto.UseVisualStyleBackColor = true;
            btnAddProducto.Click += AgregarProducto_Click;
            // 
            // EliminarProductos
            // 
            EliminarProductos.FlatAppearance.BorderSize = 0;
            EliminarProductos.FlatAppearance.MouseOverBackColor = Color.Maroon;
            EliminarProductos.FlatStyle = FlatStyle.Flat;
            EliminarProductos.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            EliminarProductos.ForeColor = Color.White;
            EliminarProductos.Image = (Image)resources.GetObject("EliminarProductos.Image");
            EliminarProductos.ImageAlign = ContentAlignment.MiddleLeft;
            EliminarProductos.Location = new Point(0, 264);
            EliminarProductos.Margin = new Padding(4, 3, 4, 3);
            EliminarProductos.Name = "EliminarProductos";
            EliminarProductos.Size = new Size(292, 52);
            EliminarProductos.TabIndex = 2;
            EliminarProductos.Text = "Eliminar Productos";
            EliminarProductos.UseVisualStyleBackColor = true;
            EliminarProductos.Click += EliminarProductos_Click;
            // 
            // Editar
            // 
            Editar.FlatAppearance.BorderSize = 0;
            Editar.FlatAppearance.MouseOverBackColor = Color.Olive;
            Editar.FlatStyle = FlatStyle.Flat;
            Editar.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Editar.ForeColor = Color.White;
            Editar.Image = (Image)resources.GetObject("Editar.Image");
            Editar.ImageAlign = ContentAlignment.MiddleLeft;
            Editar.Location = new Point(0, 312);
            Editar.Margin = new Padding(4, 3, 4, 3);
            Editar.Name = "Editar";
            Editar.Size = new Size(292, 52);
            Editar.TabIndex = 1;
            Editar.Text = "Editar";
            Editar.UseVisualStyleBackColor = true;
            Editar.Click += Editar_Click;
            // 
            // Productos
            // 
            Productos.FlatAppearance.BorderSize = 0;
            Productos.FlatAppearance.MouseOverBackColor = Color.Green;
            Productos.FlatStyle = FlatStyle.Flat;
            Productos.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Productos.ForeColor = Color.White;
            Productos.Image = (Image)resources.GetObject("Productos.Image");
            Productos.ImageAlign = ContentAlignment.MiddleLeft;
            Productos.Location = new Point(0, 147);
            Productos.Margin = new Padding(4, 3, 4, 3);
            Productos.Name = "Productos";
            Productos.Size = new Size(292, 52);
            Productos.TabIndex = 0;
            Productos.Text = "Productos";
            Productos.UseVisualStyleBackColor = true;
            Productos.Click += Productos_Click;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(24, 0);
            pictureBoxLogo.Margin = new Padding(4, 3, 4, 3);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(239, 120);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // BarraTitulo
            // 
            BarraTitulo.BackColor = Color.FromArgb(15, 81, 209);
            BarraTitulo.Controls.Add(iconminimizar);
            BarraTitulo.Controls.Add(iconrestaurar);
            BarraTitulo.Controls.Add(iconmaximizar);
            BarraTitulo.Controls.Add(iconcerrar);
            BarraTitulo.Controls.Add(btnMenu);
            BarraTitulo.Dock = DockStyle.Top;
            BarraTitulo.Location = new Point(292, 0);
            BarraTitulo.Margin = new Padding(4, 3, 4, 3);
            BarraTitulo.Name = "BarraTitulo";
            BarraTitulo.Size = new Size(1088, 58);
            BarraTitulo.TabIndex = 1;
            BarraTitulo.Paint += BarraTitulo_Paint;
            BarraTitulo.MouseDown += BarraTitulo_MouseDown;
            // 
            // iconminimizar
            // 
            iconminimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconminimizar.Image = (Image)resources.GetObject("iconminimizar.Image");
            iconminimizar.Location = new Point(970, 0);
            iconminimizar.Margin = new Padding(4, 3, 4, 3);
            iconminimizar.Name = "iconminimizar";
            iconminimizar.Size = new Size(23, 23);
            iconminimizar.SizeMode = PictureBoxSizeMode.Zoom;
            iconminimizar.TabIndex = 4;
            iconminimizar.TabStop = false;
            iconminimizar.Click += iconminimizar_Click;
            // 
            // iconrestaurar
            // 
            iconrestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconrestaurar.Image = (Image)resources.GetObject("iconrestaurar.Image");
            iconrestaurar.Location = new Point(1000, 0);
            iconrestaurar.Margin = new Padding(4, 3, 4, 3);
            iconrestaurar.Name = "iconrestaurar";
            iconrestaurar.Size = new Size(23, 23);
            iconrestaurar.SizeMode = PictureBoxSizeMode.Zoom;
            iconrestaurar.TabIndex = 3;
            iconrestaurar.TabStop = false;
            iconrestaurar.Visible = false;
            iconrestaurar.Click += iconrestaurar_Click;
            // 
            // iconmaximizar
            // 
            iconmaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconmaximizar.Image = (Image)resources.GetObject("iconmaximizar.Image");
            iconmaximizar.Location = new Point(1000, 0);
            iconmaximizar.Margin = new Padding(4, 3, 4, 3);
            iconmaximizar.Name = "iconmaximizar";
            iconmaximizar.Size = new Size(23, 23);
            iconmaximizar.SizeMode = PictureBoxSizeMode.Zoom;
            iconmaximizar.TabIndex = 2;
            iconmaximizar.TabStop = false;
            iconmaximizar.Click += iconmaximizar_Click;
            // 
            // iconcerrar
            // 
            iconcerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconcerrar.Image = (Image)resources.GetObject("iconcerrar.Image");
            iconcerrar.Location = new Point(1030, 0);
            iconcerrar.Margin = new Padding(4, 3, 4, 3);
            iconcerrar.Name = "iconcerrar";
            iconcerrar.Size = new Size(23, 23);
            iconcerrar.SizeMode = PictureBoxSizeMode.Zoom;
            iconcerrar.TabIndex = 1;
            iconcerrar.TabStop = false;
            iconcerrar.Click += iconcerrar_Click;
            // 
            // btnMenu
            // 
            btnMenu.Image = (Image)resources.GetObject("btnMenu.Image");
            btnMenu.Location = new Point(7, 10);
            btnMenu.Margin = new Padding(4, 3, 4, 3);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(41, 40);
            btnMenu.SizeMode = PictureBoxSizeMode.Zoom;
            btnMenu.TabIndex = 0;
            btnMenu.TabStop = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.FromArgb(15, 81, 209);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(292, 58);
            panelContenedor.Margin = new Padding(4, 3, 4, 3);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1088, 692);
            panelContenedor.TabIndex = 2;
            // 
            // Interfaz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(12, 12, 110);
            ClientSize = new Size(1380, 750);
            Controls.Add(panelContenedor);
            Controls.Add(BarraTitulo);
            Controls.Add(MenuVertical);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Interfaz";
            Text = "Form2";
            MenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconminimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconrestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconmaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconcerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMenu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox iconmaximizar;
        private System.Windows.Forms.PictureBox iconcerrar;
        private System.Windows.Forms.PictureBox iconminimizar;
        private System.Windows.Forms.PictureBox iconrestaurar;
        private System.Windows.Forms.Button Productos;
        private System.Windows.Forms.Button btnAddProducto;
        private System.Windows.Forms.Button EliminarProductos;
        private System.Windows.Forms.Button Editar;
        private Button btnVentas;
        private Button btnUsuarios;
    }
}