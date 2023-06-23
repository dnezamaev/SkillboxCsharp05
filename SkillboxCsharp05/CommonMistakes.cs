using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillboxCsharp05
{
    /// <summary>
    /// Ошибка. Использование локальных методов вместо обычных.
    /// </summary>
    internal class LocalFunctions
    {
        static void MyMain()
        {
            // Это локальный метод, его нельзя использовать за пределами метода,
            // в котором он объявлен.
            static void SplitText(string text)
            {
            }
        }

        static void OtherMethod()
        {
            // Здесь SplitText уже не виден.
            // SplitText();
        }

        /// <summary>
        /// Метод должен быть объявлен на этом уровне.
        /// </summary>
        static void SplitTextCorrectLocation()
        {

        }
    }
}
