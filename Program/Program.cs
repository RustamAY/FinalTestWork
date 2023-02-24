// Задача:

// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется
// пользоваться коллекциями, лучше обойтись исключительно массивами.


void FillArray(string[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    Console.WriteLine("Введите значение массива: ");
    array[i] = Console.ReadLine();
  }
}

void PrintArray(string[] array)
{
  Console.Write("[");
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write($"\"{array[i]}\"");
    if (i < array.Length - 1) Console.Write(", ");
  }
  Console.Write("]");
}

