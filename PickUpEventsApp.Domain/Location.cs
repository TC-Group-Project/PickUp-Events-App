using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickUpEventsApp.Domain
{
    internal class Location
    {
        string AddressLine1 { get; set; }

        string? AddressLine2 { get; set; }

        string City { get; set; }

        string State { get; set; }

        string PostalCode { get; set; }
    }
}
