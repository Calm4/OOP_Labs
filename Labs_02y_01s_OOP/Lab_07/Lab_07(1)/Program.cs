using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_07
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Pants[] pants =
            {
                new Pants(Gender.Man, 180, Type_clothes.Cotton, Color.Black),
                new Pants(Gender.Man, 190, Type_clothes.Cotton, Color.Red),
                new Pants(Gender.Woman, 160, Type_clothes.Latex, Color.Green),
                new Pants(Gender.Woman, 170, Type_clothes.Latex, Color.Red),
            };
            Skirts[] skirts =
            {
                new Skirts(Gender.Man, 180, Type_clothes.Wool, Color.Red),
                new Skirts(Gender.Man, 190, Type_clothes.Wool, Color.Blue),
                new Skirts(Gender.Woman, 150, Type_clothes.Wool, Color.Black),
                new Skirts(Gender.Woman, 160, Type_clothes.Wool, Color.Red),
            };
            Blazer[] blazers =
            {
                new Blazer(Gender.Man, 180, Type_clothes.Leather, Color.Blue),
                new Blazer(Gender.Man, 190, Type_clothes.Leather, Color.Red),
                new Blazer(Gender.Woman, 160, Type_clothes.Leather, Color.Red),
                new Blazer(Gender.Woman, 170, Type_clothes.Leather, Color.Black),
            };
            Costume[] costumesWithPants =
            {
                new Costume(pants[0],blazers[0]), //MAN
                new Costume(pants[1],blazers[1]), //MAN
                new Costume(pants[2],blazers[3]), //WOMAN
                new Costume(pants[3],blazers[2]), //WOMAN
            };
            Costume[] costumesWithSkirts =
            {
                new Costume(skirts[0],blazers[1]), //MAN
                new Costume(skirts[1],blazers[0]), //MAN
                new Costume(skirts[3],blazers[3]), //WOMAN
                new Costume(skirts[3],blazers[2]), //WOMAN
            };

            bool isWork = true;
            while (isWork)
            {
                Console.WriteLine("=============Меню=============");
                Console.WriteLine("1)Вывести все костюмы");
                Console.WriteLine("2)Вывести только ЮБКИ");
                Console.WriteLine("3)Вывести только ПИДЖАКИ");
                Console.WriteLine("4)Вывести только БРЮКИ");
                Console.WriteLine("5)Вывод мужских/женских костюмоv.Вывод женские костюмы с брюками");
                Console.WriteLine("6)Вывести все брюки красного цвета (в том числе и в костюмах)");
                Console.WriteLine("7)Вывести количество единиц каждого вида одежды отдельно женского и мужского ассортимента");
                Console.WriteLine("8)Выход");
                int menuPunct = Convert.ToInt32(Console.ReadLine());
                switch (menuPunct)
                {
                    case 1:
                        Console.WriteLine("1)Костюм: ПИДЖАК + БРЮКИ");
                        Console.WriteLine("2)Костюм: ПИДЖАК + ЮБКА");
                        byte whichCostume = Convert.ToByte(Console.ReadLine());
                        if (whichCostume == 1)
                        {
                            for (int i = 0; i < costumesWithPants.Length; i++)
                            {
                                Console.WriteLine( Costume.ShowCostumeWithPants(costumesWithPants,i));

                            }

                        }
                        else if (whichCostume == 2)
                        {
                            for (int i = 0; i < costumesWithSkirts.Length; i++)
                            {
                                Console.WriteLine(Costume.ShowCostumeWithSkirts(costumesWithSkirts,i));

                            }
                        } 
                        else
                        {
                            Console.WriteLine("ТАКОГО ПУНКТА НЕТ!");
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine("Весь ассортимент ЮБОК");
                        for (int i = 0; i < skirts.Length; i++)
                        {

                            Console.WriteLine(Skirts.ShowSkirt(skirts, i));
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        Console.WriteLine("Весь ассортимент ПИДЖАКОВ");
                        for (int i = 0; i < blazers.Length; i++)
                        {
                            Console.WriteLine(Blazer.ShowBlazers(blazers, i));

                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        Console.WriteLine("Весь ассортимент БРЮК");
                        for (int i = 0; i < pants.Length; i++)
                        {
                            Console.WriteLine(Pants.ShowPants(pants,i));

                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        Console.WriteLine("1)Мужские косmюмы");
                        Console.WriteLine("2)Жеснкие косmюмы");
                        Console.WriteLine("3)Женские косmюмы с брюками");
                        int whichGenderCostume = Convert.ToInt32(Console.ReadLine());
                        if (whichGenderCostume == 1)
                        {
                            for (int i = 0; i < costumesWithPants.Length; i++)
                            {
                                if (costumesWithPants[i].Pants.Gender == Gender.Man)
                                    Console.WriteLine(Costume.ShowCostumeWithPants(costumesWithPants, i));


                            }
                            for (int i = 0; i < costumesWithSkirts.Length; i++)
                            {
                                if (costumesWithSkirts[i].Skirt.Gender == Gender.Man)
                                    Console.WriteLine(Costume.ShowCostumeWithSkirts(costumesWithSkirts, i));

                            }
                        }
                        else if (whichGenderCostume == 2)
                        {
                            for (int i = 0; i < costumesWithPants.Length; i++)
                            {
                                if (costumesWithPants[i].Pants.Gender == Gender.Woman)
                                    Console.WriteLine(Costume.ShowCostumeWithPants(costumesWithPants, i));


                            }
                            for (int i = 0; i < costumesWithSkirts.Length; i++)
                            {
                                if (costumesWithSkirts[i].Skirt.Gender == Gender.Woman)
                                    Console.WriteLine(Costume.ShowCostumeWithSkirts(costumesWithSkirts, i));

                            }
                        }
                        else if (whichGenderCostume == 3)
                        {
                            for (int i = 0; i < costumesWithPants.Length; i++)
                            {
                                if ((costumesWithPants[i].Pants.Gender == Gender.Woman))
                                    Console.WriteLine(Costume.ShowCostumeWithPants(costumesWithPants, i));

                            }
                        }
                        else
                        {
                            Console.WriteLine("ТАКОГО ПУНКТА НЕТ!");
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 6:
                        for (int i = 0; i < pants.Length; i++)
                        {
                            if (pants[i].Color == Color.Red)
                                Console.WriteLine(Pants.ShowPants(pants, i));

                        }
                        for (int i = 0; i < costumesWithPants.Length; i++)
                        {
                            if (costumesWithPants[i].Pants.Color == Color.Red)
                                Console.WriteLine(Costume.ShowCostumeWithPants(costumesWithPants, i));

                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 7:
                        Console.WriteLine(Costume.ShowClothesAssortment(pants, skirts, blazers, costumesWithPants, costumesWithSkirts));
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 8:
                        isWork = false;
                        break;
                    default:
                        Console.Clear();
                        continue;
                }
            }
        }
    }
    public enum Gender
    {
        Man,
        Woman
    }
    public enum Color
    {
        Red,
        Green,
        Blue,
        Black
    }
    public enum Type_clothes
    {
        Wool,
        Cotton,
        Leather,
        Latex
    }
}
