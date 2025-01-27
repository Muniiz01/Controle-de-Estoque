namespace ControleDeEstoque
{
    partial class MainForm
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
            loginPanel = new Panel();
            buttonCadastro = new Button();
            userBox = new TextBox();
            passwordBox = new TextBox();
            buttonLogin = new Button();
            starterApp = new Panel();
            registerPanel = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            entryPassword = new TextBox();
            entryMail = new TextBox();
            entryName = new TextBox();
            buttonCadastrar = new Button();
            loginPanel.SuspendLayout();
            registerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // loginPanel
            // 
            loginPanel.Controls.Add(buttonCadastro);
            loginPanel.Controls.Add(userBox);
            loginPanel.Controls.Add(passwordBox);
            loginPanel.Controls.Add(buttonLogin);
            loginPanel.Dock = DockStyle.Fill;
            loginPanel.Location = new Point(0, 0);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new Size(1344, 579);
            loginPanel.TabIndex = 0;
            // 
            // buttonCadastro
            // 
            buttonCadastro.Location = new Point(612, 386);
            buttonCadastro.Name = "buttonCadastro";
            buttonCadastro.Size = new Size(84, 34);
            buttonCadastro.TabIndex = 3;
            buttonCadastro.Text = "Cadastrar";
            buttonCadastro.UseVisualStyleBackColor = true;
            buttonCadastro.Click += buttonCadastro_Click;
            // 
            // userBox
            // 
            userBox.Location = new Point(547, 219);
            userBox.Name = "userBox";
            userBox.PlaceholderText = "User";
            userBox.Size = new Size(222, 23);
            userBox.TabIndex = 1;
            userBox.TextAlign = HorizontalAlignment.Center;
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(547, 275);
            passwordBox.Name = "passwordBox";
            passwordBox.PasswordChar = '*';
            passwordBox.PlaceholderText = "Password";
            passwordBox.Size = new Size(222, 23);
            passwordBox.TabIndex = 2;
            passwordBox.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(612, 337);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(84, 34);
            buttonLogin.TabIndex = 0;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += button1_Click;
            // 
            // starterApp
            // 
            starterApp.Dock = DockStyle.Fill;
            starterApp.Location = new Point(0, 0);
            starterApp.Name = "starterApp";
            starterApp.Size = new Size(1344, 579);
            starterApp.TabIndex = 2;
            // 
            // registerPanel
            // 
            registerPanel.Controls.Add(label3);
            registerPanel.Controls.Add(label2);
            registerPanel.Controls.Add(label1);
            registerPanel.Controls.Add(entryPassword);
            registerPanel.Controls.Add(entryMail);
            registerPanel.Controls.Add(entryName);
            registerPanel.Controls.Add(buttonCadastrar);
            registerPanel.Dock = DockStyle.Fill;
            registerPanel.Location = new Point(0, 0);
            registerPanel.Name = "registerPanel";
            registerPanel.Size = new Size(1344, 579);
            registerPanel.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(574, 259);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 6;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(572, 203);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 5;
            label2.Text = "E-mail";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(571, 145);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 4;
            label1.Text = "Name";
            // 
            // entryPassword
            // 
            entryPassword.Location = new Point(571, 277);
            entryPassword.MaxLength = 250;
            entryPassword.Name = "entryPassword";
            entryPassword.PasswordChar = '*';
            entryPassword.Size = new Size(167, 23);
            entryPassword.TabIndex = 3;
            // 
            // entryMail
            // 
            entryMail.Location = new Point(571, 221);
            entryMail.MaxLength = 100;
            entryMail.Name = "entryMail";
            entryMail.Size = new Size(167, 23);
            entryMail.TabIndex = 2;
            // 
            // entryName
            // 
            entryName.Location = new Point(571, 163);
            entryName.MaxLength = 50;
            entryName.Name = "entryName";
            entryName.Size = new Size(167, 23);
            entryName.TabIndex = 1;
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Location = new Point(619, 376);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(75, 23);
            buttonCadastrar.TabIndex = 0;
            buttonCadastrar.Text = "confirm";
            buttonCadastrar.UseVisualStyleBackColor = true;
            buttonCadastrar.Click += buttonCadastrar_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1344, 579);
            Controls.Add(loginPanel);
            Controls.Add(registerPanel);
            Controls.Add(starterApp);
            Name = "MainForm";
            Text = "Form1";
            loginPanel.ResumeLayout(false);
            loginPanel.PerformLayout();
            registerPanel.ResumeLayout(false);
            registerPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel loginPanel;
        private Button buttonLogin;
        private TextBox userBox;
        private Panel starterApp;
        private TextBox passwordBox;
        private Button buttonCadastro;
        private Panel registerPanel;
        private TextBox entryPassword;
        private TextBox entryMail;
        private TextBox entryName;
        private Button buttonCadastrar;
        private Label label2;
        private Label label1;
        private Label label3;
    }
}
