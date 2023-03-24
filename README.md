# Итоговая проверочная работа

**<ins>Задача</ins>:** Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

```mermaid
flowchart TD
n1([BEGIN]) -->
n2[/Ввод: <br>arrayOrig = &#x5B&#x22st1&#x22,...,&#x22stN&#x22&#x5D/] -->
n3[len = arrayOrig.Length<br>excludeLargerLength = 3<br>i = 0<br>j = 0] -->
nIFi{i < len}
nIFexLL{array&#x5B i &#x5D <= <br> excludeLargetLength} --Yes-->
nAdd[arrayResult&#x5B j &#x5D = arrayOrig&#x5B i &#x5D<br>j = j + 1] --> 
nPlusI[i = i + 1]
nIFexLL --No--> nPlusI --> nIFi
nIFi --Yes-->nIFexLL
nExit[/Вывод:<br>arrayOrig&#x5B&#x5D, arrayResult&#x5B&#x5D/] --> nEND
nIFi --No-->nExit
nEND([END])
```
