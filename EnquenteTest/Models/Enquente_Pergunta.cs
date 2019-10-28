using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnquenteTest.Models
{
    public class Enquente_Pergunta
    {
        public int Id { get; set; }
        public int EnqueteId { get; set; }
        public Enquete Enquete { get; set; }
        public string Option_Description { get; set; }

        public virtual List<Enquete_Resposta> Respostas { get; set; }
    }
}
