using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCoree
    
{
   public enum PlaneType
    {
        Boing , Airbus
    }
    public class Plane
    {


        public PlaneType PlaneType { get; set; }
        public int Capacity { get; set; }
        public DateTime ManufactureDate { get; set; }
        public int PlaneId { get; set; }
        public IList<Flight> Flights{ get; set;}

        public Plane(PlaneType pt, int capacity, DateTime date)
        {
            PlaneType = pt;
            Capacity = capacity;
            ManufactureDate = date;
        }
        public override string ToString()
        {
            return $"  {PlaneType} ,{Capacity} , {ManufactureDate}  ";
        }
        public Plane()
        {

        }
        


    }
}
