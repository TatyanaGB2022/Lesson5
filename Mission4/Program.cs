//  Задайте одномерный массив из 10 случайных чисел в диапазоне от 1 до 200. Найдите количество 
// двузначных элементов массива. 
// Пример для массива из 5, а не 10 элементов. В своём решении сделайте для 10
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] GenerateArray(int len = 10)// функция генерации массива
{
  int[] array = new int[len];
  Random rnd = new Random();//рандомные элементы массива
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = rnd.Next(0, 201);
  }
  return array;
}

int Number(int[] array)//функция которая будет перемещаться по каждому числу от 9 до 100
{
  int count = 0;

  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] > 9 && array[i] < 100)
      count++;

  }
  return count;
}
void PrintArray(int[] array)//пишет функцию (массив), написанный выше
{
  foreach (int item in array)//альтернатива циклу фор (работает не с индексами, а с элементами массива
  {
    System.Console.Write($"{item}\t");// выводит элемент массива
  }
  System.Console.WriteLine();
}

int[] array = GenerateArray();
PrintArray(array);
System.Console.WriteLine($"Двухзначных чисел: {Number(array)}");