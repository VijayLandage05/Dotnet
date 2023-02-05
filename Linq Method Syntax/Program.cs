namespace LinqMethod
{
    class Example
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>()
            {
                "Dotnet Tutorials",
                "C# Tutorials",
                "Advanced Java"
            };

            var result = list.Where(s=> s.Contains("Tutorials"));

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}