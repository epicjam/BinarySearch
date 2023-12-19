using System.Reflection;

Console.WriteLine("Hello, Teacher!");
Console.WriteLine();
Console.WriteLine();

//TASK 1: Бинарный поиск с помощью итератора. Ищем число 5. Верните true, если искомое значение найдено, false - если нет.
Console.WriteLine("TASK 1: Бинарный поиск с помощью итератора. Ищем число 5. Верните True - число найдено, False - нет.");
Console.WriteLine();

int[] nums = { 1, 3, 5, 6 };
int target = 5;
int first = 0;
int last = nums.Length - 1;

while (first <= last) 
{
    var middle = (first + last) / 2;
    if (target == nums[middle]) 
    {
        Console.WriteLine("True");
        Console.WriteLine($"Искомое число: {nums[middle]} по индексу: {middle}");
        return 1;
    }
    else if (target < nums[middle])
    {
        last = middle - 1;
    }
    else
    {
        first = middle + 1;
    }
}
Console.WriteLine("False");
return 0;
