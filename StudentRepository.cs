using System;
using System.Collections.Generic;
using System.Linq;

namespace UniversityModel
{
    public class StudentRepository
    {
        private List<Student> students = new List<Student>();

        // Додати студента
        public void Add(Student student)
        {
            students.Add(student);
        }

        // Видалити студента за ID
        public void Remove(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);
            if (student != null)
            {
                students.Remove(student);
            }
        }

        // Пошук за ім’ям (або частиною імені)
        public List<Student> Find(string namePart)
        {
            return students
                .Where(s => s.FullName.Contains(namePart, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        // Отримати всіх студентів
        public List<Student> GetAll()
        {
            return students;
        }
    }
}
