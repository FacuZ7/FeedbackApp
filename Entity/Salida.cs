namespace Entity
{
    public class Salida
    {
        public Establecimiento Establecimiento { get; set; }
        public List<Participante> Participantes { get; set; }

        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin {  get; set; }

        public string Feedback { get; set; } //a futuro quizas tenga que ser su propia clase. hoy no es necesario.

        public Salida(Establecimiento establecimiento, List<Participante> participantes, DateTime fechaInicio, DateTime fechaFin)
        {
            Establecimiento = establecimiento;
            Participantes = participantes;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
        }
    }
}
