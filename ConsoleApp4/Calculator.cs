public class Calculator
{
    public int SumList(List<int> numbers)
    {
        int sum = 0;

        foreach (var number in numbers)
            sum += number;

        return sum;
    }

    public float Share(float firstNumber, float secondNumber)
    {
        return firstNumber / secondNumber;
    }

    public float FoundMiddleNumber(List<int> numbers)
    {
        int sumNumbers = SumList(numbers);
        float middleNumber = Share(sumNumbers, numbers.Count);

        return middleNumber;
    }

    public int[] FoudMedian(int[] numbersArray)
    {
        if (numbersArray == null)
            throw new ArgumentNullException();

        int middleIndex = numbersArray.Length / 2;
        int median;
        int median2 = 0;

        if (numbersArray.Length % 2 == 0)
        {
            median = numbersArray[middleIndex];
            median2 = numbersArray[middleIndex - 1];
        }
        else
        {
            median = numbersArray[middleIndex];
        }

        if (median2 != 0)
        {
            return [median, median2];
        }

        return [median];
    }

    public void FoundScope(int[] numbersArray, out int hight, out int low)
    {
        int hightNumber = 0;
        int lowNumber = numbersArray[0];

        foreach (var numberArray in numbersArray)
        {
            if (numberArray > hightNumber)
                hightNumber = numberArray;
            else if (numberArray < lowNumber)
                lowNumber = numberArray;
        }

        hight = hightNumber;
        low = lowNumber;
    }
}
