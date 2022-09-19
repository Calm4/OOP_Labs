using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Subject[] subject = new Subject[Enum.GetNames(typeof(Subject)).Length];
            Student[] student =
             {
                new Student("Громыко Иван",Group.ITI_21,subject),
                new Student("Гаращук Иван",Group.ITI_21,subject),

                new Student("Свинка Пеппа",Group.ITI_22, subject),
                new Student("Михалков Вениамин",Group.ITI_22, subject),

                new Student("Месси Глиномесси",Group.ITP_21,subject),
                new Student("Комраков Кормаков",Group.ITP_21, subject),

                new Student("Жесточайший Кринж",Group.ITP_22,subject),
                new Student("Суковатый Александр",Group.ITP_22,subject),
            };
            bool isWork = true;

            while (isWork)
            {
                Console.WriteLine("\tМЕНЮ\t");
                Console.WriteLine("0)Получить оценки студентов");
                Console.WriteLine("1)Вывести список студентов и их оценки");
                Console.WriteLine("2)Вывести по каждому предмету средний балл");
                Console.WriteLine("3)Вывести по каждой студенческой группе средний балл на ссесии");
                Console.WriteLine("4)Вывести количество студентов, получивших неудовлетворительные оценки, по указанному предмеиу");
                Console.WriteLine("5)Выход");
                int punctOfMenu = Convert.ToInt32(Console.ReadLine());
                switch (punctOfMenu)
                {
                    case 0:
                        for (int i = 0; i < student.Length; i++)
                        {
                            for (int j = 0; j < Enum.GetNames(typeof(Subject)).Length; j++)
                            {
                                student[i].Subject[j] = (Subject)random.Next(1, 11);

                            }
                            Console.WriteLine();

                        }

                        break;
                    case 1:
                        for (int i = 0; i < student.Length; i++)
                        {
                            Console.WriteLine(student[i].FI + " : " + student[i].Group);
                            for (int j = 0; j < Enum.GetNames(typeof(Subject)).Length; j++)
                            {
                                Console.Write(Enum.GetValues(typeof(Subject)).GetValue(j) + ": ");
                                Console.WriteLine((int)student[i].Subject[j]);

                            }
                            Console.WriteLine();

                        }
                        break;
                    case 2:
                        for (int i = 0; i < Enum.GetNames(typeof(Subject)).Length; i++)
                        {
                            Student.ShowAverageMarkSubject(student, subject[i], i);
                        }
                        break;
                    case 3:
                        Student.ShowGroupAverageSsesionMark(student);
                        break;
                    case 4:
                        Student.ShowStudentsWithPoorMark(student, subject);
                        break;
                    case 5:
                        isWork = false;
                        break;
                    default:

                        break;

                }
                Console.ReadKey();
                Console.Clear();
            }


        }
    }
}
