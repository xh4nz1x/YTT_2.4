/* УП Практическая работа 2.4
Задание. Преобразование римского числа в целое. Римские цифры представлены семью различными
символами: I, V, X, L, C, D и M. */

namespace YTT_4
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите римское число: ");
            string RomanNumeral = Console.ReadLine().ToUpper(); // Преобразуем введенное число в верхний регистр для удобства обработки
            int index = 0, number = 0;

            while (index < RomanNumeral.Length)
            {
                if (RomanNumeral[index] == 'I')
                {
                    if (index + 1 < RomanNumeral.Length && RomanNumeral[index + 1] == 'V')
                    {
                        number += 4;
                        index += 2;
                    }
                    else if (index + 1 < RomanNumeral.Length && RomanNumeral[index + 1] == 'X')
                    {
                        number += 9;
                        index += 2;
                    }
                    else
                    {
                        number += 1;
                        index += 1;
                    }
                }
                else if (RomanNumeral[index] == 'V')
                {
                    number += 5;
                    index += 1;
                }
                else if (RomanNumeral[index] == 'X')
                {
                    if (index + 1 < RomanNumeral.Length && RomanNumeral[index + 1] == 'L')
                    {
                        number += 40;
                        index += 2;
                    }
                    else if (index + 1 < RomanNumeral.Length && RomanNumeral[index + 1] == 'C')
                    {
                        number += 90;
                        index += 2;
                    }
                    else
                    {
                        number += 10;
                        index += 1;
                    }
                }
                else if (RomanNumeral[index] == 'L')
                {
                    number += 50;
                    index += 1;
                }
                else if (RomanNumeral[index] == 'C')
                {
                    if (index + 1 < RomanNumeral.Length && RomanNumeral[index + 1] == 'D')
                    {
                        number += 400;
                        index += 2;
                    }
                    else if (index + 1 < RomanNumeral.Length && RomanNumeral[index + 1] == 'M')
                    {
                        number += 900;
                        index += 2;
                    }
                    else
                    {
                        number += 100;
                        index += 1;
                    }
                }
                else if (RomanNumeral[index] == 'D')
                {
                    number += 500;
                    index += 1;
                }
                else if (RomanNumeral[index] == 'M')
                {
                    number += 1000;
                    index += 1;
                }
            }
            
            Console.WriteLine($"Арабское число: {number}");
        }
    }
}