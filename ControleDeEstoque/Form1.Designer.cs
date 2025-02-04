using ControleDeEstoque.src;

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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            loginPanel = new Panel();
            buttonCadastro = new Button();
            userBox = new TextBox();
            passwordBox = new TextBox();
            buttonLogin = new Button();
            starterApp = new Panel();
            menuSideBar = new Button();
            SideBar = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            registerPanel = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            entryPassword = new TextBox();
            entryMail = new TextBox();
            entryName = new TextBox();
            buttonCadastrar = new Button();
            timerMenu = new System.Windows.Forms.Timer(components);
            loginPanel.SuspendLayout();
            starterApp.SuspendLayout();
            SideBar.SuspendLayout();
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
            buttonLogin.Click += buttonLogin_Click;
            // 
            // starterApp
            // 
            starterApp.Controls.Add(menuSideBar);
            starterApp.Controls.Add(SideBar);
            starterApp.Dock = DockStyle.Fill;
            starterApp.Location = new Point(0, 0);
            starterApp.Name = "starterApp";
            starterApp.Size = new Size(1344, 579);
            starterApp.TabIndex = 2;
            // 
            // menuSideBar
            // 
            menuSideBar.BackColor = Color.Transparent;
            menuSideBar.FlatStyle = FlatStyle.Flat;
            menuSideBar.Image = (Image)resources.GetObject("menuSideBar.Image");
            menuSideBar.Location = new Point(3, 12);
            menuSideBar.Name = "menuSideBar";
            menuSideBar.Size = new Size(29, 24);
            menuSideBar.TabIndex = 1;
            menuSideBar.UseVisualStyleBackColor = false;
            menuSideBar.Click += menuSideBar_Click;
            // 
            // SideBar
            // 
            SideBar.BackColor = SystemColors.ControlDarkDark;
            SideBar.Controls.Add(button3);
            SideBar.Controls.Add(button2);
            SideBar.Controls.Add(button1);
            SideBar.Dock = DockStyle.Left;
            SideBar.Location = new Point(0, 0);
            SideBar.Name = "SideBar";
            SideBar.Size = new Size(0, 579);
            SideBar.TabIndex = 0;
            // 
            // button3
            // 
            button3.Location = new Point(3, 275);
            button3.Name = "button3";
            button3.Size = new Size(209, 52);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(0, 163);
            button2.Name = "button2";
            button2.Size = new Size(212, 45);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(0, 48);
            button1.Name = "button1";
            button1.Size = new Size(212, 52);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
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
            // timerMenu
            // 
            timerMenu.Tick += timerMenu_Tick_1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1344, 579);
            Controls.Add(starterApp);
            Controls.Add(loginPanel);
            Controls.Add(registerPanel);
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            loginPanel.ResumeLayout(false);
            loginPanel.PerformLayout();
            starterApp.ResumeLayout(false);
            SideBar.ResumeLayout(false);
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
        private Panel SideBar;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button menuSideBar;
        private System.Windows.Forms.Timer timerMenu;
    }
}
