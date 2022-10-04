using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_06
{
    public class Student
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

        static public string ShowAverageMarkSubject(Student[] student, Subject subject, int index)
        {
            double sum = 0;
            double averageMarkSubject = 0;
            for (int i = 0; i < student.Length; i++)
            {
                sum += (int)student[i].Subject[(int)subject];
            }
            averageMarkSubject = sum / student.Length;
            return Enum.GetValues(typeof(Subject)).GetValue(index) + ": " + averageMarkSubject;

        }
        static public string ShowGroupAverageSsesionMark(Student[] student, int index)
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
            for (int i = 0; i < enumGroupCount; i++)
            {
                groupAverageMark[i] = groupSumMark[i] / studentsInOneGroup[i];
            }

            return Enum.GetValues(typeof(Group)).GetValue(index) + ": " + groupAverageMark[index];

        }
        static public string ShowStudentsWithPoorMark(Student[] student, Subject[] subject, int indexI)
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


            return $"Количество студентов получивших неудовлетворительную оценку по предмету {Enum.GetValues(typeof(Subject)).GetValue(indexI)}: {studentsCount[indexI]}";

          

            //return $"{Enum.GetValues(typeof(Subject)).GetValue(indexJ)}({indexI + 1})" + ": " + (int)student[indexI].Subject[indexJ] + "\t";

        }

    }

}

public enum Subject
{
    Math,
    History,
    English,
    OOP,
}
public enum Group
{
    ITI_21,
    ITI_22,
    ITP_21,
    ITP_22,
}


