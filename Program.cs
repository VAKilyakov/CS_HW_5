/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

/* Решение 1
int InputNum(string message)
{
    
    Console.Write(message + " ");
    return Convert.ToInt32(Console.ReadLine());

}

int[] CreateArray(int Length)
{

    int [] array = new int[Length];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = InputNum("Введите " + i + " элемент массива");
    }

    return array;

}

void PrintArray(int[] array)
{
    int Result = 0;
    
    for(int i=0; i < array.Length; i++)
    {
       if (array[i] % 2 == 0)
       {
        Result ++;
       }
    }

    Console.Write(Result);
}

int Length = InputNum("Введите длину массива ");
int[] array = CreateArray(Length);
PrintArray(array);
*/

/* Тест 1
PS D:\Home_Works\CS_HW_5> dotnet run
Введите длину массива  4
Введите 0 элемент массива 345
Введите 1 элемент массива 897
Введите 2 элемент массива 568
Введите 3 элемент массива 234
2
*/