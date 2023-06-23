using System;

namespace SkillboxCsharp05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sampleText = "Hello, my  dear   World!";

            // Пример использования нашего метода разбиения на слова.
            string[] words = SplitText(sampleText);

            foreach (string word in words) 
            {
                Console.WriteLine(word);
            }

            // Пример использования нашего метода переворота предложения.
            string reversed = ReverseWords(sampleText);
            Console.WriteLine();
            Console.WriteLine(reversed);
        }

        /// <summary>
        /// Разбивает предложение на слова, разделяемые проблелами.
        /// </summary>
        /// <param name="inputString">Предложение.</param>
        /// <returns>Массив из слов предложения.</returns>
        static string[] SplitText(string text)
        {
            // StringSplitOptions.RemoveEmptyEntries используется
            // для удаления пустых записей.
            // Они могут появиться из-за нескольких идущих подряд пробелов.
            return text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        }

        /// <summary>
        /// Меняет порядок слов в предложении на обратный.
        /// </summary>
        /// <param name="text">Предложение.</param>
        /// <returns>Предложение с обратным порядком слов.</returns>
        static string ReverseWords(string text)
        {
            // Вызываем наш метод разбиения на слова и сохраняем слова в переменной words.
            string[] words = SplitText(text);

            // Вызываем стандартный метод для переворачивания массива.
            Array.Reverse(words);

            // Вызываем стандартный метод для склеивания строк и
            // сохраняем полученное предложение в переменной result.
            // Первый параметр - разделитель, в нашем случае пробел.
            // Второй параметр - массив строк для склейки через разделитель.
            string result = String.Join(' ', words);

            // Возвращаем полученное перевернутое предложение.
            return result;
        }
    }
}