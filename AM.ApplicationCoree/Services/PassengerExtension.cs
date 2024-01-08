using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCoree.Services
{
    public static class PassengerExtension
    {
        //parametre doit etre precede par this w type est le meme dans la classe ou il vas etre injecte
        public static void FullNamePassenger(this Passenger passenger) 
        { 
            //substring tekhou nbre de caractere min chaine yabdda min indice i l indice j ki nhot haja yabda mil loiuel lil j 
            passenger.FirstName= passenger.FirstName[0].ToString().ToUpper()+passenger.FirstName.Substring(1);
            passenger.FirstName = passenger.LastName[0].ToString().ToUpper() + passenger.LastName.Substring(1);
        }
    }
}
