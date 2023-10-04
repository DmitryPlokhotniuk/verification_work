/* Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
 лучше обойтись исключительно массивами. */

 string[] array = {"one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten"};

 string[] changedArray (string[] array)
 {
    int size = 0;
    int requiredLength = 3;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= requiredLength)
        {
            size++;
        }
    }
    
    string[] newArray = new string[size];
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= requiredLength)
        {
            newArray[index] = array[i];
            index++;
        }
    }
    return newArray;
 }

 Console.WriteLine($"Исходный массив: [{string.Join(", ", array)}]");
 Console.WriteLine($"Новый массив: [{string.Join(", ", changedArray(array))}]");