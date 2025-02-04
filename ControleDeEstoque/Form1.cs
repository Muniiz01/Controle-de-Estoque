using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using LottieSharp;
using ControleDeEstoque.src;
using SkiaSharp.Skottie;
using LottieSharp.WPF;
namespace ControleDeEstoque
{

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ShowpanelLogin();

        }

        private void ShowpanelLogin()
        //mostra o painel de login
        {
            loginPanel.Visible = true;
            starterApp.Visible = false;
            registerPanel.Visible = false;
        }

        private void ShowpanelRegisteer()
        //mostra o painel de registro
        {
            loginPanel.Visible = false;
            starterApp.Visible = false;
            registerPanel.Visible = true;

        }

        private void ShowpanelStarter()
        //mostra o painel Principal
        {
            loginPanel.Visible = false;
            starterApp.Visible = true;
            registerPanel.Visible = false;

        }

        private void buttonCadastro_Click(object sender, EventArgs e)
        {
            ShowpanelRegisteer();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            //Envia os dados inseridos no painel registro para ser tratados
            // O cadastro sera enviado para uma outra tela no futturo
            string a = entryName.Text;
            string b = entryMail.Text;
            string c = entryPassword.Text;
            ConsultQuery.RegisterUser(a, b, c);

            ShowpanelStarter();
        }

        //Apos cliclar o botao login, envia os dados via metodo e retorna um bool.
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(userBox.Text) || string.IsNullOrWhiteSpace(passwordBox.Text))
            {
                MessageBox.Show("Preencha os campos");
            }
            else
            {
                bool loginBool = src.ConsultQuery.VerifyLogin(userBox.Text, passwordBox.Text);

                if (loginBool)
                {
                    ShowpanelStarter();
                }
                else { MessageBox.Show("Login invalido"); }
            }
        }

        
        private bool menuExpand = true;

        //Inicia o timer para o menu lateral
        private void menuSideBar_Click(object sender, EventArgs e)
        {
            timerMenu.Start();
        }

        //Inicia a transicao do menu lateral
        private void timerMenu_Tick_1(object sender, EventArgs e)
        {
            if (menuExpand)
            {
                SideBar.Width -= 25;

                if (SideBar.Width <= 0)
                {
                    menuExpand = false;

                    timerMenu.Stop();
                }
            }
            else
            {
                SideBar.Width += 25;
                if (SideBar.Width >= 200)
                {
                    menuExpand = true;
                    timerMenu.Stop();
                }
            }
        }

        
        //Aumenta a velocidade do timer
        private void MainForm_Load(object sender, EventArgs e)
        {
            timerMenu.Interval = 3;
            timerMenu.Start();

        }
    }

}
