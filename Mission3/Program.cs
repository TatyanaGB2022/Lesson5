// Задача 2: Задайте массив. Напишите программу, которая определяет, присутствует ли 
// заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

int[] GenerateArray(int len = 5)// функция генерации массива
{
  int[] array = new int[len];
  Random rnd = new Random();//рандомные элементы массива
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = rnd.Next(-9, 10);
  }
  return array;
}

bool FindElement(int[] array, int number) // функция bool проверяет истина или ложь
{
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] == number) // == это равно
      return true;  // истина
  }
  return false; // ложь
}

void PrintArray(int[] array)//пишет функцию (массив), написанный выше
{
  foreach (int item in array)//альтернатива циклу фор (работает не с индексами, а с элементами массива
  {
    System.Console.Write($"{item}\t");// выводит элемент массива
  }
  System.Console.WriteLine();//перевод курсора на след строку
}
int InputInt(string message)
{
  System.Console.WriteLine(message);
  return Convert.ToInt32(Console.ReadLine());
}
int[] array = GenerateArray();
PrintArray(array);
int num = InputInt("Введите число: ");
if (FindElement(array, num))
  System.Console.WriteLine("Присутствует в массиве");
else
  System.Console.WriteLine("Нет такого числа в массиве");