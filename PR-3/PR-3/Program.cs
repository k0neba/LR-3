using System;

class Program
{
    static void Main()
    {
        // Запитуємо користувача на введення розміру масиву
        Console.Write("Введіть розмір масиву (М): ");
        int M = int.Parse(Console.ReadLine());

        // Ініціалізуємо масив
        int[] array = new int[M];

        // Заповнюємо масив елементами, введеними користувачем
        Console.WriteLine("Введіть елементи масиву:");
        for (int i = 0; i < M; i++)
        {
            Console.Write($"Елемент {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        // Знаходимо перший негативний елемент
        int? firstNegative = null;
        for (int i = 0; i < M; i++)
        {
            if (array[i] < 0)
            {
                firstNegative = array[i];
                break;
            }
        }

        // Знаходимо останній позитивний елемент
        int? lastPositive = null;
        for (int i = M - 1; i >= 0; i--)
        {
            if (array[i] > 0)
            {
                lastPositive = array[i];
                break;
            }
        }

        // Перевіряємо чи обидва елементи знайдені
        if (firstNegative.HasValue && lastPositive.HasValue)
        {
            // Обчислюємо середнє арифметичне
            double average = (firstNegative.Value + lastPositive.Value) / 2.0;
            Console.WriteLine($"Середнє арифметичне першого негативного ({firstNegative.Value}) та останнього позитивного ({lastPositive.Value}) елементів: {average}");
        }
        else
        {
            Console.WriteLine("Не вдалося знайти перший негативний або останній позитивний елемент.");
        }
    }
}
