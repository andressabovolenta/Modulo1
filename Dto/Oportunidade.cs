using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo1.Dto
{
    public class Oportunidade: Domain
    {
        public string Salario { get; set; }
        public List<Candidato> Candidatos { get; set; }
    }
}
