using System;
using ControleDeEstoque.DataBase;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using BCrypt.Net;

namespace ControleDeEstoque.src
{
    internal class ConsultQuery
    {
        //cria um Hash para a senha
        private static string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        //Recebe dados do cadastro e inseri os dados no Db
        internal static void RegisterUser(String name, string mail, string pass)
        {
            string userN = name;
            string userM = mail;
            string userP = HashPassword(pass);

            using (var context = new AppDbContext())
            {
                bool existe = context.Usuarios.Any(m => m.nome == name && m.email == mail);

                if (!existe)
                {
                    var novoRegistro = new Usuarios { nome = userN, email = userM, senha = userP, tipo_usuario = "Empregado" };
                    context.Usuarios.Add(novoRegistro);
                    context.SaveChanges();

                    Console.WriteLine("Registro Salvo com Sucesso");
                    MessageBox.Show("cadastro realizado");

                }
                else { Console.WriteLine("Registro ja existe"); }
            }

        }

        //Recebe os dados e verifica a existencia no Db
        internal static bool VerifyLogin(String name, string pass)
        {
            using (var context = new AppDbContext()) 
            {
                var usuario = context.Usuarios.FirstOrDefault(u => u.nome == name);

                if (usuario == null) 
                {
                    //Se nao exister retorna false
                    return false;
                }

                bool senhaValida = BCrypt.Net.BCrypt.Verify(pass, usuario.senha);

                if (!senhaValida) 
                {
                    //Se senha invalida retorna false
                    return false;
                }
                //Se o login estiver correto
                return true;
            }
        }
    }
}
