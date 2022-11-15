public class Solution {
    public int RomanToInt(string s) {
        Dictionary<char, int> roman = new Dictionary<char, int>();
        roman.Add('I', 1);
        roman.Add('V', 5);
        roman.Add('X', 10);
        roman.Add('L', 50);
        roman.Add('C', 100);
        roman.Add('D', 500);
        roman.Add('M', 1000);

        Queue queue = new Queue();
        int result = 0;
        foreach (var item in s)
        {
            queue.Enqueue(roman[item]);
        }
        while(queue.Count >0)
        {
            int current = (int)queue.Dequeue();
            if (queue.Count > 0)
            {
                int next = (int)queue.Peek();
                if (current < next)
                {
                    result += next - current;
                    queue.Dequeue();
                }
                else
                {
                    result += current;
                }
            }
            else
            {
                result += current;
            }
        }
        return result;
    }
}
