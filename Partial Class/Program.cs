namespace PartialClass
{
    public partial class Student
    {
        public int studentId;
        public string studentName;

        public Student(int id, string name)
        {
            this.studentId=id;
            this.studentName=name;
        }
    }

    public partial class Student
    {
        public void displayStudent()
        {
            Console.WriteLine("Student Id :"+studentId);
            Console.WriteLine("Student Name :"+studentName);
        }
    }

    class StudentMain
    {
        static void Main(string[] args)
        {
            Student obj = new Student(1,"Vijay");
            obj.displayStudent();
        }
        
    }
}