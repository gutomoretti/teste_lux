using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnquenteTest.Models
{
    public class Enquete_Resposta
    {
        public int Id { get; set; }
        public int Enquete_AlternativaId { get; set; }
        public Enquete_Alternativa Enquete_Alternativa { get; set; }

    }
}
