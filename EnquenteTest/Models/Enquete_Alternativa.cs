using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnquenteTest.Models
{
    public class Enquete_Alternativa
    {
        public int Id { get; set; }
        public int EnquentePerguntaId { get; set; }
        public Enquente_Pergunta Enquente_Pergunta { get; set; }
        public string Option_Description { get; set; }
    }
}
