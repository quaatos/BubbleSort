class Program
{
    static bool swapped;
    static void Main(string[] args)
    {
        int[] numberArray = numbers();
        
        SortArray(numberArray);
        Console.WriteLine("\n\n\nSorted:");
        foreach (int number in numberArray)
        {
            Console.WriteLine(number);
        }
        Console.ReadKey();
    }

    /// <summary>
    /// Sort the given array of integers
    /// </summary>
    /// <algo>
    /// Create a do while loop which loops until variable swapped is false;
    /// Create for loop which loops trough the array, the length of the array amount of times.
    /// check if the index is greater then index 0;
    /// if so, swap those 2;
    /// </algo>
    private static void SortArray(int[] numbers)
    {
        int arrayLength = numbers.Length;
        int temp;

        do
        {
            swapped = false;

            for (int i = 1; i < arrayLength; i++)
            {
                if (numbers[i - 1] > numbers[i])
                {
                    temp = numbers[i - 1]; //store array index value temporary, used to swap with array index which is lower then it.
                    numbers[i - 1] = numbers[i]; //Put i - 1 on the place of the current array index
                    numbers[i] = temp; //Set the current index as the value of the highest of those two. (Swapping it to rhe right.)
                    swapped = true; //Set swapped to true, if this value isn't changed the length of array amount of times, the program stoppes and apperantly the array is sorted
                }
            }
        } while (swapped);
    }

    /// <summary>
    /// Return an array of integers.
    /// </summary>
    static int[] numbers()
    {
        string intstring;
        int[] intarray;

        Console.WriteLine("Enter integers, seperated by a ,");
        intstring = Console.ReadLine();

        string[] splited = intstring.Split(",");
        intarray = new int[splited.Length];

        for (int i = 0; i < splited.Length; i++) intarray[i] += int.Parse(splited[i]);

        return intarray;
    }
}