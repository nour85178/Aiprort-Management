using AM.ApplicationCoree;
using AM.ApplicationCoree.Services;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;


namespace AM.UI.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* //int? a = null;
            string? nom= System.Console.ReadLine();
            System.Console.WriteLine("Bonjour "+nom);
            int ageValue=-1;
            //while (ageValue == -1)
            //{
            //    var age = System.Console.ReadLine();
            //    int.TryParse(age, out ageValue);
            //}
            do
            {
                var age = System.Console.ReadLine();
                int.TryParse(age, out ageValue);
            } while (ageValue == -1);
            System.Console.WriteLine(ageValue + 1);*/



            //Personne personne = new Personne();
            //Personne etudiant = new Etudiant();
            Passenger passenger= new Passenger();
            Staff staff= new Staff();
            Traveller traveller = new Traveller();


            Plane plane = new Plane();
            plane.PlaneType = PlaneType.Airbus;
            plane.Capacity = 100;
            plane.ManufactureDate = new DateTime(2023, 01, 30);


            Plane planep = new Plane(PlaneType.Airbus, 200, DateTime.Now);

            Plane plane1 = new Plane() {
             PlaneType = PlaneType.Airbus,
             Capacity = 100,
             ManufactureDate = new DateTime(2023, 01, 30)   };
            //pas d'ordre de parametre et je peut ajouter dautres


            // personne.Email = "email";
            // personne.Nom = "nom";


            /*  Personne p = new Personne (1,"prenom", DateTime.Now, "nom", "pass", "con ", "email");
              Personne p2 = new Personne()
              {
                  Id = 1,
                  Nom = "nom1",
                  Prenom = "prenom",
                  ConfirmPassword = "conf",
                  Password = "pass",
                  DateNaissance = new DateTime(2022,12,25),
                  Email = "email",
              };*/



            //  personne.GetMyType();
            //  etudiant.GetMyType();


            //  personne.Nom = "4Twin8";

            //  personne.Login("pass", "conf");
            //  personne.Login("pass", "conf","email");
            //  System.Console.WriteLine(personne.Nom);

            System.Console.WriteLine(planep);
            System.Console.WriteLine(planep.Capacity);

            passenger.PassengerType();
            staff.PassengerType();
            traveller.PassengerType();
            //System.Console.WriteLine(staff.PassengerType());

            //seance 3
            /*les collection non generique il faut ajouter namespace 
             System.Collections*/
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add("hello");
            list.Add(new Personne());
            //pour parcourir la liste
            for (int i = 0; i < list.Count; i++)
            {
                //longueur de la liste list.count
                System.Console.WriteLine(list[i]);
                //pour afficher les elements de la liste 
            }
            //ou bien 
            foreach (var item in list)
            {
                System.Console.WriteLine(item);
            }

            /*les collection non generique il faut ajouter namespace 
             System.Collections.Generic;*/
            List<Passenger> list2 = new List<Passenger>();
            list2.Add(new Passenger() { BirthDate = DateTime.Now, FirstName = "Foulen" });
            List<Passenger> list3 = new List<Passenger>()
            {
                new () {BirthDate= DateTime.Now,FirstName="Foulen"}
                //new () il sait que cest un nouveau passenger
      
            };
            List<Traveller> list4 = new List<Traveller>()
            {
                new () {BirthDate= DateTime.Now, Nationality="TN"}

            };
            List<Staff> list5 = new List<Staff>() {
                new() {BirthDate= DateTime.Now  }
            };
            //pour ajouter plusieurs elements
            list3.AddRange(list4);

            //affectation
            list3 = new List<Passenger>(list4);


            //17
            ServiceFlight serviceFlight = new ServiceFlight();
            serviceFlight.ShowFlightDetails(plane);
            serviceFlight.DurationAverage("paris");



            serviceFlight.Flights = TestData.Flights;
            
            serviceFlight.FlightDetailsDel(plane);
            serviceFlight.DurationAverageDel("paris");


            /*int x = 10;
            y=x.Add(10);*/

        }
    }
}