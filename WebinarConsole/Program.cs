using System;
using System.Collections.Generic;

namespace WebinarConsole
{
    // Główna klasa programu.
    class Program
    {
        // Główna metoda programu, która wykonuje się na jego starcie.
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Lista studentów.
            var students = new List<Student>
            {
                new Student
                {
                    AlbumId = 1000, FirstName = "Luke", LastName = "Skywalker", Grades = new [] {4, 5, 4}
                },
                new Student
                {
                    AlbumId = 1033, FirstName = "Marcin", LastName = "Maciewski", Grades = new [] {2, 3, 3}
                },
                new Student
                {
                    AlbumId = 1055, FirstName = "Martyna", LastName = "Manicka", Grades = new [] {5, 5, 1}
                },
                new Student
                {
                    AlbumId = 1069, FirstName = "Gniewko", LastName = "Gniewosz", Grades = new [] {2, 3, 4}
                }
            };
            // Pętla iterująca po wszstkich studentach.
            foreach (Student student in students) // "students" jest naszą kolekcją studentów, a "student" zmienną pomocniczą reprezentującą każdego studenta po kolei w kolejnych iteracjach pętli.
            {
                Console.WriteLine($"{student.AlbumId}: {student.FirstName} {student.LastName}, oceny: {string.Join(", ", student.Grades)}");
            }

            // Linijka wymuszająca na programie oczekiwanie na jego końcu. Dodana w celu uniknięcia automatycznego zamykania konsoli.
            Console.ReadKey();
        }
    }

    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int[] Grades { get; set; }
        public int AlbumId { get; set; }
    }
}
