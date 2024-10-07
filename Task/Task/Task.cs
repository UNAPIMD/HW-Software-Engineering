using System.Collections.Generic;
using System.Text;
using System;

namespace Task
{
    public static class Task
    {
        /// <summary>
        /// Преобразует целое число в римскую запись
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static string IntToRoman(int value)
        {
            /*
             * Решение основано на введение словаря, хранящего пары вида (число, римская запись), благодаря которым можно перевести любое целое положительное число в римскую запись.
             * Пары должны храниться в обратном порядке: от большего числа к меньшему.
             * Искомый словарь имеет следующий состав:
             * [1000] = "M",
             * [900] = "CM",
             * [500] = "D",
             * [400] = "CD",
             * [100] = "C",
             * [90] = "XC",
             * [50] = "L",
             * [40] = "XL",
             * [10] = "X",
             * [9] = "IX",
             * [5] = "V",
             * [4] = "IV",
             * [1] = "I"
             * Такие пары, как [900] = "CM", [400] = "CD" и так далее, были добавлены, потому что римская запись не может содержать более трёх одинаковых знаков подряд.
             */

            if (value <= 0) throw new ArgumentOutOfRangeException("value <= 0");

            Dictionary<int, string> Alphabet = new Dictionary<int, string>()
            {
                [1000] = "M",
                [900] = "CM",
                [500] = "D",
                [400] = "CD",
                [100] = "C",
                [90] = "XC",
                [50] = "L",
                [40] = "XL",
                [10] = "X",
                [9] = "IX",
                [5] = "V",
                [4] = "IV",
                [1] = "I"
            };
            StringBuilder line = new StringBuilder();
            foreach (var x in Alphabet.Keys)
                while (value >= x)
                {
                    value -= x;
                    line.Append(Alphabet[x]);
                }
            return line.ToString();
        }
    }
}
