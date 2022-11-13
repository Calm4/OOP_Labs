using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab_09;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        static Vector vector1 = new Vector() { VectorX = 1,VectorY = 3, VectorZ = 5};
        static Vector vector2 = new Vector() { VectorX = 2,VectorY = 4, VectorZ = 6 };

        Vector vectorAddition = vector1 + vector2;
        Vector vectorSubtraction = vector1 - vector2;
        Vector vectorVectorMultiplication = vector1 * vector2;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = $"Результат суммы двух трёхмерных векторов: {{{vectorAddition.VectorX}:{vectorAddition.VectorY}:{vectorAddition.VectorZ}}}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = $"Результат разности двух трёхмерных векторов: {{{vectorSubtraction.VectorX}:{vectorSubtraction.VectorY}:{vectorSubtraction.VectorZ}}}";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = $"Результат векторного произведения двух трёхмерных векторов: {{{vectorVectorMultiplication.VectorX}:{vectorVectorMultiplication.VectorY}:{vectorVectorMultiplication.VectorZ}}}";
        }

        

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
