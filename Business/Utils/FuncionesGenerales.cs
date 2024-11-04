namespace Business.Utils
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

    }
}
