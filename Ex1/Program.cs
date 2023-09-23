// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2



  Random random = new Random();
        int arrayLength = random.Next(1, 100); // Генерируем случайную длину массива от 1 до 99
        int[] myArray = new int[arrayLength]; // Создаём массив заданной длины

        // Заполняем массив случайными трёхзначными числами
        for (int i = 0; i < myArray.Length; i++)
        {
            myArray[i] = random.Next(100, 1000); // Генерируем случайное трёхзначное число
        }

        // Выводим элементы массива на экран
        Console.WriteLine("Сгенерированный массив:");
        foreach (int number in myArray)
        {
            Console.Write(number + " ");
        }

        // Подсчитываем количество чётных чисел и выводим результат
        int evenCount = CountEvenNumbers(myArray);
        Console.WriteLine("\nКоличество чётных чисел: " + evenCount);
    

    static int CountEvenNumbers(int[] array)
{
    int count = 0;
    foreach (int number in array)
    {
        if (number % 2 == 0)
        {
            count++;
        }
    }
    return count;
}