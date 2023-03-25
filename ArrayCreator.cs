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
    
}
