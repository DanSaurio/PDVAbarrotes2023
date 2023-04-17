namespace WinForm_Abarrotes_PDV
{
    partial class Ventas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventas));
            buttonBuscarventa = new Button();
            label8 = new Label();
            textBoxbuscarventa = new TextBox();
            txtVentas = new Label();
            dataGridDetallesVentas = new DataGridView();
            IDventa = new DataGridViewTextBoxColumn();
            producto_id = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridDetallesVentas).BeginInit();
            SuspendLayout();
            // 
            // buttonBuscarventa
            // 
            buttonBuscarventa.BackColor = Color.FromArgb(88, 161, 200);
            buttonBuscarventa.FlatAppearance.BorderSize = 0;
            buttonBuscarventa.FlatAppearance.MouseOverBackColor = Color.Green;
            buttonBuscarventa.FlatStyle = FlatStyle.Flat;
            buttonBuscarventa.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonBuscarventa.ForeColor = Color.White;
            buttonBuscarventa.Image = (Image)resources.GetObject("buttonBuscarventa.Image");
            buttonBuscarventa.ImageAlign = ContentAlignment.MiddleLeft;
            buttonBuscarventa.Location = new Point(596, 94);
            buttonBuscarventa.Margin = new Padding(4, 3, 4, 3);
            buttonBuscarventa.Name = "buttonBuscarventa";
            buttonBuscarventa.Size = new Size(28, 24);
            buttonBuscarventa.TabIndex = 50;
            buttonBuscarventa.UseVisualStyleBackColor = false;
            buttonBuscarventa.Click += buttonBuscarventa_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(280, 95);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(78, 24);
            label8.TabIndex = 49;
            label8.Text = "Venta:";
            // 
            // textBoxbuscarventa
            // 
            textBoxbuscarventa.Location = new Point(365, 95);
            textBoxbuscarventa.Name = "textBoxbuscarventa";
            textBoxbuscarventa.Size = new Size(225, 23);
            textBoxbuscarventa.TabIndex = 48;
            // 
            // txtVentas
            // 
            txtVentas.AutoSize = true;
            txtVentas.Font = new Font("Century Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtVentas.Location = new Point(365, 9);
            txtVentas.Margin = new Padding(4, 0, 4, 0);
            txtVentas.Name = "txtVentas";
            txtVentas.Size = new Size(235, 36);
            txtVentas.TabIndex = 51;
            txtVentas.Text = "Registro Ventas";
            txtVentas.TextAlign = ContentAlignment.TopCenter;
            // 
            // dataGridDetallesVentas
            // 
            dataGridDetallesVentas.BackgroundColor = Color.FromArgb(88, 161, 200);
            dataGridDetallesVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridDetallesVentas.Columns.AddRange(new DataGridViewColumn[] { IDventa, producto_id, Cantidad });
            dataGridDetallesVentas.GridColor = Color.FromArgb(88, 161, 200);
            dataGridDetallesVentas.Location = new Point(299, 154);
            dataGridDetallesVentas.Name = "dataGridDetallesVentas";
            dataGridDetallesVentas.RowTemplate.Height = 25;
            dataGridDetallesVentas.Size = new Size(343, 246);
            dataGridDetallesVentas.TabIndex = 52;
            // 
            // IDventa
            // 
            IDventa.HeaderText = "ID ventas";
            IDventa.Name = "IDventa";
            // 
            // producto_id
            // 
            producto_id.HeaderText = "ID Producto";
            producto_id.Name = "producto_id";
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "cantidad";
            Cantidad.Name = "Cantidad";
            // 
            // Ventas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 81, 209);
            ClientSize = new Size(910, 489);
            Controls.Add(dataGridDetallesVentas);
            Controls.Add(txtVentas);
            Controls.Add(buttonBuscarventa);
            Controls.Add(label8);
            Controls.Add(textBoxbuscarventa);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Ventas";
            Text = "Ventas";
            ((System.ComponentModel.ISupportInitialize)dataGridDetallesVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonBuscarventa;
        private Label label8;
        private TextBox textBoxbuscarventa;
        private Label txtVentas;
        private DataGridView dataGridDetallesVentas;
        private DataGridViewTextBoxColumn IDventa;
        private DataGridViewTextBoxColumn producto_id;
        private DataGridViewTextBoxColumn Cantidad;
    }
}