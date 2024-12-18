using Business;
using Entity.Entities;
using Infrastructure_SQLServer.Models;
using Infrastructure_SQLServer.Presenters;
using Microsoft.AspNetCore.Mvc;

namespace FeedbackApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ParticipanteController : ControllerBase
    {
        private readonly ParticipanteService<Entity.Entities.Participante, ParticipanteViewModel> _participanteService;

        public ParticipanteController(ParticipanteService<Entity.Entities.Participante, ParticipanteViewModel> participanteService)
        {
            _participanteService = participanteService;
        }


        [HttpGet("HolaMundo")]
        public string GetHolaMundo()
        {
            return "Hola Mundo!";
        }

        [HttpGet("ParticipanteServiceGetOne")]
        public async Task<ParticipanteViewModel> ParticipanteServiceGetOne()
        {
            var result = await _participanteService.GetParticipante(1);
            return result;
        }

        [HttpGet("ParticipanteServiceGetAll")]
        public async Task<IEnumerable<ParticipanteViewModel>> ParticipanteServiceGetAll()
        {
            var result = await _participanteService.GetTodosParticipante();
            return result;
        }


    }

}
