class Program
{
    static void Main(string[] args)
    {
        int[] arrayOne = [1, 2, 3];
        int[] arrayTwo = [4, 5, 6];
        Console.WriteLine(String.Join("",MergeSortedArrays(arrayOne, arrayTwo)));
    }

    public static int[] MergeSortedArrays(int[] array1, int[] array2)
    {
        int length1 = array1.Length;
        int length2 = array2.Length;
        int[] result = new int[length1 + length2];
        int index1 = 0;
        int index2 = 0;

        int resultIndex = 0;

        while (index1 < length1 && index2 < length2)
        {
            if (array1[index1] <= array2[index2])
            {
                result[resultIndex] = array1[index1];
                index1++;
            }
            else
            {
                result[resultIndex] = array2[index2];
                index2++;
            }
            resultIndex++;

        }

        while (index1 < length1)
        {
            result[resultIndex] = array1[index1];
            index1++;
            resultIndex++;
        }

        while (index2 < length2)
        {
            result[resultIndex] = array2[index2];
            index2++;
            resultIndex++;
        }

        return result;
    }
}