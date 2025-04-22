using System.Text;

namespace Test3_SchoolObj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string schoolName = Console.ReadLine();
            School school = new School(schoolName);

            string[] command = Console.ReadLine().Split();
            Student student = null;

            while (command[0] != "End")
            {
                switch (command[0])
                {
                    case "Enroll":
                        student = new Student(command[1], command[2]);
                        school.EnrollStudent(student);
                        Console.WriteLine($"{student} was successfully enrolled!");
                        break;
                    case "Unenroll":
                        Student stdnt = school.UnenrollStudent(int.Parse(command[1]));
                        if (stdnt != null)
                        {
                            Console.WriteLine($"{stdnt} was successfully unenrolled!");
                        }
                        else
                        {
                            Console.WriteLine("No such Id in our database!");
                        }
                        break;
                    case "Print":
                        Console.WriteLine(school);
                        break;
                }

                command = Console.ReadLine().Split();
            }
        }
    }

    class Student
    {
        private static int id = 0;
        private int studentId;
        private string fullName;
        public Student(string firstName, string lastName)
        {
            id++;
            this.StudentId = id;
            this.FullName = $"{firstName} {lastName}";
        }

        public int StudentId
        {
            get { return studentId; }
            private set { studentId = value; }
        }

        public string FullName
        {
            get { return fullName; }
            private set { fullName = value; }
        }


        public override string ToString()
        {
            return $"Student ID: {studentId} Name: {fullName}"; 

        }
    }

    class School
    {
        private List<Student> students = new List<Student>();
        private string name;

        public School(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get { return Name; }
            private set { name = value; }
        }

        public void EnrollStudent(Student student)
        {
            students.Add(student);
        }
        public Student UnenrollStudent(int id)
        {

            if (this.students.Count == 0 || students.Find(s => s.StudentId == id) == null)
            {
                return null;
            }

            Student student = students.Find(s => s.StudentId == id);
            students.Remove(student);
            return student;

        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{this.Name}:");
            foreach (var student in this.students)
            {
                sb.AppendLine();
                sb.Append(student.ToString());
            }
            return base.ToString();
        }
    }
}
