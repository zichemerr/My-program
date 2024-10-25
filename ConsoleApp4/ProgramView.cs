public class ProgramView
{
    public void ShowMiddleNumber(float number)
    {
        Console.WriteLine($"\nСреднее арифметическое: {number}");
    }

    public void ShowMedian(int number)
    {
        Console.WriteLine($"\nМедиана: {number}");
    }

    public void ShowMedian(int firstNumber, int secondNumber)
    {
        Console.WriteLine($"\nМедиана: {secondNumber} и {firstNumber}");
    }

    public void ShowSortedArray(int[] numbersArray)
    {
        Console.Write($"Отсортированный массив: ");

        foreach (var number in numbersArray)
            Console.Write(number + " ");
    }

    public void ShowScope(int hightNumber, int lowNumber)
    {
        Console.WriteLine($"Размах: {lowNumber} и {hightNumber}");
    }
}