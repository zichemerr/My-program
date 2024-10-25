using System;

public class Program
{
    private Calculator _calculator;
    private ProgramView _view;
    private List<int> _numbers;

    public Program(Calculator calculator, ProgramView programView)
    {
        _calculator = calculator;
        _view = programView;
        _numbers = new List<int>();
    }

    public void Work()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write($"Введите числовой массив: ");

        string input = Console.ReadLine();
        int lastNumber = 0;
        bool isNull = true;

        for (int i = 0; i < input.Length; i++)
        {
            string a = input[i].ToString();

            if (int.TryParse(a, out int number))
            {
                if (isNull == false)
                {
                    lastNumber = lastNumber * 10 + number;
                }
                else
                {
                    lastNumber = number;
                    isNull = false;
                }
            }
            else
            {
                if (isNull == false)
                {
                    _numbers.Add(lastNumber);
                    isNull = true;
                }
            }
        }

        string b = input[input.Length - 1].ToString();

        if (int.TryParse(b, out int number1))
            _numbers.Add(lastNumber);

        float middleNumber = _calculator.FoundMiddleNumber(_numbers);
        _view.ShowMiddleNumber(middleNumber);

        int[] numbers = _numbers.ToArray();
        Array.Sort(numbers);
        _view.ShowSortedArray(numbers);
        int[] median = _calculator.FoudMedian(numbers);

        if (median.Length > 1)
            _view.ShowMedian(median[0], median[1]);
        else
            _view.ShowMedian(median[0]);

        _calculator.FoundScope(numbers, out int hight, out int low);
        _view.ShowScope(hight, low);

        Console.ReadKey();
    }
}
