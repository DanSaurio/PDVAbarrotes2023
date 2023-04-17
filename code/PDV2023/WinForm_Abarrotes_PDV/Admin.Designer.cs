namespace WinForm_Abarrotes_PDV
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            textboxPasswordAdmin = new TextBox();
            txtPassword = new Label();
            txtLogin = new Label();
            AceptarLogin = new Button();
            RegresarAdmin = new Button();
            SuspendLayout();
            // 
            // textboxPasswordAdmin
            // 
            textboxPasswordAdmin.Location = new Point(256, 244);
            textboxPasswordAdmin.Margin = new Padding(4, 3, 4, 3);
            textboxPasswordAdmin.Name = "textboxPasswordAdmin";
            textboxPasswordAdmin.PasswordChar = '*';
            textboxPasswordAdmin.Size = new Size(228, 23);
            textboxPasswordAdmin.TabIndex = 12;
            // 
            // txtPassword
            // 
            txtPassword.AutoSize = true;
            txtPassword.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.ForeColor = Color.White;
            txtPassword.Location = new Point(44, 229);
            txtPassword.Margin = new Padding(4, 0, 4, 0);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(176, 33);
            txtPassword.TabIndex = 10;
            txtPassword.Text = "Contraseña:";
            // 
            // txtLogin
            // 
            txtLogin.AutoSize = true;
            txtLogin.Font = new Font("Century Gothic", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtLogin.ForeColor = Color.White;
            txtLogin.Location = new Point(296, 105);
            txtLogin.Margin = new Padding(4, 0, 4, 0);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(129, 42);
            txtLogin.TabIndex = 8;
            txtLogin.Text = "LOGIN";
            // 
            // AceptarLogin
            // 
            AceptarLogin.FlatAppearance.BorderSize = 0;
            AceptarLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            AceptarLogin.FlatStyle = FlatStyle.Flat;
            AceptarLogin.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            AceptarLogin.ForeColor = Color.White;
            AceptarLogin.Image = (Image)resources.GetObject("AceptarLogin.Image");
            AceptarLogin.ImageAlign = ContentAlignment.MiddleLeft;
            AceptarLogin.Location = new Point(389, 357);
            AceptarLogin.Margin = new Padding(4, 3, 4, 3);
            AceptarLogin.Name = "AceptarLogin";
            AceptarLogin.Size = new Size(203, 55);
            AceptarLogin.TabIndex = 7;
            AceptarLogin.Text = "Aceptar";
            AceptarLogin.UseVisualStyleBackColor = true;
            AceptarLogin.Click += AceptarLogin_Click;
            // 
            // RegresarAdmin
            // 
            RegresarAdmin.FlatAppearance.BorderSize = 0;
            RegresarAdmin.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            RegresarAdmin.FlatStyle = FlatStyle.Flat;
            RegresarAdmin.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            RegresarAdmin.ForeColor = Color.White;
            RegresarAdmin.Image = (Image)resources.GetObject("RegresarAdmin.Image");
            RegresarAdmin.ImageAlign = ContentAlignment.MiddleLeft;
            RegresarAdmin.Location = new Point(110, 357);
            RegresarAdmin.Margin = new Padding(4, 3, 4, 3);
            RegresarAdmin.Name = "RegresarAdmin";
            RegresarAdmin.Size = new Size(196, 55);
            RegresarAdmin.TabIndex = 6;
            RegresarAdmin.Text = "Regresar";
            RegresarAdmin.UseVisualStyleBackColor = true;
            RegresarAdmin.Click += RegresarAdmin_Click;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(12, 12, 110);
            ClientSize = new Size(698, 534);
            Controls.Add(textboxPasswordAdmin);
            Controls.Add(txtPassword);
            Controls.Add(txtLogin);
            Controls.Add(AceptarLogin);
            Controls.Add(RegresarAdmin);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Admin";
            Text = "Admin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textboxPasswordAdmin;
        private Label txtPassword;
        private Label txtLogin;
        private Button AceptarLogin;
        private Button RegresarAdmin;
    }
}