namespace Test7_Sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Прочитаме входа като ред от числа, разделени със спейсове
            // Split() разделя входа, Select(int.Parse) преобразува в списък от цели числа
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            // Променливи за проследяване на най-дългата поредица
            int bestStart = 0; // Индекс на началото на най-дългата поредица
            int bestLength = 1; // Дължина на най-дългата поредица
            int currentLength = 1; // Дължина на текущата поредица

            // Основен цикъл за намиране на най-дългата поредица
            for (int i = 1; i < nums.Count; i++) // Започваме от 1, защото сравняваме с предишния елемент
            {
                if (nums[i] == nums[i - 1]) // Проверяваме дали текущият елемент е равен на предишния
                {
                    currentLength++; // Увеличаваме дължината на текущата поредица
                    if (currentLength > bestLength) // Ако намерим по-дълга поредица
                    {
                        bestLength = currentLength; // Обновяваме дължината на най-дългата поредица
                        bestStart = i - bestLength + 1; // Изчисляваме началния индекс на най-дългата поредица
                    }
                }
                else
                {
                    currentLength = 1; // Рестартираме дължината на текущата поредица
                }
            }

            // Цикъл за извеждане на най-дългата поредица
            for (int i = bestStart; i < bestStart + bestLength; i++)
            {
                Console.Write($"{nums[i]} "); // Извеждаме елементите на най-дългата поредица
            }
        }
    }
}