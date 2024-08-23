//Итоговая контрольная работа по основному блоку

//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

//Примеры:
//[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
//[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
//[“Russia”, “Denmark”, “Kazan”] → []


void show_array(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine('\n');
}


string[] sift_strings(string[] array, string str = "")
{
    for (int i =0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            str += array[i];
            str += " ";
        }
    }
    return str.Split();
}



Console.WriteLine("\nВедите любое количество последовательностей символов, разделяя эти последовательности пробелом.");
Console.Write("\nВвод -> ");

string[] array = Console.ReadLine().Split();

array = sift_strings(array);

Console.WriteLine("\n\nПодсчет строк длиною в 3 и менее символа..");
Console.Write("\nВывод -> ");

show_array(array);