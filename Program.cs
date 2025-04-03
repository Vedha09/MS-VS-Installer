namespace SIS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SIS sis = new SIS();
            Student student1 = new Student(101, "Alice", "Ben", "2002-11-08", "Alice.081102@gmail.com", "9123456780");
            Course course1 = new Course(1001, "C# Programming", "C#1001", "John");
            Teacher teacher1 = new Teacher(201, "John", "Hitson", "john.9892@gmail.com", "C#");

            sis.EnrollStudentInCourse(student1, course1);
            sis.AssignTeacherToCourse(teacher1, course1);
            student1.DisplayStudentInfo();
            course1.DisplayCourseInfo();
            teacher1.DisplayTeacherInfo();

            sis.RecordPayment(student1, 500, DateTime.Now);
        }
    }
}
