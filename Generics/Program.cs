namespace Generics
{
    public class Program<T>
    {
        public T data;
    }

    class TestProgram
    {
        static void Main(string[] args)
    {
            Program<int> x = new Program<int>();
            x.data=100;
            Console.WriteLine(x.data);

            Program<string> s = new Program<string>();
            s.data = "Vijay";
            Console.WriteLine(s.data);
    }
    }
    
}