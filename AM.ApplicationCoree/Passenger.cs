using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCoree
{
    public class Passenger
    {
        public DateTime BirthDate { get; set; }
        public int PassportNumber { get; set; }
        public string EmailAddress { get; set;}
        public string FirstName { get; set;}
        public string LastName { get; set;}
        public string TelNumber { get; set;}
        public IList<Flight> Flights { get; set; }

        public override string ToString()
        {
            return $" {BirthDate} , {PassportNumber} , {EmailAddress} , {FirstName} , {LastName} , {TelNumber} ";

        }
        //Une méthode pour vérifier le profile en utilisant deux paramètres: nom du passager
        //et prénom du passager.
        public bool verif (string nom , string prenom)
        {
            return LastName==nom && FirstName == prenom;
        }
        //Une méthode pour vérifier le profile en utilisant trois paramètres: nom du
        //passager, prénom du passager et email du passager.
        /*public bool verif(string nom, string prenom ,string email)
        {
            return LastName == nom && FirstName == prenom && EmailAddress == email;
        }*/
        //Une méthode pour remplacer à la fois les deux méthodes précédentes.
        public bool verif(string nom, string prenom, string email=null)
        {
            if(email!=null)
                return LastName == nom && FirstName == prenom && EmailAddress == email;
            else
                return LastName == nom && FirstName == prenom;

        }
        public virtual void PassengerType(){
            Console.WriteLine("I am a passenger");
        }
    }
 
}
