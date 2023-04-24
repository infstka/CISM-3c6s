using System.Collections.Generic;
using System.Linq;

namespace LR5
{
    internal class SymbolFrequency
    {
        public static Dictionary<char, int> countFrequencyOfAlphabetLettersInText(string text, string alphabet)
        {
            Dictionary<char, int> lettersFrequency = new Dictionary<char, int>();

            // заполняем словарь так что в качестве ключей в нём есть все буквы, а их значения = 0
            foreach (var letter in alphabet)
            {
                lettersFrequency[letter] = 0;
            }

            foreach (var symbol in text)
            {
                // проверяем содержится ли прочитанный из строки символ в алфавите
                // если нет, то пропускаем его и переходим к следующему
                if (!alphabet.Contains(symbol))
                {
                    continue;
                }

                // увеличиваем значение символа на 1, каждый раз, когда встречаем его в сообщении
                if (lettersFrequency.ContainsKey(symbol))
                {
                    lettersFrequency[symbol]++;
                }
            }
            return lettersFrequency;
        }
    }
}
