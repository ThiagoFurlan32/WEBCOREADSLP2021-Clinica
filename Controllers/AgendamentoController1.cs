using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using WEBCORELP2021.Extra;
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

        public IActionResult PivotPlanodeSaude()
        {
            //String x = "";
            IEnumerable<Agendamento> lstAgendamento = from agendamento in contexto.Consultas
                                                      //.Include(m => m.medico)
                                                      .Include(p => p.paciente)
                                                      .Include(s => s.paciente.planoDeSaude)
                                                      //.OrderBy(ar => ar.descricao)
                                                      //.ThenBy(agr => agr.paciente.nome)
                                                      //.Where(pa => pa.pacienteID == pacid)
                                                      .ToList()
                                                            //group agendamento by new {agendamento.paciente.nome, agendamento.paciente.planoDeSaude}
                                                      //into grupo
                                                        //    order by grupo.Key.

                                                      select new Agendamento
                                                      {
                                                          //descricaoConsulta = agendamento.descricao,
                                                          //nomeMedico = agendamento.medico.nome,
                                                          nomePaciente = agendamento.paciente.nome,
                                                          nomePlano = agendamento.paciente.planoDeSaude.nome
                                                      };

            var PivotTablePlanodeSaude = lstAgendamento.ToList().ToPivotTable(
                pivo => pivo.nomePlano, //Coluna
                pivo => pivo.nomePaciente, //Linha
                pivo => pivo.Any() ? "X" : " "); //valor do pivot

            List<PivotPlanodeSaude> lista = new List<PivotPlanodeSaude>();
            lista = (from DataRow coluna in PivotTablePlanodeSaude.Rows
                     select new PivotPlanodeSaude()
                     {
                         paciente = coluna[0].ToString(),
                         UNIMED = Convert.ToString(coluna[1]),
                         SULAMERICA = Convert.ToString(coluna[2]),
                         CASSI = Convert.ToString(coluna[3]),
                         FUNCEF = Convert.ToString(coluna[4]),
                         NENHUM = Convert.ToString(coluna[5])
                     }).ToList();
            return View(lista);
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
