using Modulo1.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo1.Service
{
    public class OportunidadeService
    {
        public Oportunidade Salvar(string nome, string salário)
        {
            Oportunidade oportunidade = new Oportunidade();
            oportunidade.Nome = nome;
            oportunidade.Salario = salário;

            return oportunidade;
        }

        public Oportunidade AtribuirCandidatoAprovado(Oportunidade oportunidade, string nomeCandidato)
        {
            oportunidade.Candidatos.ForEach(c =>
            {
                if (c.Nome == nomeCandidato)
                    c.Aprovado = true;
            });
            return oportunidade;
        }
    }
}
