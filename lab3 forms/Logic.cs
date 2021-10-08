using System;
using System.Collections.Generic;
using System.Text;

namespace lab3_forms
{
    public class Logic
    {
        public static string Compare(string word1, string word2)
        {
            int a = 0;
            string result = "";
            //удаление повторяющихся букв
            for (int i = 0; i < word1.Length - 1; i++)
            {
                for (int j = i + 1; j < word1.Length; j++)
                {
                    if (word1[i] == word1[j])
                    {
                        word1 = word1.Remove(j, 1);
                    }
                }
            }
            //поиск одинаковых букв в word1 и word2
            for (int i = 0; i < word1.Length; i++)
            {
                for (int j = 0; j < word2.Length; j++)
                {
                    if (word1[i] == word2[j])
                    {
                        a++;
                    }
                }
                if (a >= 1)
                {
                    result += "Да ";
                }
                else
                {
                    result += "Нет ";
                }
                a = 0;
            }
            return result;
        }
    }
}
