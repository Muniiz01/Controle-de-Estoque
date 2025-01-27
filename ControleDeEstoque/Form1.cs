using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using ControleDeEstoque.src;
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
        //mostra o painel de registro
        {
            loginPanel.Visible = false;
            starterApp.Visible = true;
            registerPanel.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void loginPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void buttonCadastro_Click(object sender, EventArgs e)
        {
            ShowpanelRegisteer();
        }
        
        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            string a = entryName.Text;
            string b = entryMail.Text;
            string c = entryPassword.Text;
            ConsultQuery.RegisterUser(a,b,c); 


        }

        
    }

}
