
/// <summary>
/// Возвращает отсортированный по возрастанию поток чисел
/// </summary>
/// <param name="inputStream">Поток чисел от 0 до maxValue. Длина потока не превышает миллиарда чисел.</param>
/// <param name="sortFactor">Фактор упорядоченности потока. Неотрицательное число. Если в потоке встретилось
/// число x, то в нём больше не встретятся числа меньше, чем (x - sortFactor).</param>
/// <param name="maxValue">Максимально возможное значение чисел в потоке. Неотрицательное число, не превышающее 2000.</param>
/// <returns>Отсортированный по возрастанию поток чисел.</returns>
static IEnumerable<int> Sort(IEnumerable<int> inputStream, int sortFactor, int maxValue)
{
    List<int> nums = new List<int>();
    int currentSortFactorNum = sortFactor;

    foreach (int i in inputStream)
    {
        if (i > currentSortFactorNum)
        {

            SortNumber(nums, sortFactor, i);

            for (int j = 0; j < nums.Count; j++)
            {
                Console.Write(nums[j] + " ");
            }
            Console.WriteLine();
            
            if (i - sortFactor > currentSortFactorNum)
               currentSortFactorNum = i - sortFactor;
        }
    }

    return nums;
}

static void SortNumber(List<int> nums, int sortFactor, int number)
{
    int pos = -1;

    for (int i = 0; i < nums.Count; i++)
    {
        if (nums[i] >= number)
        {
            pos = i;
            break;
        }
    }

    if (pos == -1)
        nums.Add(number);

    else
        nums.Insert(pos, number);
}

int[] arr = new[] { 1, 2, 3, 4 };
List<int> list = new List<int>() { 5, 1, 6, 22, 1, 65, 4, 3, 2, 8, 0, 33 };

IEnumerable<int> abc = Sort(list, 2, list.Count);