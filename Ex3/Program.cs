// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


        Random random = new Random();
        int arrayLength = random.Next(1, 100); // Генерируем случайную длину массива от 1 до 99
        double[] myArray = new double[arrayLength]; // Создаём массив вещественных чисел заданной длины

        for (int i = 0; i < myArray.Length; i++)
        {
            double randomValue = random.NextDouble() * 100.0; // Генерируем случайное вещественное число в диапазоне от 0.0 до 100.0
            double roundedValue = Math.Round(randomValue, 2); // Округляем до двух знаков после запятой (сотых)
            myArray[i] = roundedValue;
        }

        // Выводим элементы массива на экран
        Console.WriteLine("Сгенерированный массив:");
        foreach (double number in myArray)
        {
            Console.Write(number + " ");
        }

        // Находим максимальный и минимальный элементы
        double max = myArray[0];
        double min = myArray[0];

        for (int i = 0; i < myArray.Length; i++)
        {
            {
                if (myArray[i] > max)
                {
                    max = myArray[i];
                }
                if (myArray[i] < min)
                {
                    min = myArray[i];
                }
            }
        }

        Console.WriteLine("\nМаксимальный элемент: " + max);
        Console.WriteLine("Минимальный элемент: " + min);
        // Определяем разницу элементов
System.Console.WriteLine("Разница элементов: " + (max - min));
