public static class ArrayCreator
{
    /// <summary>
    /// Метод: создание массива
    /// </summary>
    /// <param name="len">Число элементов создаваемого массива</param>
    /// <returns>Инициализированный массив строк</returns>
    public static string[] Create(this int len)
    {
        return new string[len];
    }
    
    /// <summary>
    /// Метод: объединение элементов массива в строку
    /// </summary>
    /// <param name="arr">Массив</param>
    /// <returns>Строка с представлением массива</returns>
    public static string Print(this string[] arr)
    {
        return $"[\"{String.Join("\", \"", arr)}\"]"; //объединяем массив в строку, обрамляем слова кавычками
    }

        /// <summary>
        /// Заполняет массив строками, введенными с консоли
        /// </summary>
        /// <returns>Массив строк</returns>
    public static string[] FillArrayManually()
    {
        string[] arr = 0.Create(); // создаем массив нулевой длины
        Console.WriteLine("Введите слова в массив через Enter. Пустое значение завершает ввод.");
        string str = string.Empty;
        do
        {
            str = Console.ReadLine()!; // "!" Прощаем NULL во избежание предупреждения CS8600
            Array.Resize(ref arr, arr.Length + 1); // увеличиваем размер массива
            arr[arr.Length - 1] = str; // добавляем элемент к массиву
        } 
        while (str.Length > 0); // цикл пока не введем пустую строку
        Array.Resize(ref arr, arr.Length - 1); // удаляем пустую строку
        return arr;
    }

    /// <summary>
    /// Метод: исключает из массива строки длиннее len
    /// </summary>
    /// <param name="arr">Обрабатываемый массив строк</param>
    /// <param name="len">Максимально разрешенная длина строки</param>
    /// <returns>Массив строк не длиннее len</returns>
    public static string[] ExcludeLongWords(this string[] arr, int len)
    {
        string[] result = 0.Create();
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].Length <= len)
            {
                Array.Resize(ref result, result.Length + 1); // увеличиваем размер массива
                result[result.Length - 1] = arr[i]; // добавляем значение элемента массива
            }
        }
        return result;
    }
}
