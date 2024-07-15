using System.ComponentModel.Design;

namespace University
{
    internal class Program
    {
        static void Main(string[] args)
        {
            University university = new University("Politexnik",new DateTime(1950), 1000);
            
            university.AddStudent("Armen");
            university.RemoveStudent("Anna");
            university.GraduateStudent("Arsen");

            Student student = new Student("Armen", "Barseghyan", 36, "AB123456");
        }
    }
    class University
    {
        private string name;
        private DateTime FoundedAt;
        private string[] students;
        private int count;
        private int capacity;

        public University(string name, DateTime FoundedAt, int capacity)
        {
            this.name = name;
            this.FoundedAt = FoundedAt;
            this.capacity = capacity;
            students = new string[capacity];
            count = 0;
        }
        public void AddStudent(string studentName)
        {
            if (count < capacity)
            {
                students[count] = studentName;
                count++;
                capacity--;
                Console.WriteLine($"{studentName} addmited in university.");
            }
            else
            {
                Console.WriteLine("Cannot admit more students.");
            }
        }
        public void RemoveStudent(string studentName)
        {
            bool found = false;
            for (int i = 0; i < count; i++)
            {
                if (students[i] == studentName)
                {
                    found = true;
                    count--;
                    Console.WriteLine($"{studentName} has been removed from {name}.");
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine($"{studentName} is not found in {name} records.");
            }

        }
        public void GraduateStudent(string studentName)
        {
            
        }
    }
    class Student
    {
        private string Name;
        private string Surname;
        private int Age;
        private string Passport;
        

        public Student(string name, string surname, int age, string passport )
        {
            Name = name;
            Surname = surname;
            Age = age;
            Passport = passport;
           

        }
    }
}
