# Итоговая проверочная работа (1 блок)
## Условия задачи
Задача алгоритмически не самая сложная, однако для полноценного выполнения проверочной работы необходимо:

* Создать репозиторий на GitHub

* Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)

* Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)

* Написать программу, решающую поставленную задачу

* Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)


## Задача:

Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:

> [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]  
> [“1234”, “1567”, “-2”, “computer science”] → [“-2”]  
> [“Russia”, “Denmark”, “Kazan”] → []

## Блок схема выглядит так:

![reshenie](block_diagram.jpg)

## Решение задачи вижу следующим образом:

string[] array = { "Hello", "2", "world", "he" };  
string[] newArray = new string[array.Length];  
int j = 0;  
foreach (string item in array)  
{  
    if (item.Length <= 3)  
    {  
        newArray[j] = item;  
        j++;  
    }  
}  

Console.WriteLine("Исходный массив:");  
Console.WriteLine("[" + string.Join(", ", array) + "]");

Console.WriteLine("Новый массив:");  
Console.WriteLine("[" + string.Join(", ", newArray) + "]");