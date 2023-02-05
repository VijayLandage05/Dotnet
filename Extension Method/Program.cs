namespace ExtensionMethod
{
    public class ExistingClass
    {
        public void M1()
        {
            Console.WriteLine("M1 Method Called");
        }

        public void M2()
        {
            Console.WriteLine("M2 Method Called");
        }

        public void M3()
        {
            Console.WriteLine("M3 method Called");
        }
    }

    public static class NewClass
    {
        public static void M4(this ExistingClass h)
        {
            Console.WriteLine("M4 Method Called");
        }

        public static void M5(this ExistingClass h, string str)
        {
            Console.WriteLine(str);
        }
    }

    class Program
    {
        static void Main(string[] args)
      {
        ExistingClass obj = new ExistingClass();

        obj.M1();
        obj.M2();
        obj.M3();
        obj.M4();
        obj.M5("M5 Method Called from a parameter");
      }
    }
}