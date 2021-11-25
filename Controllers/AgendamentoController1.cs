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

        [HttpGet("AgendamentoController1/ListarAgendamento/{pacid}")]
        public IActionResult ListarAgendamento(int pacid)
        {

            IEnumerable<Agendamento> lstAgendamento = from agendamento in contexto.Consultas
                                                      .Include(m => m.medico)
                                                      .Include(p => p.paciente)
                                                      .Include(s => s.paciente.planoDeSaude)
                                                      .OrderBy(ar => ar.descricao)
                                                      .ThenBy(agr => agr.paciente.nome)
                                                      .Where(pa => pa.pacienteID == pacid)
                                                      .ToList()
                                                      select new Agendamento {
                                                          descricaoConsulta = agendamento.descricao,
                                                          nomeMedico = agendamento.medico.nome,
                                                          nomePaciente = agendamento.paciente.nome,
                                                          nomePlano = agendamento.paciente.planoDeSaude.nome
                                                           };
            return View(lstAgendamento);

        }


        public IActionResult ListarAgendamento()
        {

            IEnumerable<Agendamento> lstAgendamento = from agendamento in contexto.Consultas
                                                      .Include(m => m.medico)
                                                      .Include(p => p.paciente)
                                                      .Include(s => s.paciente.planoDeSaude)
                                                      .OrderBy(ar => ar.descricao)
                                                      .ThenBy(agr => agr.paciente.nome)
                                                      //.Where(pa => pa.pacienteID == pacid)
                                                      .ToList()
                                                      select new Agendamento
                                                      {
                                                          descricaoConsulta = agendamento.descricao,
                                                          nomeMedico = agendamento.medico.nome,
                                                          nomePaciente = agendamento.paciente.nome,
                                                          nomePlano = agendamento.paciente.planoDeSaude.nome
                                                      };
            return View(lstAgendamento);

        }
    }
}
