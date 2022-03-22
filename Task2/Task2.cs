using System;
using System.Globalization;

// Ответ на вопрос: на экран выводится конкатенцация строк. В класс добавлен метод Add

class Program
{
	static readonly IFormatProvider _ifp = CultureInfo.InvariantCulture;

	class Number
	{
		readonly int _number1;
		readonly int _number2;

		public Number(int number1, int number2)
		{
			_number1 = number1;
			_number2 = number2;
		}

		public string AddNumbers()
        {
			return (_number1 + _number2).ToString(_ifp);
        }
	}

	static void Main(string[] args)
	{
		int someValue1 = 10;
		int someValue2 = 5;

		Number number = new Number(someValue1, someValue2);
		string result = number.AddNumbers();
		Console.WriteLine(result);
		//Console.ReadKey();
	}
}
