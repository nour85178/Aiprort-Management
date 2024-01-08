using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCoree.Interfaces
{
    public interface IServiceFlight
    {
        IEnumerable<IGrouping<string, Flight>> DestinationGroupedFlights();
        IEnumerable<Traveller>Seniortravellerst(Flight flight);
    }
}

