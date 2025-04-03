using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS
{
    internal class Course
    {
        public int courseId;
        public string courseName;
        public string courseCode;
        public Teacher instructorName;
        public int CourseID {
            set {
                courseId = value;
            }
            get {
                return courseId;
            }
        }
        public string CourseName {
            set {
                courseName = value;
            }
            get {
                return courseName;
            }
        }
        public string CourseCode {
            set {
                courseCode = value;
            }
            get {
                return courseCode;
            }
        }
        public Teacher InstructorName {
            set {
                instructorName = value;
            }
            get {
                return instructorName;
            }
        }

        public Enrollment[] Enrollments = new Enrollment[100];
        private int enrollmentCount = 0;

        public Course(int courseId, string courseName, string courseCode, string instructorName)
        {
            this.courseId = courseId;
            this.courseName = courseName;
            this.courseCode = courseCode;
            instructorName = null;
        }

        public void AddEnrollment(Enrollment enrollment)
        {
            Enrollments[enrollmentCount++] = enrollment;
        }
        public void AssignTeacher(Teacher teacher)
        {
            instructorName = teacher;
        }
        
        public void DisplayCourseInfo()
        {
            Console.WriteLine($"Course ID: {CourseID}, Course Name: {CourseName}, Course Code: {CourseCode}, Instructor Name: {(InstructorName != null ? InstructorName.FirstName + " " + InstructorName.LastName : "Not Assigned")}");
        }
        public Enrollment[] GetEnrollments()
        {
            Enrollment[] result = new Enrollment[enrollmentCount];
            Array.Copy(Enrollments, result, enrollmentCount);
            return result;
        }
        public Teacher GetTeacher()
        {
            return instructorName;
        }
    }
}
