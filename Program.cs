// Ввод массива строк с клавиатуры
        Console.WriteLine("Введите элементы массива через запятую:");
        string input = Console.ReadLine()!;
        string[] inputArray = input.Split(',')!;

        // Формирование нового массива из строк длиной <= 3 символов
        string[] newArray = new string[inputArray.Length];
        int count = 0;
        foreach (string str in inputArray)
        {
            if (str.Length <= 3)
            {
                newArray[count] = str;
                count++;
            }
        }

        // Вывод нового массива на экран
        Console.WriteLine("Новый массив из строк длиной <= 3 символов:");
        for (int i = 0; i < count; i++)
        {
            Console.Write(newArray[i] + " ");
        }