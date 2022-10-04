using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using LAB_06;


namespace Lab_06_WFA
{
    public partial class Form1 : Form
    {
        static private int enumGroupCount = Enum.GetNames(typeof(Group)).Length;
        static private int enumSubjectCount = Enum.GetNames(typeof(Subject)).Length;
        static Subject[] subject = new Subject[Enum.GetNames(typeof(Subject)).Length];
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

        public Form1()
        {
            InitializeComponent();
        }



        private void label1_Click(object sender, EventArgs e)
        {

            // label2.Text = Student.ShowGroupAverageSsesionMark(student);
            // textBox1.Text = Student.ShowGroupAverageSsesionMark(student);
        }

        


        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            Random random = new Random();
            for (int i = 0; i < student.Length; i++)
            {
                for (int j = 0; j < Enum.GetNames(typeof(Subject)).Length; j++)
                {
                    student[i].Subject[j] = (Subject)random.Next(1, 11);

                }
                Console.WriteLine();

            }
            label2.Text = "Оценки сгенирированы";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label2.Text = "Вывод всех студентов";
            for (int i = 0; i < student.Length; i++)
            {
                textBox1.Text += (student[i].FI + " : " + student[i].Group) + Environment.NewLine;
                for (int j = 0; j < Enum.GetNames(typeof(Subject)).Length; j++)
                {
                    textBox1.Text += (Enum.GetValues(typeof(Subject)).GetValue(j) + ": ");
                    textBox1.Text += (int)student[i].Subject[j] + Environment.NewLine;

                }
                textBox1.Text += Environment.NewLine;

            }

        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label2.Text = "Вывод по каждому предмету";
            for (int i = 0; i < enumSubjectCount; i++)
            {
                textBox1.Text += Student.ShowAverageMarkSubject(student, subject[i], i) + Environment.NewLine;

            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label2.Text = "Вывод по каждой студенческой группе среднего балла на ссесии";


            for (int i = 0; i < enumGroupCount; i++)
            {
                textBox1.Text += "=========================" + Environment.NewLine;
                textBox1.Text += Student.ShowGroupAverageSsesionMark(student, i) + Environment.NewLine;
                textBox1.Text += "=========================" + Environment.NewLine;
                // label2.Text = Student.ShowGroupAverageSsesionMark(student, i);
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            for (int j = 0; j < enumSubjectCount; j++)
            {
                textBox1.Text += Student.ShowStudentsWithPoorMark(student, subject, j) + Environment.NewLine;
            textBox1.Text += "=========================" + Environment.NewLine;
            }

        }
        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            textBox1.Clear();
        }

        

        

        
    }
}
