// Задача 64: Задайте значение N. Напишите программу, которая выведет все чётные числа в промежутке от N до 1.

System.Console.Clear();


int n = InputNumbers("Введите n: ");
int start = 3;
Console.Write("2 ");
PrintNumber(n, start);


void PrintNumber(int n, int start)
{
    for (int i = start; i <= n; i++)
        {
            if (i % 2 == 0) 
            {
                Console.Write(i + " ");
            }
        }
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}