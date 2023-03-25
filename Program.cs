// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
// меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись
// исключительно массивами.

using static ArrayCreator;

int excludeLargerLength = 3; //ограничитель длины слова, длинее этого значения не копируем во второй массив

var arrayOrigin = FillArrayManually();

var arrayResult = arrayOrigin.ExcludeLongWords(excludeLargerLength);

Console.WriteLine($"{arrayOrigin.Print()} -> {arrayResult.Print()}");