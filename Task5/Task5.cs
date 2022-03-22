class Program
{
    static void Main(string[] args)
    {
        TransformToElephant();
        Console.WriteLine("Муха");
        //... custom application code
    }

    static void TransformToElephant()
    {
        // Для этой задачи мною было найдено несколько решений
        // Первым является отключение вывода в консоль
        //Console.SetOut(TextWriter.Null);


        // Вторым вариантом является замена первых 4х букв каждой новой строки на слон
        Console.Out.NewLine = "\rСлон\n";
    }
}