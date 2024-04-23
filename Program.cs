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