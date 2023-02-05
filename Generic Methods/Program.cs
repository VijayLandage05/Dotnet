namespace GenericMethods
{
    public class Program<T>
    {
        public void showValue(T value)
        {
            Console.WriteLine(value);
        }
    }

    class TestProgram
    {
        static void Main(string[] args)
        {
            Program<int> i = new Program<int>();
            i.showValue(100);

            Program<string> s = new Program<string>();
            s.showValue("Vijay");
        }
    }
}