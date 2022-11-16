public class Solution {
    public string Multiply(string num1, string num2) {
        if (num1 == "0" || num2 == "0") return "0";
        int[] result = new int[num1.Length + num2.Length];
        for (int i = num1.Length - 1; i >= 0; i--) {
            for (int j = num2.Length - 1; j >= 0; j--) {
                int mul = (num1[i] - '0') * (num2[j] - '0');
                int p1 = i + j, p2 = i + j + 1;
                int sum = mul + result[p2];
                result[p1] += sum / 10;
                result[p2] = sum % 10;
            }
        }
        StringBuilder sb = new StringBuilder();
        foreach (int i in result) {
            if (!(sb.Length == 0 && i == 0)) sb.Append(i);
        }
        return sb.ToString();
    }
}