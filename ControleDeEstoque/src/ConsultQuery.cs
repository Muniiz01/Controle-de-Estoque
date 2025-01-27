using System;
using ControleDeEstoque.DataBase;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using BCrypt.Net;

namespace ControleDeEstoque.src
{
    internal class ConsultQuery
    {
        private static string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }
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
    }
}
