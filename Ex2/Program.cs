// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
  
  



        Random random = new Random();
        int arrayLength = random.Next(1, 100); // Генерируем случайную длину массива от 1 до 99
        int[] myArray = new int[arrayLength]; // Создаём массив заданной длины


        // Заполняем массив случайными трёхзначными числами
        for (int i = 0; i < myArray.Length; i++)
        {
            myArray[i] = random.Next(1, 100); // Генерируем случайное двухзначное число
        }

        // Выводим элементы массива на экран
        Console.WriteLine("Сгенерированный массив:");
        foreach (int number in myArray)
        {
            Console.Write(number + " ");
        }

        System.Console.WriteLine();
        int sum = 0;
        for (int i = 1; i < myArray.Length; i += 2)
        {
            sum += myArray[i];
        }

        Console.WriteLine("Сумма элементов на нечётных позициях: " + sum);