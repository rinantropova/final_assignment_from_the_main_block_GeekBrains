// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


string[] FilterArrayWithThreeChars(string[] arr)
{
    int count = 0;
    foreach (string element in arr)
    {
        if(element.Length <= 3)
        {
            count++;
        }
    }
    
    string[] resultArr = new string[count];
    int index = 0;
    foreach (string element in arr)
    {
        if(element.Length <= 3)
        {
            resultArr[index] = element;
            index++;
        }
    }
    return resultArr;
}


string[] array = { "cat", "apple", "frog", "Hello", "2", "world", ":-)", "1234", "-2", "computer science", "Kazan", "Oulu", "my", "rin"};
string[] newArray = FilterArrayWithThreeChars(array);
Console.Write(string.Join(", ", newArray));