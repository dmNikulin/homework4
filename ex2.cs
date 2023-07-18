// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int summary = 0;                                  // Аккумулятор

int checkNumber(int N)                            // Определим разрядность числа
{
    int depth = 0;

    while (N >= 1)
    {
        N /= 10;
        depth++;
    }
    return depth;

}

int[] array = new int[checkNumber(number)];       // Задаем массив и сразу же определяем ему размер из функции checkNumber
int length = array.Length;                        // Длина массива

for (int i = 0; i < length; i++)                  // В цикле будем инициализировать каждую цифру числа в массив
{
    array[i] = number % 10;                       // Получится массив в обратном порядке, но для этой задачи пойдет
    number /= 10;
}

for (int a = 0; a < length; a++)                  // Этот цикл суммирует каждый элемент массива в аккумулятор summary
{
    summary = summary + array[a];
}

Console.WriteLine(summary);
