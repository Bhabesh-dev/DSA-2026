import java.lang.reflect.Array;
import java.util.Arrays;

public class ReverseArray {

    public static void main(String[] args) {

        Integer[] input = { 1, 2, 3, 4, 5, 6, 7 };
        System.out.println(Arrays.toString(input));

        int left = 0;
        int right = input.length - 1;

        while (left < right) {

            int temp = input[left];
            input[left] = input[right];
            input[right] = temp;
            left++;
            right--;

        }
        System.out.println(Arrays.toString(input));

    }
}