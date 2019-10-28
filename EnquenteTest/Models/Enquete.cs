using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnquenteTest.Models
{
    public class Enquete
    {
        public int Id { get; set; }
        public string Poll_Description { get; set; }

        public virtual List<Enquente_Pergunta> Perguntas { get; set; }
        public virtual List<Enquete_Alternativa> Alternativas { get; set; }
    }
}
