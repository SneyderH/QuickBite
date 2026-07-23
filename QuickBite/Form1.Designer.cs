namespace QuickBite
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtPassword = new TextBox();
            lblUsername = new Label();
            lblPassword = new Label();
            btnLogin = new Button();
            panel1 = new Panel();
            txtUsername = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(147, 213);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(168, 36);
            txtPassword.TabIndex = 1;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(68, 26);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(95, 27);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Usuario";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(42, 133);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(145, 27);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Contraseña";
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnLogin.Location = new Point(36, 246);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(158, 44);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Ingresar";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(lblPassword);
            panel1.Controls.Add(lblUsername);
            panel1.Location = new Point(115, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 324);
            panel1.TabIndex = 5;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(32, 69);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(168, 36);
            txtUsername.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 440);
            Controls.Add(txtPassword);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtPassword;
        private Label lblUsername;
        private Label lblPassword;
        private Button btnLogin;
        private Panel panel1;
        private TextBox txtUsername;
    }
}
