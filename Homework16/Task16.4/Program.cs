namespace Task16._4
{
    internal class Program
    {
        // Custom Interface Properties:
        static void Main(string[] args)
        {
            Student student = new Student("Hakob",28,16);
            student.Info();
            student.Name = "Armen";
            student.Age = 36;
            student.Grade = 18;
            student.Info();

        }
    }
    interface IStudent
    {
        string Name { get; set; }
        int Age { get; set; }
        int Grade { get; set; }

    }
    class Student : IStudent
    {

        private string name { get; set; }
        private int age { get; set; }
        private int grade { get; set; }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public int Grade
        {
            get { return grade; }
            set { grade = value; }
        }
        public Student(string name, int age, int grade)  
        {
            Name = name;
            Age = age;
            Grade = grade;
          
        }
        public void Info()
        {
            Console.WriteLine("Name - " + Name);
            Console.WriteLine("Age - " + Age);
            Console.WriteLine("Grade - " + Grade);
        }
    }
}
