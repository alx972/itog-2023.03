public static class ArrayCreator
{
    /// <summary>
    /// Метод создания массива
    /// </summary>
    /// <param name="len">Количество элементов создаваемого массива</param>
    /// <returns>Массив типа String</returns>
    public static string[] Create(this int len)
    {
        return new string[len];
    }
    
    /// <summary>
    /// Объединяет элементы массива в строку
    /// </summary>
    /// <param name="arr">Массив</param>
    /// <returns>Строка с представлением массива</returns>
    public static string Print(this string[] arr)
    {
        return $"[\"{String.Join("\", \"", arr)}\"]"; //объединяем массив в строку, обрамляем слова кавычками
    }

}
