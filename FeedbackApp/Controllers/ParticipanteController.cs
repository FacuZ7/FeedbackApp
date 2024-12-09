using Business;
using Entity.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FeedbackApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ParticipanteController : ControllerBase
    {
        private readonly ParticipanteService _participanteService;

        public ParticipanteController(ParticipanteService participanteService)
        {
            _participanteService = participanteService;
        }


        [HttpGet("HolaMundo")]
        public string GetHolaMundo()
        {
            return "Hola Mundo!";
        }

        [HttpGet("ParticipanteServiceGetOne")]
        public async Task<string> ParticipanteServiceGetOne()
        {
            var result = await _participanteService.GetParticipante(1);
            return $"El participante 1 es: {result.GetNombreApellido()} y tiene {result.GetEdad()} añitos";
        }

        [HttpGet("ParticipanteServiceGetAll")]
        public async Task<IEnumerable<Participante>> ParticipanteServiceGetAll()
        {
            var result = await _participanteService.GetTodosParticipante();
            return result;
        }


    }

}
