public class Solution {
    public string CountAndSay(int n) {
        if (n == 1) return "1";
        var prev = CountAndSay(n - 1);
        var sb = new StringBuilder();
        var count = 1;
        for (var i = 1; i < prev.Length; i++) {
            if (prev[i] == prev[i - 1]) {
                count++;
            } else {
                sb.Append(count);
                sb.Append(prev[i - 1]);
                count = 1;
            }
        }
        sb.Append(count);
        sb.Append(prev[prev.Length - 1]);
        return sb.ToString();
    }
}