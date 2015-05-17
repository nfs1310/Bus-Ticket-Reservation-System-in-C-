using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bus_ticket
{
    class GetConnectionString
    {
        public string getString()
        {
            return @"Data Source=OMI\SQLEXPRESS;Initial Catalog=BusTicket;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";
        }
    }
}
