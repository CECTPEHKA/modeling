using System;
using System.Collections.Generic;

namespace UniversityModel
{
    // Клас Студент
    public class Student
    {
        public int Id { get; set; }
        public string FullName { get; set; }

        // Зв’язок «багато-до-багатьох»
        public List<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
    }

    // Клас Курс
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }

        // Зв’язок «багато-до-багатьох»
        public List<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
    }

    // Клас-зв’язок (many-to-many)
    public class Enrollment
    {
        public int StudentId { get; set; }
        public Student Student { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }

        public DateTime EnrollDate { get; set; }
    }
}
