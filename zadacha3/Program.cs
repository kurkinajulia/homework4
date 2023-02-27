//Напишите метод, который задаёт массив из N элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]


int Prompt(string messageTerminal)
{
Console.Write(messageTerminal);
string input = Console.ReadLine();
int result = int.Parse(input);
return result;
}
int [] CreateArray(int size, int min, int max)
{
int[] array = new int[size];
for (int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(min, max);
}
array[0] = min;
array[array.Length - 1] = max;
return array;
}
void ShowArray(int [] array)
{
for (int i = 0; i < array.Length; i++)
{
Console.Write($"{array[i]} ");
}
}

int size = Prompt("Введите размер массива: ");
if (size <= 1)
{
Console.WriteLine("Размер массива должен быть больше 1.");
return;
}
int min = Prompt("Введите минимальное значение массива: ");
int max = Prompt("Введите максимально значнеие массива: ");
int [] array = CreateArray(size, min, max);
ShowArray(array);