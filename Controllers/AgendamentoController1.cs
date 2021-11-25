using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEBCORELP2021.Models;
using WEBCORELP2021.Models.Consultas;
using WEBCORELP2021.Models.Dominio;

namespace WEBCORELP2021.Controllers
{
    public class AgendamentoController1 : Controller
    {
        private readonly Contexto contexto;

        public AgendamentoController1(Contexto context)
        {
            contexto = context;
        }

        public IActionResult ListarAgendamento()
        {
            IEnumerable<Agendamento> lstAgendamento = from agendamento in contexto.Consultas
                                                      .Include(m => m.medico)
                                                      .Include(p => p.paciente)
                                                      .Include(s => s.paciente.planoDeSaude)
                                                      .ToList()
                                                      select new Agendamento {
                                                          descricaoConsulta = agendamento.descricao,
                                                          nomeMedico = agendamento.medico.nome,
                                                          nomePaciente = agendamento.paciente.nome,
                                                          nomePlano = agendamento.paciente.planoDeSaude.nome
                                                           };
            return View(lstAgendamento);

        }

    }
}
