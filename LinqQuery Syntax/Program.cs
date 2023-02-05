namespace LinqQuery
{
    public class Example
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("Java");
            list.Add("Advanced Java");
            list.Add("Concept of Programming");
            list.Add("Dotnet");
            list.Add("DSA");

            // LINQ Query
            var result = from items in list
                         where items.Contains("Java")
                         select items;

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }     
        }
    }
    
}