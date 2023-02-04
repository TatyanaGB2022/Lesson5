// Задача 1: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29,
// сумма отрицательных равна -20.

// int[] GenerateArray(int len)
// {
//   int[] array = new int[len];
//   Random rnd = new Random();
//   for (int i = 0; i < array.Length; i++)
//   {
//     array[i] = rnd.Next(-9, 10);
//   }
//   return array;
// }
// void PrintArray(int[] array)
// {
//   foreach (int item in array)
//   {
//     System.Console.Write($"{item}\t");
//   }
//   System.Console.WriteLine(); //делаем перенос строки. Без этого всё будет в одну строку не красиво
// }

// int[] array = GenerateArray(12);
// PrintArray(array);
// int sum = 0;
// for (int i = 0; i < array.Length; i++)
// {
//   if (array[i] > 0)
//   {
//     sum += array[i]; // sum = sum + array[i]
//   }
// }
// System.Console.WriteLine($"Сумма положительных элеменов {sum}");



int[] GenerateArray(int len)
{
  int[] array = new int[len];
  Random rnd = new Random();
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = rnd.Next(-9, 10);
  }
  return array;
}
void PrintArray(int[] array)
{
  foreach (int item in array)
  {
    System.Console.Write($"{item}\t");
  }
  System.Console.WriteLine(); //делаем перенос строки. Без этого всё будет в одну строку не красиво
}

// считаем сумму положительных
int SumSign(int[] array, bool positive = true) //позитив по умолчанию тру
{
  int sign = -1; // для отрицательных
  if (positive) // но если этот флажок будет положительным, то
  {
    sign = 1; //присвоим знак 1 // то есть если считаем для положительных, то  -1 в стр. 26 так и останется 
  }

  int sum = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if ((array[i] * sign) > 0)//еслт у нас отрацательное число array[i], то мы умножаем на -1 и оно становится 
    {    //  положительным, а значит > 0. А если у нас array[i] положительное и мы умножаем на -1, то 
         // становится отрицательным, а значит < 0 
      sum += array[i]; // sum = sum + array[i]
    }
  }

  return sum; //возвращаем эту сумму 
}

int[] array = GenerateArray(12);
PrintArray(array);

System.Console.WriteLine($"Сумма положительных элеменов {SumSign(array)}"); //если считаем положительные
System.Console.WriteLine($"Сумма отрицательных элеменов {SumSign(array, false)}"); // считаем отрицательные 