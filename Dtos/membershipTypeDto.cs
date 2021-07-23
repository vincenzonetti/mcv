using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Veenca.Dtos
{
    public class membershipTypeDto
    {
        public int id { get; set; }
        public string textAbbonamento { get; set; }
        /* è consigliato inserire nei Dtos solamente gli attributi essenziali della classe che si vuole
        replicare in quanto se l'utente vuole tutti i dati, manderà una richiesta nella classe principale
         */
    }
}