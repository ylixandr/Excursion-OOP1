using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excursion
{
    class Program
    {
        static void Main(string[] args)
        {
            void PrintList(List<Student> students1)
            {
                //for (int i = 0; i < students1.Count; i++)
                //{
                //    Console.WriteLine(students1[i].InfoString());
                //}
                students1.Select(student => student.InfoString()).ToList().ForEach(Console.WriteLine);
            }

            void PrintListExecursion(List<dynamic> execursion1)
            {
                //for (int i = 0; i < execursion1.Count; i++)
                //{
                //    Console.WriteLine(execursion1[i].InfoString());
                //}
                //execursion1.Select(x => x.InfoString()).ToList().ForEach(Console.WriteLine);
            }

                void CountStudent(List<dynamic> execursion1)
            {
                //int count = 0;
                //for (int i = 0; i < execursion1.Count; i++)
                //{

                //    if (execursion1[i] is Student)
                //        count++;
                //}
                //Console.WriteLine("Кол-во студентов = " + count);
                Console.WriteLine($"Кол-во студентов { execursion1.Count(x => x is Student)}");
            }



            Person per = new Person("Ann", new DateTime(2000, 11, 12), "жен");
            Console.WriteLine(per.InfoString());

            Teacher tc = new Teacher("Robert", new DateTime(1980, 1, 3), "муж", 12);
            Console.WriteLine(tc.InfoString());

            Teacher tc1 = new Teacher("Ludvik", new DateTime(1974, 1, 1), "муж", 30);

            //2.2 Не выводится стаж работы. Метод используется только для определения класса Человек
            //2.3
            Student st = new Student("Ilya", new DateTime(2005, 8, 20), "муж", 135, 6.5);
            Student st1 = new Student("Nikita", new DateTime(2005, 3, 4), "муж", 135, 6);
            //Console.WriteLine(st.InfoString());
            GraduateStudent advanceStudent = new GraduateStudent("Vadim", new DateTime(1999, 1, 2), "муж", 190, 1, 8.0);
            //Console.WriteLine(advanceStudent.InfoString());
            st.GetScholarShip();
            Console.WriteLine(st.InfoString());
            advanceStudent.GetScholarShip();
            Console.WriteLine(advanceStudent.InfoString());
            Console.WriteLine("\nСписок");

            List<Student> students = new List<Student>() { st, advanceStudent };
            PrintList(students);


            List<dynamic> execursion = new List<dynamic>() { st, tc, st1, tc1, advanceStudent };
            Console.WriteLine("\nСведения об участниках экскурсии");
            PrintListExecursion(execursion);
            Console.WriteLine("\n\n");
            CountStudent(execursion);

        }
    }
}
