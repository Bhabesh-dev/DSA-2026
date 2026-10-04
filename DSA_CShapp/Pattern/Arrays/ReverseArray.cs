// Problem: Reverse an array in place.
// Input: [1, 2, 3, 4, 5]
// Output: [5, 4, 3, 2, 1]
public class ReverseArray
{
    public static void run()
    {
        System.Console.WriteLine("Reverse an given array");
        int[] input = { 1, 2, 3, 4, 5, 6 };
        PMReverseArray(input);
    }

    private static void PMReverseArray(int[] input)
    {
        System.Console.WriteLine(string.Join(", ", input));

        int left = 0;
        int right = input.Length - 1;

        while (left < right)
        {
            int temp = input[left];
            input[left] = input[right];
            input[right] = temp;
            left++;
            right--;
        }

        System.Console.WriteLine(string.Join(", ", input));

    }
}