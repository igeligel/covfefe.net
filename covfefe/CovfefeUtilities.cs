namespace covfefe
{
    public static class CovfefeUtilities
    {
        public static string Covfefe(string input)
        {
            return $"{input} covfefe";
        }

        public static string Translate(this string input)
        {
            return input.Replace("coverage", "covfefe");
        }
    }
}
