class Program
{
    public static void Main(string[] args)
    {
        int[] numbers = new[] { 1, 2, 3, 55, 56, 78 };
        Console.Write($"AVERAGE: {feature_avg(numbers)}\n");
    }
    
    public static int feature_avg(int[] numbers)
    {
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }

        int avg = sum / numbers.Length;
    
        return avg;
    }
}