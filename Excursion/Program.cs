using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Excursion
{
    class Program
    {
        static void Main(string[] args)
        {
            void PrintList(List<Student> students1)
            {
                Console.WriteLine("Список студентов");
                students1.ForEach(p => p.InfoString()); //Васюхневич показал => doesn't work
                students1.Select(p => p.InfoString()).ToList().ForEach(Console.WriteLine);
               
            }

            void PrintListExecursion(List<dynamic> execursion1)
            {
                Console.WriteLine("\nСведения об всех участниках экскурсии");
                execursion1.Select(x=>x.InfoString()).ToList().ForEach(Console.WriteLine);
            }

                void CountStudent(List<dynamic> execursion1)
            {
                
                Console.WriteLine($"\nКол-во студентов на экскурсии { execursion1.Count(x => x is Student)}");
            }





            //2.2 Не выводится стаж работы. Метод используется только для определения класса Человек
            //2.3
            Person per = new Person("Ann", new DateTime(2000, 11, 12), "жен");
            Teacher tc = new Teacher("Robert", new DateTime(1980, 1, 3), "муж", 12);
            Teacher tc1 = new Teacher("Ludvik", new DateTime(1974, 1, 1), "муж", 30);
            Student st = new Student("Ilya", new DateTime(2005, 8, 20), "муж", 135, 6.5);
            Student st1 = new Student("Nikita", new DateTime(2005, 3, 4), "муж", 135, 6);            
            GraduateStudent advanceStudent = new GraduateStudent("Vadim", new DateTime(1999, 1, 2), "муж", 190, 1, 8.0);
            Console.WriteLine($"Проверка одного из объектов, что создается удачно: {st1.InfoString()}");


            Console.WriteLine("\nСписок людей на экскурсию");

            List<Student> students = new List<Student>() { st, advanceStudent };
            PrintList(students);


            List<dynamic> execursion = new List<dynamic>() { st, tc, st1, tc1, advanceStudent };
            
            PrintListExecursion(execursion);            
            CountStudent(execursion);

        }
    }
}
