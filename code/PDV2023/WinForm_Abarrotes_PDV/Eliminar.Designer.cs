namespace pruebaVENTA
{
    partial class Eliminar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Eliminar));
            txtProductos = new Label();
            btnCancelarEliminar = new Button();
            btnAceptarEliminar = new Button();
            label1 = new Label();
            txtID = new TextBox();
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
            // btnCancelarEliminar
            // 
            btnCancelarEliminar.BackColor = Color.FromArgb(88, 161, 200);
            btnCancelarEliminar.FlatAppearance.BorderSize = 0;
            btnCancelarEliminar.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btnCancelarEliminar.FlatStyle = FlatStyle.Flat;
            btnCancelarEliminar.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelarEliminar.ForeColor = Color.White;
            btnCancelarEliminar.Image = (Image)resources.GetObject("btnCancelarEliminar.Image");
            btnCancelarEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelarEliminar.Location = new Point(174, 318);
            btnCancelarEliminar.Margin = new Padding(4, 3, 4, 3);
            btnCancelarEliminar.Name = "btnCancelarEliminar";
            btnCancelarEliminar.Size = new Size(292, 52);
            btnCancelarEliminar.TabIndex = 30;
            btnCancelarEliminar.Text = "Cancelar";
            btnCancelarEliminar.UseVisualStyleBackColor = false;
            btnCancelarEliminar.Click += btnCancelarEliminar_Click;
            // 
            // btnAceptarEliminar
            // 
            btnAceptarEliminar.BackColor = Color.FromArgb(88, 161, 200);
            btnAceptarEliminar.FlatAppearance.BorderSize = 0;
            btnAceptarEliminar.FlatAppearance.MouseOverBackColor = Color.Green;
            btnAceptarEliminar.FlatStyle = FlatStyle.Flat;
            btnAceptarEliminar.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptarEliminar.ForeColor = Color.White;
            btnAceptarEliminar.Image = (Image)resources.GetObject("btnAceptarEliminar.Image");
            btnAceptarEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAceptarEliminar.Location = new Point(516, 319);
            btnAceptarEliminar.Margin = new Padding(4, 3, 4, 3);
            btnAceptarEliminar.Name = "btnAceptarEliminar";
            btnAceptarEliminar.Size = new Size(292, 52);
            btnAceptarEliminar.TabIndex = 29;
            btnAceptarEliminar.Text = "Aceptar";
            btnAceptarEliminar.UseVisualStyleBackColor = false;
            btnAceptarEliminar.Click += btnAceptarEliminar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(442, 88);
            label1.Name = "label1";
            label1.Size = new Size(85, 17);
            label1.TabIndex = 32;
            label1.Text = "ID Producto";
            // 
            // txtID
            // 
            txtID.Location = new Point(433, 118);
            txtID.Margin = new Padding(3, 2, 3, 2);
            txtID.Name = "txtID";
            txtID.Size = new Size(110, 23);
            txtID.TabIndex = 31;
            // 
            // Eliminar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 81, 209);
            ClientSize = new Size(1015, 382);
            Controls.Add(label1);
            Controls.Add(txtID);
            Controls.Add(btnCancelarEliminar);
            Controls.Add(btnAceptarEliminar);
            Controls.Add(txtProductos);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Eliminar";
            Text = "Eliminar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label txtProductos;
        private Button btnCancelarEliminar;
        private Button btnAceptarEliminar;
        private Label label1;
        private TextBox txtID;
    }
}