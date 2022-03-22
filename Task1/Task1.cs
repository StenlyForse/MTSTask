try
{
	FailProcess();
}
catch { }

Console.WriteLine("Failed to fail process!");

static void FailProcess()
{
	//Любая из этих строк досрочно завершит программу

	//Environment.Exit(0); // здесь выходим из приложения
	//FailProcess(); // тут зацикливаемся в рекурсии и выдает ошибку
	//System.Environment.FailFast("Error happened"); // здесь прекращаем процесс
}
