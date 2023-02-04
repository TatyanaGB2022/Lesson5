// Задача 1: Напишите программу замены элементов массива: положительные элементы замените 
// на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

int[] GenerateArray(int len)// функция генерации массива
{
  int[] array = new int[len];
  Random rnd = new Random();//рандомные элементы массива
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = rnd.Next(-9, 10);
  }
  return array;
}
void PrintArray(int[] array)//пишет функцию (массив), написанный выше
{
  foreach (int item in array)//альтернатива циклу фор (работает не с индексами, а с элементами массива
  {
    System.Console.Write($"{item}\t");// выводит элемент массива
  }
  System.Console.WriteLine();//перевод курсора на след строку
}

int[] Inversion(int[] array) //array - элемент массива
{
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = array[i] * -1;
  }
  return array;
}

int[] array = GenerateArray(12);
PrintArray(array);
PrintArray(Inversion(array));