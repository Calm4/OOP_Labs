using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_06
{
    internal class Student
    {
        static private int enumGroupCount = Enum.GetNames(typeof(Group)).Length;
        static private int enumSubjectCount = Enum.GetNames(typeof(Subject)).Length;
        public string FI { get; set; }
        public Group Group { get; set; }
        public Subject[] Subject = new Subject[enumSubjectCount];
        public Group[] Groups = new Group[enumGroupCount];
        public Student(string FI, Group Group, Subject[] Subject)
        {
            this.FI = FI;
            this.Group = Group;
            for (int i = 0; i < enumSubjectCount; i++)
            {
                Subject[i] = (Subject)Enum.GetValues(typeof(Subject)).GetValue(i);
                this.Subject[i] = Subject[i];

            }
        }

        public Random random = new Random();

        static public void ShowAverageMarkSubject(Student[] student, Subject subject, int index)
        {
            double sum = 0;
            double averageMarkSubject = 0;
            for (int i = 0; i < student.Length; i++)
            {
                sum += (int)student[i].Subject[(int)subject];
            }
            averageMarkSubject = sum / student.Length;
            Console.WriteLine(Enum.GetValues(typeof(Subject)).GetValue(index) + ": " + averageMarkSubject);

        }
        static public void ShowGroupAverageSsesionMark(Student[] student)
        {
            double[] groupSumMark = new double[enumGroupCount];
            double[] groupAverageMark = new double[enumGroupCount];
            int[] studentsInOneGroup = new int[enumGroupCount];
            for (int i = 0; i < enumGroupCount; i++)
            {
                for (int j = 0; j < student.Length; j++)
                {
                    if (student[j].Group == (Group)Enum.GetValues(typeof(Group)).GetValue(i))
                    {
                        for (int k = 0; k < enumSubjectCount; k++)
                        {
                            studentsInOneGroup[i]++;
                            groupSumMark[i] += (double)student[j].Subject[k];

                        }
                    }
                }
            }
            /*for (int i = 0; i < student.Length; i++)
            {
                for (int j = 0; j < enumGroupCount; j++)
                {
                    if (student[i].Group == (Group)Enum.GetValues(typeof(Group)).GetValue(j))
                    {
                        for (int k = 0; k < enumSubjectCount; k++)
                        {
                            studentsInOneGroup[k]++;
                            groupSumMark[k] += (double)student[i].Subject[k];
                        }
                    }
                }
            }*/
            for (int i = 0; i < enumGroupCount; i++)
            {
                groupAverageMark[i] = groupSumMark[i] / studentsInOneGroup[i];
            }
            for (int i = 0; i < groupAverageMark.Length; i++)
            {
                Console.WriteLine(Enum.GetValues(typeof(Group)).GetValue(i) + ": " + groupAverageMark[i]);
            }
        }
        static public void ShowStudentsWithPoorMark(Student[] student, Subject[] subject)
        {
            int[] studentsCount = new int[enumSubjectCount];

            for (int i = 0; i < student.Length; i++)
            {
                for (int j = 0; j < enumSubjectCount; j++)
                {
                    if ((int)student[i].Subject[j] < 4)
                    {
                        studentsCount[j]++;
                    }

                }
            }
            Console.WriteLine();
            for (int i = 0; i < enumSubjectCount; i++)
            {
                Console.WriteLine($"Количество студентов получивших неудовлетворительную оценку по предмету {Enum.GetValues(typeof(Subject)).GetValue(i)}: {studentsCount[i]}");

            }
            Console.WriteLine();
            for (int i = 0; i < student.Length; i++)
            {

                for (int j = 0; j < enumSubjectCount; j++)
                {
                    Console.Write($"{Enum.GetValues(typeof(Subject)).GetValue(j)}({i + 1})" + ": " + (int)student[i].Subject[j] + "\t");

                }
                Console.WriteLine();
            }
        }

    }

    enum Subject
    {
        Math,
        History,
        English,
        OOP,
    }
    enum Group
    {
        ITI_21,
        ITI_22,
        ITP_21,
        ITP_22,
    }
}

