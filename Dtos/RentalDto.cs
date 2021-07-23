using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Veenca.Dtos
{
    public class RentalDto
    {
        public int customerId { get; set; }
        public List<int> MovieIds{ get; set; }
    }
}