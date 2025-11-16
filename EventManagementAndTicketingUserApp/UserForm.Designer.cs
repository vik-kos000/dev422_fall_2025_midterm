namespace EventManagementAndTicketingUserApp
{
    partial class UserForm
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
            tbx_name = new TextBox();
            lbl_User = new Label();
            btn_register = new Button();
            btn_login = new Button();
            tbx_password = new TextBox();
            tbx_email = new TextBox();
            tbx_role = new TextBox();
            lbl_name = new Label();
            lbl_password = new Label();
            lbl_email = new Label();
            lbl_role = new Label();
            lbl_user_RegisterOrLogin = new Label();
            SuspendLayout();
            // 
            // tbx_name
            // 
            tbx_name.Location = new Point(345, 178);
            tbx_name.Name = "tbx_name";
            tbx_name.Size = new Size(223, 31);
            tbx_name.TabIndex = 0;
            // 
            // lbl_User
            // 
            lbl_User.AutoSize = true;
            lbl_User.Location = new Point(451, 9);
            lbl_User.Name = "lbl_User";
            lbl_User.Size = new Size(330, 25);
            lbl_User.TabIndex = 1;
            lbl_User.Text = "Evnet Management and Ticketing Step 3";
            // 
            // btn_register
            // 
            btn_register.Location = new Point(773, 162);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(137, 63);
            btn_register.TabIndex = 2;
            btn_register.Text = "Register";
            btn_register.UseVisualStyleBackColor = true;
            btn_register.Click += btn_register_Click;
            // 
            // btn_login
            // 
            btn_login.Location = new Point(773, 305);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(137, 63);
            btn_login.TabIndex = 3;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // tbx_password
            // 
            tbx_password.Location = new Point(345, 230);
            tbx_password.Name = "tbx_password";
            tbx_password.Size = new Size(223, 31);
            tbx_password.TabIndex = 4;
            // 
            // tbx_email
            // 
            tbx_email.Location = new Point(345, 281);
            tbx_email.Name = "tbx_email";
            tbx_email.Size = new Size(223, 31);
            tbx_email.TabIndex = 5;
            // 
            // tbx_role
            // 
            tbx_role.Location = new Point(345, 337);
            tbx_role.Name = "tbx_role";
            tbx_role.Size = new Size(223, 31);
            tbx_role.TabIndex = 6;
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Location = new Point(195, 178);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(63, 25);
            lbl_name.TabIndex = 8;
            lbl_name.Text = "Name:";
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.Location = new Point(195, 230);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(91, 25);
            lbl_password.TabIndex = 9;
            lbl_password.Text = "Password:";
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.Location = new Point(195, 281);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(58, 25);
            lbl_email.TabIndex = 10;
            lbl_email.Text = "Email:";
            // 
            // lbl_role
            // 
            lbl_role.AutoSize = true;
            lbl_role.Location = new Point(195, 343);
            lbl_role.Name = "lbl_role";
            lbl_role.Size = new Size(50, 25);
            lbl_role.TabIndex = 11;
            lbl_role.Text = "Role:";
            // 
            // lbl_user_RegisterOrLogin
            // 
            lbl_user_RegisterOrLogin.AutoSize = true;
            lbl_user_RegisterOrLogin.Location = new Point(496, 51);
            lbl_user_RegisterOrLogin.Name = "lbl_user_RegisterOrLogin";
            lbl_user_RegisterOrLogin.Size = new Size(229, 25);
            lbl_user_RegisterOrLogin.TabIndex = 12;
            lbl_user_RegisterOrLogin.Text = "User Registeration Or Login";
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 650);
            Controls.Add(lbl_user_RegisterOrLogin);
            Controls.Add(lbl_role);
            Controls.Add(lbl_email);
            Controls.Add(lbl_password);
            Controls.Add(lbl_name);
            Controls.Add(tbx_role);
            Controls.Add(tbx_email);
            Controls.Add(tbx_password);
            Controls.Add(btn_login);
            Controls.Add(btn_register);
            Controls.Add(lbl_User);
            Controls.Add(tbx_name);
            Name = "UserForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbx_name;
        private Label lbl_User;
        private Button btn_register;
        private Button btn_login;
        private TextBox tbx_password;
        private TextBox tbx_email;
        private TextBox tbx_role;
        private Label lbl_name;
        private Label lbl_password;
        private Label lbl_email;
        private Label lbl_role;
        private Label lbl_user_RegisterOrLogin;
    }

}
