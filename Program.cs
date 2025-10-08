using System;
using UniversityModel;

class Program
{
    static void Main()
    {
        var repo = new StudentRepository();

        // Додавання студентів
        repo.Add(new Student { Id = 1, FullName = "Павло П’ятачук" });
        repo.Add(new Student { Id = 2, FullName = "Юрій Петрухн" });

        // Виведення всіх
        Console.WriteLine("Список студентів:");
        foreach (var s in repo.GetAll())
            Console.WriteLine($"ID: {s.Id}, Ім'я: {s.FullName}");

        // Пошук
        Console.WriteLine("\nПошук за іменем 'Павло':");
        foreach (var s in repo.Find("Павло"))
            Console.WriteLine($"Знайдено: {s.FullName}");

        // Видалення
        repo.Remove(1);
        Console.WriteLine("\nПісля видалення:");
        foreach (var s in repo.GetAll())
            Console.WriteLine($"ID: {s.Id}, Ім'я: {s.FullName}");
    }
}
