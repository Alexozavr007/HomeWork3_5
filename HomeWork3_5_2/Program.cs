using System.Text;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

Console.Write("Введіть кількість елементів для масиву: ");
var tmp = Console.ReadLine();
int n;

if (!int.TryParse(tmp, out n))
{
    Console.WriteLine("Невалідне значення");
}
else
{
    if (n <= 0)
    {
        Console.WriteLine("Некоректне значення");
        return;
    }

    int[] arr = new int[n];
    var rnd = new Random();
    for (int i = 0; i < arr.Length; i++) 
    {
        arr[i] = rnd.Next(0, 100); 
    }

    int maxValue = arr[0];
    int minValue = arr[0];
    int sum = 0;
    bool evenElenentExist = false;

    Console.Write("Непарні числа в масиві: ");
    for (int i = 0; i < arr.Length; i++)
    {
        maxValue = Math.Max(maxValue, arr[i]);
        minValue = Math.Min(minValue, arr[i]);
        sum += arr[i];

        var isEven = arr[i] % 2 != 0;
        if (isEven)
        {
            Console.Write($"{arr[i]}, ");
            evenElenentExist = true;
        }
    }

    if (evenElenentExist) {
        Console.WriteLine();
    } else {
        Console.WriteLine("- не знайдено -");
    }

    Console.WriteLine($"Сума: {sum}");
    Console.WriteLine($"Максимальне значення: {maxValue}");
    Console.WriteLine($"Мінімальне значення: {minValue}");
    Console.WriteLine($"Середнє арифметичне: {sum / arr.Length}");
}