public class Palindrome {

    public static void main(String[] args) {

        String input = "madam";

        char[] inputArray = input.toCharArray();

        int left = 0;
        int right = inputArray.length - 1;

        while (left < right) {

            if (inputArray[left] != inputArray[right]) {
                System.out.println("not a palindrome");
                break;
            }
            left++;
            right--;

            if (left >= right) {
                System.out.println("Valid Palindrome");

            }

        }
    }
}
