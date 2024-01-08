using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCoree
{
    public class  Personne
    {
        public Personne(int id, string prenom, DateTime dateNaissance, string nom, string password, string confirmPassword, string email)
        {
            Id = id;
            Prenom = prenom;
            DateNaissance = dateNaissance;
            Nom = nom;
            Password = password;
            ConfirmPassword = confirmPassword;
            Email = email;
        }
        public Personne()
        {

        }

        public int Id { get; set; }
        public string Prenom { get; set; }
        public DateTime DateNaissance { get; set; }
        public string Nom { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string  Email { get; set; }

        public bool Login (string password , string confirmPassword ) {
            return this.Password == password && ConfirmPassword == confirmPassword;  }
        public bool Login(string password, string confirmPassword, string email)
        {
            return this.Password == password && ConfirmPassword == confirmPassword;
        }
        public override string ToString()
        {
            return $" {Id} , {Nom} , {Prenom} , {DateNaissance} ";
                
        }

        public virtual void GetMyType()
        {
            Console.WriteLine("je suis Personne");
        }
    }
}

