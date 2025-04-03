using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS
{
    internal class Enrollment
    {
        public int enrollmentId;
        public Student student;
        public Course course;
        public DateTime enrollmentDate;
        public int EnrollmentID { get; set; }
        public Student Student { get; set; }
        public Course Course { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public Enrollment(int enrollmentId, Student student, Course course, DateTime enrollmentDate)
        {
            this.enrollmentId = enrollmentId;
            this.student = student;
            this.course = course;
            this.enrollmentDate = enrollmentDate;
        }
        public Student GetStudent()
        {
            return Student;
        }

        public Course GetCourse()
        {
            return Course;
        }
    }
}
