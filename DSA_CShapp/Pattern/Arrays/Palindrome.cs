public class Palindrome
{
    public static void run()
    {
        string input = "madaam";

        char[] inputString = input.ToArray();
        System.Console.WriteLine(string.Join(", ", inputString));

        int left = 0;
        int right = inputString.Length - 1;
        while (left < right)
        {
            if (inputString[left] != inputString[right])
            {
                System.Console.WriteLine("not a palindrome");
                break;

            }
            left++;
            right--;




        }
        System.Console.WriteLine("Valid");

    }

}