namespace Entity.Utils
{
    public static class FuncionesGenerales
    {
        public static string PrimeraLetraMayuscula(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            return char.ToUpper(input[0]) + input.Substring(1);
        }

        public static string DatoRequerido(string dato) => $"{PrimeraLetraMayuscula(dato)} es un dato requerido";

        public static string FechaPosteriorAHoy() => "La fecha ingresada no puede ser mayor a hoy";

    }
}
