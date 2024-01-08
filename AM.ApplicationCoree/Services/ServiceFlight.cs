using AM.ApplicationCoree;
using AM.ApplicationCoree.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Data.Common;

namespace AM.ApplicationCoree.Services
{
    public class ServiceFlight:IServiceFlight
    {
        public List<Flight> Flights { get; set; } = new List<Flight>();


        /*List<DateTime> GetFlightDates(string destination)
        {
            List<DateTime> result = new List<DateTime>();
            for(int i=0; i< Flights.Count; i++)
            {
                Flight flight = Flights[i];
                if (flight.Destination==destination)
                {
                    result.Add(flight.FlightDate);

                }
            }
            return result;
        }*/

        /*methode2
        IEnumerable<DateTime> GetFlightDates(string destination)

        {
            for (int i = 0; i < Flights.Count; i++)
            {

                Flight flight = Flights[i];
                if (flight.Destination == destination)
                {
                    yield return flight.FlightDate;

                }
            }

        }*/
        ///  question 8 
        public void GetFlights(string filterType, string filterValue)
        {
            switch (filterType)
            {
                case "Destination":
                    {
                        var result = Flights.Where(f => f.Destination == filterValue).ToList();
                        foreach (var f in result)
                        {
                            Console.WriteLine(f);
                        }
                    }
                    break;
                case "Departure":
                    {
                        var result = Flights.Where(f => f.Departure == filterValue).ToList();
                        foreach (var f in result)
                        {
                            Console.WriteLine(f);
                        }
                    }
                    break;
                case "FlightDate":
                    {
                        var result = Flights.Where(f => f.FlightDate == DateTime.Parse(filterValue)).ToList();
                        foreach (var f in result)
                        {
                            Console.WriteLine(f);
                        }
                    }
                    break;
                case "FlightId":
                    {
                        var result = Flights.Where(f => f.FlightId == int.Parse(filterValue)).ToList();
                        foreach (var f in result)
                        {
                            Console.WriteLine(f);
                        }
                    }
                    break;
                case "EffectiveArrival":
                    {
                        var result = Flights.Where(f => f.EffectiveArrival == DateTime.Parse(filterValue)).ToList();
                        foreach (var f in result)
                        {
                            Console.WriteLine(f);
                        }
                    }
                    break;
                case "EstimatedDuration":
                    {
                        var result = Flights.Where(f => f.EstimatedDuration == int.Parse(filterValue)).ToList();
                        foreach (var f in result)
                        {
                            Console.WriteLine(f);
                        }
                    }
                    break;
            }
        }
        //quest9
        IEnumerable<DateTime> GetFlightDates(string destination)
        {
            //foreach (var flight in Flights)
            //{
            //    if (flight.Destination == destination)
            //    {
            //        yield return flight.FlightDate;
            //    }
            //}

            //9
            IEnumerable<DateTime> query = from f in Flights
                                          where f.Destination == destination
                                          select f.FlightDate;
            return query;
        }
        //quest10
         public void  ShowFlightDetails(Plane plane)
         {
            var query = from f in Flights
                       where f.Plane.PlaneId== plane.PlaneId
                       select  new {f.FlightDate , f.Destination };
           foreach (var item in query)
           {
               Console.WriteLine(item.Destination+item.FlightDate);
           }
            

        }
        //quest11
        public int ProgrammedFlightNumber(DateTime startDate)
        {
            var query = from f in Flights
                        where ((f.FlightDate >= startDate) && (startDate - f.FlightDate).TotalDays < 7)
                        select f;
                        ;
                        
           
            return query.Count() ;


           //2eme methode
          /* return Flights.Count(f => ((f.FlightDate >= startDate) && (startDate - f.FlightDate).TotalDays < 7)
                        );*/

        }
        //quest 12
        public double DurationAverage(string destination)
        {
             var query = from f in Flights
                         where (f.Destination == destination)
                         select f.EstimatedDuration;
             return query.Average();
            //2eme methode anonyme:lambda
           // return Flights.Where(f=>f.Destination == destination).Average(f => f.EstimatedDuration);

        }
        //quest13
        public IEnumerable<Flight> OrderedDurationFlights()
        {
            var query = from f in Flights
                        orderby f.EstimatedDuration descending
                        select f;
            return query;
            
        }
        //quest14 ne pas oublier signature interface
        public List<Traveller> travellers { get; set; } = new List<Traveller>();
        /*public IEnumerable<Traveller> SeniorTravellers(Flight flight)
        {
            var query = from t in travellers
                        where (t.Flights==flight)
                        orderby t.BirthDate
                        select t;
            return query.Take(3) ;
        }*/
        //corr
        public IEnumerable<Traveller> SeniorTravellers(Flight flight)
        {
            var query = flight.Passengers.OfType <Traveller>()
                        .OrderBy(p=>p.BirthDate).Take(3)
                        ;
            return query;
       
        }


        //quest15
        public void DestinationGroupedFlights()
        {
            var query = from f in Flights
                        group f by f.Destination;

            foreach (var q in query)
            {
                Console.WriteLine("Destination"+q.Key);
                foreach (var a in q)
                {
                    Console.WriteLine("Decollage"+a.FlightDate);
                    Console.WriteLine();
                }
            }
            //var query = Flights.GroupBy(f=>f.Destination);
        }
        //question 16
        public Action <Plane> FlightDetailsDel { get; set; } 
        public Func<string,double> DurationAverageDel { get; set; }

        //question 17
        //non parametre car dans la meme classe
        
        public ServiceFlight()
        {    //affection b essem l methode
            /*FlightDetailsDel = ShowFlightDetails;
            DurationAverageDel = DurationAverage;*/
            //affection bl corps anonyme
            //FlightDetailsDel = delegate (Plane plane) et le corps
            //ou exp lambda
            FlightDetailsDel = (Plane plane) =>

            {
                var query = from f in Flights
                            where f.Plane.PlaneId == plane.PlaneId
                            select new { f.FlightDate, f.Destination };
                foreach (var item in query)
                {
                    Console.WriteLine(item.Destination + item.FlightDate);
                }
            };
            //si j ai un parametre pas la peine le type si j ai une instruction pas la peine crochet
            DurationAverageDel = destination =>
            {
                var query = from f in Flights
                            where (f.Destination == destination)
                            select f.EstimatedDuration;
                return query.Average();
            };

        }
        //question 18
        //2eme methode anonyme:lambda
        // return Flights.Where(f=>f.Destination == destination).Average(f => f.EstimatedDuration);
    }   //return Plane.Flights.select(f => new { f.FlightDate, f.Destination });
}

