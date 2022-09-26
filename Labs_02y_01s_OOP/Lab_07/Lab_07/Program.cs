using Lab_07;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD

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
                        Console.WriteLine("1)Костюм: ПИДЖАК + ЮБКА");
                        Console.WriteLine("2)Костюм: ПИДЖАК + БРЮКИ");
                        byte whichCostume = Convert.ToByte(Console.ReadLine());
                        if (whichCostume == 1)
                        {
                            Costume.ShowCostumeWithPants(costumesWithPants);

                        }
                        else if (whichCostume == 2)
                        {
                            Costume.ShowCostumeWithSkirts(costumesWithSkirts);
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
                            Console.WriteLine($"Юбка №{i + 1}");
                            Console.WriteLine("Часть костюма:\t" + "Юбка : " + skirts[i].GetType());
                            Console.WriteLine("Пол:\t\t" + skirts[i].Gender);
                            Console.WriteLine("Рост:\t\t" + skirts[i].Growth);
                            Console.WriteLine("Тип ткани:\t" + skirts[i].Type);
                            Console.WriteLine("Цвет вещи:\t" + skirts[i].Color);
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        Console.WriteLine("Весь ассортимент ПИДЖАКОВ");
                        for (int i = 0; i < blazers.Length; i++)
                        {
                            Console.WriteLine($"Пиджак №{i + 1}");
                            Console.WriteLine("Часть костюма:\t" + "Пиджак : " + blazers[i].GetType());
                            Console.WriteLine("Пол:\t\t" + blazers[i].Gender);
                            Console.WriteLine("Рост:\t\t" + blazers[i].Growth);
                            Console.WriteLine("Тип ткани:\t" + blazers[i].Type);
                            Console.WriteLine("Цвет вещи:\t" + blazers[i].Color);
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        Console.WriteLine("Весь ассортимент БРЮК");
                        for (int i = 0; i < blazers.Length; i++)
                        {
                            Console.WriteLine($"Брюки №{i + 1}");
                            Console.WriteLine("Часть костюма:\t" + "Брюки : " + pants[i].GetType());
                            Console.WriteLine("Пол:\t\t" + pants[i].Gender);
                            Console.WriteLine("Рост:\t\t" + pants[i].Growth);
                            Console.WriteLine("Тип ткани:\t" + pants[i].Type);
                            Console.WriteLine("Цвет вещи:\t" + pants[i].Color);
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        Console.WriteLine("1)Мужские косnюмы");
                        Console.WriteLine("2)Жеснкие костюмы");
                        Console.WriteLine("3)Женские костюмы с брюками");
                        int whichGenderCostume = Convert.ToInt32(Console.ReadLine());
                        if (whichGenderCostume == 1)
                        {
                            for (int i = 0; i < costumesWithPants.Length; i++)
                            {
                                if (costumesWithPants[i].Pants.Gender == Gender.Man)
                                {
                                    Console.WriteLine($"Costume №{i + 1}");
                                    Console.WriteLine("Часть костюма:\t" + "Брюки : " + costumesWithPants[i].Pants.GetType());
                                    Console.WriteLine("Пол:\t\t" + costumesWithPants[i].Pants.Gender);
                                    Console.WriteLine("Рост:\t\t" + costumesWithPants[i].Pants.Growth);
                                    Console.WriteLine("Тип ткани:\t" + costumesWithPants[i].Pants.Type);
                                    Console.WriteLine("Цвет вещи:\t" + costumesWithPants[i].Pants.Color);
                                    Console.WriteLine("=========================");
                                    Console.WriteLine("Часть костюма:\t" + "Пиджак : " + costumesWithPants[i].Blazer.GetType());
                                    Console.WriteLine("Пол:\t\t" + costumesWithPants[i].Blazer.Gender);
                                    Console.WriteLine("Рост:\t\t" + costumesWithPants[i].Blazer.Growth);
                                    Console.WriteLine("Тип ткани:\t" + costumesWithPants[i].Blazer.Type);
                                    Console.WriteLine("Цвет вещи:\t" + costumesWithPants[i].Blazer.Color);
                                    Console.WriteLine("=================================================");
                                }

                            }
                            for (int i = 0; i < costumesWithSkirts.Length; i++)
                            {
                                if (costumesWithSkirts[i].Skirt.Gender == Gender.Man)
                                {
                                    Console.WriteLine($"Costume №{i + costumesWithSkirts.Length + 1}");
                                    Console.WriteLine("Часть костюма:\t" + "Юбка : " + costumesWithSkirts[i].Skirt.GetType());
                                    Console.WriteLine("Пол:\t\t" + costumesWithSkirts[i].Skirt.Gender);
                                    Console.WriteLine("Рост:\t\t" + costumesWithSkirts[i].Skirt.Growth);
                                    Console.WriteLine("Тип ткани:\t" + costumesWithSkirts[i].Skirt.Type);
                                    Console.WriteLine("Цвет вещи:\t" + costumesWithSkirts[i].Skirt.Color);
                                    Console.WriteLine("=========================");
                                    Console.WriteLine("Часть костюма:\t" + "Пиджак : " + costumesWithSkirts[i].Blazer.GetType());
                                    Console.WriteLine("Пол:\t\t" + costumesWithSkirts[i].Blazer.Gender);
                                    Console.WriteLine("Рост:\t\t" + costumesWithSkirts[i].Blazer.Growth);
                                    Console.WriteLine("Тип ткани:\t" + costumesWithSkirts[i].Blazer.Type);
                                    Console.WriteLine("Цвет вещи:\t" + costumesWithSkirts[i].Blazer.Color);
                                    Console.WriteLine("=================================================");
                                }
                            }
                        }
                        else if (whichGenderCostume == 2)
                        {
                            for (int i = 0; i < costumesWithPants.Length; i++)
                            {
                                if (costumesWithPants[i].Pants.Gender == Gender.Woman)
                                {
                                    Console.WriteLine($"Costume №{i + 1}");
                                    Console.WriteLine("Часть костюма:\t" + "Брюки : " + costumesWithPants[i].Pants.GetType());
                                    Console.WriteLine("Пол:\t\t" + costumesWithPants[i].Pants.Gender);
                                    Console.WriteLine("Рост:\t\t" + costumesWithPants[i].Pants.Growth);
                                    Console.WriteLine("Тип ткани:\t" + costumesWithPants[i].Pants.Type);
                                    Console.WriteLine("Цвет вещи:\t" + costumesWithPants[i].Pants.Color);
                                    Console.WriteLine("=========================");
                                    Console.WriteLine("Часть костюма:\t" + "Пиджак : " + costumesWithPants[i].Blazer.GetType());
                                    Console.WriteLine("Пол:\t\t" + costumesWithPants[i].Blazer.Gender);
                                    Console.WriteLine("Рост:\t\t" + costumesWithPants[i].Blazer.Growth);
                                    Console.WriteLine("Тип ткани:\t" + costumesWithPants[i].Blazer.Type);
                                    Console.WriteLine("Цвет вещи:\t" + costumesWithPants[i].Blazer.Color);
                                    Console.WriteLine("=================================================");
                                }

                            }
                            for (int i = 0; i < costumesWithSkirts.Length; i++)
                            {
                                if (costumesWithSkirts[i].Skirt.Gender == Gender.Woman)
                                {
                                    Console.WriteLine($"Costume №{i + costumesWithSkirts.Length + 1}");
                                    Console.WriteLine("Часть костюма:\t" + "Юбка : " + costumesWithSkirts[i].Skirt.GetType());
                                    Console.WriteLine("Пол:\t\t" + costumesWithSkirts[i].Skirt.Gender);
                                    Console.WriteLine("Рост:\t\t" + costumesWithSkirts[i].Skirt.Growth);
                                    Console.WriteLine("Тип ткани:\t" + costumesWithSkirts[i].Skirt.Type);
                                    Console.WriteLine("Цвет вещи:\t" + costumesWithSkirts[i].Skirt.Color);
                                    Console.WriteLine("=========================");
                                    Console.WriteLine("Часть костюма:\t" + "Пиджак : " + costumesWithSkirts[i].Blazer.GetType());
                                    Console.WriteLine("Пол:\t\t" + costumesWithSkirts[i].Blazer.Gender);
                                    Console.WriteLine("Рост:\t\t" + costumesWithSkirts[i].Blazer.Growth);
                                    Console.WriteLine("Тип ткани:\t" + costumesWithSkirts[i].Blazer.Type);
                                    Console.WriteLine("Цвет вещи:\t" + costumesWithSkirts[i].Blazer.Color);
                                    Console.WriteLine("=================================================");
                                }
                            }
                        }
                        else if (whichGenderCostume == 3)
                        {
                            for (int i = 0; i < costumesWithPants.Length; i++)
                            {
                                if ((costumesWithPants[i].Pants.Gender == Gender.Woman))
                                {

                                    Console.WriteLine($"Costume №{i + 1}");
                                    Console.WriteLine("Часть костюма:\t" + "Брюки : " + costumesWithPants[i].Pants.GetType());
                                    Console.WriteLine("Пол:\t\t" + costumesWithPants[i].Pants.Gender);
                                    Console.WriteLine("Рост:\t\t" + costumesWithPants[i].Pants.Growth);
                                    Console.WriteLine("Тип ткани:\t" + costumesWithPants[i].Pants.Type);
                                    Console.WriteLine("Цвет вещи:\t" + costumesWithPants[i].Pants.Color);
                                    Console.WriteLine("=========================");
                                    Console.WriteLine("Часть костюма:\t" + "Пиджак : " + costumesWithPants[i].Blazer.GetType());
                                    Console.WriteLine("Пол:\t\t" + costumesWithPants[i].Blazer.Gender);
                                    Console.WriteLine("Рост:\t\t" + costumesWithPants[i].Blazer.Growth);
                                    Console.WriteLine("Тип ткани:\t" + costumesWithPants[i].Blazer.Type);
                                    Console.WriteLine("Цвет вещи:\t" + costumesWithPants[i].Blazer.Color);
                                    Console.WriteLine("=================================================");
                                }
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
                            {
                                Console.WriteLine($"Брюки №{i + 1}");
                                Console.WriteLine("Часть костюма:\t" + "Брюки : " + pants[i].GetType());
                                Console.WriteLine("Пол:\t\t" + pants[i].Gender);
                                Console.WriteLine("Рост:\t\t" + pants[i].Growth);
                                Console.WriteLine("Тип ткани:\t" + pants[i].Type);
                                Console.WriteLine("Цвет вещи:\t" + pants[i].Color);
                            }
                        }
                        for (int i = 0; i < costumesWithPants.Length; i++)
                        {
                            if (costumesWithPants[i].Pants.Color == Color.Red)
                            {
                                Console.WriteLine($"Costume №{i + 1}");
                                Console.WriteLine("Часть костюма:\t" + "Брюки : " + costumesWithPants[i].Pants.GetType());
                                Console.WriteLine("Пол:\t\t" + costumesWithPants[i].Pants.Gender);
                                Console.WriteLine("Рост:\t\t" + costumesWithPants[i].Pants.Growth);
                                Console.WriteLine("Тип ткани:\t" + costumesWithPants[i].Pants.Type);
                                Console.WriteLine("Цвет вещи:\t" + costumesWithPants[i].Pants.Color);
                                Console.WriteLine("=========================");
                                Console.WriteLine("Часть костюма:\t" + "Пиджак : " + costumesWithPants[i].Blazer.GetType());
                                Console.WriteLine("Пол:\t\t" + costumesWithPants[i].Blazer.Gender);
                                Console.WriteLine("Рост:\t\t" + costumesWithPants[i].Blazer.Growth);
                                Console.WriteLine("Тип ткани:\t" + costumesWithPants[i].Blazer.Type);
                                Console.WriteLine("Цвет вещи:\t" + costumesWithPants[i].Blazer.Color);
                                Console.WriteLine("=================================================");
                            }
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 7:
                        int pantsCountMan = 0;
                        int skirtsCountMan = 0;
                        int blazersCountMan = 0;

                        int pantsCountWoMan = 0;
                        int skirtsCountWoMan = 0;
                        int blazersCountWoMan = 0;
                        for (int i = 0; i < pants.Length; i++)
                        {
                            if (pants[i].Gender == Gender.Man)
                            {
                                pantsCountMan++;
                            }
                            if (pants[i].Gender == Gender.Woman)
                            {
                                pantsCountWoMan++;
                            }
                        }
                        for (int i = 0; i < skirts.Length; i++)
                        {
                            if (skirts[i].Gender == Gender.Man)
                            {
                                skirtsCountMan++;
                            }
                            if (pants[i].Gender == Gender.Woman)
                            {
                                skirtsCountWoMan++;
                            }
                        }
                        for (int i = 0; i < blazers.Length; i++)
                        {
                            if (blazers[i].Gender == Gender.Man)
                            {
                                blazersCountMan++;
                            }
                            if (blazers[i].Gender == Gender.Woman)
                            {
                                blazersCountWoMan++;
                            }
                        }
                        for (int i = 0; i < costumesWithPants.Length; i++)
                        {
                            if (costumesWithPants[i].Pants.Gender == Gender.Man)
                            {
                                pantsCountMan++;
                                blazersCountMan++;
                            }
                            if (costumesWithPants[i].Pants.Gender == Gender.Woman)
                            {
                                pantsCountWoMan++;
                                blazersCountWoMan++;
                            }
                        }
                        for (int i = 0; i < costumesWithSkirts.Length; i++)
                        {
                            if (costumesWithSkirts[i].Skirt.Gender == Gender.Man)
                            {
                                skirtsCountMan++;
                                blazersCountMan++;
                            }
                            if (costumesWithSkirts[i].Skirt.Gender == Gender.Woman)
                            {
                                skirtsCountWoMan++;
                                blazersCountWoMan++;
                            }
                        }
                        Console.WriteLine($"Кол-во мужских ЮБОК: {skirtsCountMan}");
                        Console.WriteLine($"Кол-во женских ЮБОК: {skirtsCountWoMan}");
                        Console.WriteLine($"Кол-во мужских БРЮК: {skirtsCountMan}");
                        Console.WriteLine($"Кол-во женских БРЮК: {skirtsCountWoMan}");
                        Console.WriteLine($"Кол-во мужских ПИДЖАКОВ: {blazersCountMan}");
                        Console.WriteLine($"Кол-во женских ПИДЖАКОВ: {blazersCountWoMan}");
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



=======
           
            
>>>>>>> b6417ed17402e148b0db5026411e9b33823085c5
        }
    }




    enum Gender
    {
        Man,
        Woman
        // Boolean - true/false true-man ; false-woman =)
    }
    enum Color
    {
        Red,
        Green,
        Blue,
        Black
    }
    enum Type_clothes
    {
        Wool,
        Cotton,
        Leather,
        Latex
    }
}
