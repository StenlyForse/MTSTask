/// <summary>
/// <para> Отсчитать несколько элементов с конца </para>
/// <example> new[] {1,2,3,4}.EnumerateFromTail(2) = (1, ), (2, ), (3, 1), (4, 0)</example>
/// </summary> 
/// <typeparam name="T"></typeparam>
/// <param name="enumerable"></param>
/// <param name="tailLength">Сколько элеметнов отсчитать с конца  (у последнего элемента tail = 0)</param>
/// <returns></returns>
/// 

public static class MyExt
{

    public static IEnumerable<(T item, int? tail)> EnumerateFromTail<T>(this IEnumerable<T> enumerable, int? tailLength)
    {
        IEnumerable<(T item, int? tail)> enumr = Enumerable.Empty<(T item, int? tail)>();
        List<(T item, int? tail)> tailList = new List<(T item, int? tail)>();

        for (int i = enumerable.Count() - 1; i >= 0; i--)
        {
            if (i >= enumerable.Count() - tailLength)
            {
                tailList.Add(new (enumerable.ElementAt(i), (enumerable.Count() - 1) - i));
            }
            else
            {
                tailList.Add(new (enumerable.ElementAt(i), null));
            }
            
        }

        tailList.Reverse();

        return tailList;
    }
}

class Task3
{
    static void Main(string[] args)
    {

        new[] { 1, 2, 3, 4 }.EnumerateFromTail(2);
        List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7};
        var list2 = new List<int>() { 1, 2, 3, 4, 5, 6, 7 }.EnumerateFromTail(7);
        var adfasdf = list.EnumerateFromTail(5);

    }

}
