// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

int ConvertStringToNumbers(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int[] InputNumbers(int lenght)
{
    int[] numbers = new int[lenght];
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = ConvertStringToNumbers($"Введите {i+1}-й элемент: ");
    }
    return numbers;
}

void PrintNumbers(int[] numbers)
{
   for(int i = 0; i < numbers.Length; i++)
    {
        Console.WriteLine($"a[{i}] = {numbers[i]}");
    } 
}

int CountPositiveNumbers(int[] numbers)
{  
    int count = 0;
    for(int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 0)
            {
                count = count++;
            }
    }
    return count;
}

int lenght = ConvertStringToNumbers ("Введите количество элементов: ");
int[] numbers;
numbers = InputNumbers(lenght);
PrintNumbers(numbers);
Console.WriteLine($"Количество чисел больше 0 равно {CountPositiveNumbers(numbers)}");

