using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Lab_07;
using Color = Lab_07.Color;

namespace Lab_07_WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static Pants[] pants =
            {
                new Pants(Gender.Man, 180, Type_clothes.Cotton, Color.Black),
                new Pants(Gender.Man, 190, Type_clothes.Cotton, Color.Red),
                new Pants(Gender.Woman, 160, Type_clothes.Latex, Color.Green),
                new Pants(Gender.Woman, 170, Type_clothes.Latex, Color.Red),
            };
        static Skirts[] skirts =
        {
                new Skirts(Gender.Man, 180, Type_clothes.Wool, Color.Red),
                new Skirts(Gender.Man, 190, Type_clothes.Wool, Color.Blue),
                new Skirts(Gender.Woman, 150, Type_clothes.Wool, Color.Black),
                new Skirts(Gender.Woman, 160, Type_clothes.Wool, Color.Red),
            };
        static Blazer[] blazers =
        {
                new Blazer(Gender.Man, 180, Type_clothes.Leather, Color.Blue),
                new Blazer(Gender.Man, 190, Type_clothes.Leather, Color.Red),
                new Blazer(Gender.Woman, 160, Type_clothes.Leather, Color.Red),
                new Blazer(Gender.Woman, 170, Type_clothes.Leather, Color.Black),
            };
        static Costume[] costumesWithPants =
        {
                new Costume(pants[0],blazers[0]), //MAN
                new Costume(pants[1],blazers[1]), //MAN
                new Costume(pants[2],blazers[3]), //WOMAN
                new Costume(pants[3],blazers[2]), //WOMAN
            };
        static Costume[] costumesWithSkirts =
        {
                new Costume(skirts[0],blazers[1]), //MAN
                new Costume(skirts[1],blazers[0]), //MAN
                new Costume(skirts[3],blazers[3]), //WOMAN
                new Costume(skirts[3],blazers[2]), //WOMAN
            };
        public MainWindow()
        {
            InitializeComponent();
        }


        //ПОЛОСА ПРОКРУТА 
        // РАЗМЕР КНОПКИ И ТЕКСТ В 2 СТРОКИ 
        // МЕТОДЫ ПЕРЕОБРЕДЕЛИТЬ ДЛЯ РАБОТЫ

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = "";
            for (int i = 0; i < costumesWithSkirts.Length; i++)
            {
                textBox1.Text += Costume.ShowCostumeWithSkirts(costumesWithSkirts, i) + Environment.NewLine;
            }

        }
        private void button1_2_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = "";
            for (int i = 0; i < costumesWithPants.Length; i++)
            {
                textBox1.Text += Costume.ShowCostumeWithPants(costumesWithPants, i) + Environment.NewLine;
            }
        }
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = "";
            for (int i = 0; i < skirts.Length; i++)
            {
                textBox1.Text += Skirts.ShowSkirt(skirts, i);
            }

        }
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = "";
            for (int i = 0; i < pants.Length; i++)
            {
                textBox1.Text += Pants.ShowPants(pants, i);
            }
        }

        private void button4_Click_1(object sender, RoutedEventArgs e)
        {
            textBox1.Text = "";
            for (int i = 0; i < blazers.Length; i++)
            {
                textBox1.Text += Blazer.ShowBlazers(blazers, i);
            }
        }


        private void button5_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = "";
            textBox1.Text += "1)Мужские косmюмы\n";

            for (int i = 0; i < costumesWithPants.Length; i++)
            {
                if (costumesWithPants[i].Pants.Gender == Gender.Man)
                    textBox1.Text += Costume.ShowCostumeWithPants(costumesWithPants, i);


            }
            for (int i = 0; i < costumesWithSkirts.Length; i++)
            {
                if (costumesWithSkirts[i].Skirt.Gender == Gender.Man)
                    textBox1.Text += Costume.ShowCostumeWithSkirts(costumesWithSkirts, i);

            }

        }
        private void button5_2_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = "";
            textBox1.Text += "2)Женские косmюмы\n";
            for (int i = 0; i < costumesWithPants.Length; i++)
            {
                if (costumesWithPants[i].Pants.Gender == Gender.Woman)
                    textBox1.Text += Costume.ShowCostumeWithPants(costumesWithPants, i);


            }
            for (int i = 0; i < costumesWithSkirts.Length; i++)
            {
                if (costumesWithSkirts[i].Skirt.Gender == Gender.Woman)
                    textBox1.Text += Costume.ShowCostumeWithSkirts(costumesWithSkirts, i);

            }
        }
        private void button5_3_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = "";
            textBox1.Text += "3)Женские косmюмы с брюками\n";
            for (int i = 0; i < costumesWithPants.Length; i++)
            {
                if ((costumesWithPants[i].Pants.Gender == Gender.Woman))
                    textBox1.Text += Costume.ShowCostumeWithPants(costumesWithPants, i);

            }
        }
        private void button6_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = "";
            for (int i = 0; i < pants.Length; i++)
            {
                if (pants[i].Color == Color.Red) 
                textBox1.Text +=  Pants.ShowPants(pants,i);

            }
            for (int i = 0; i < costumesWithPants.Length; i++)
            {
                if (costumesWithPants[i].Pants.Color == Color.Red) 
                textBox1.Text += Costume.ShowCostumeWithPants(costumesWithPants,i);

            }
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = "";
            textBox1.Text += Costume.ShowClothesAssortment(pants, skirts, blazers, costumesWithPants, costumesWithSkirts);
        }
        private void button8_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }


    }
}
