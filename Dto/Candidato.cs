using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo1.Dto
{
    public class Candidato : Domain
    {
        public string Email { get; set; }
        public int Nota { get; set; }
        public bool Aprovado { get; set; }
    }
}
