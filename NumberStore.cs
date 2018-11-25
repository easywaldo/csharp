public class NumberStore
{
    int[] numbers = { 1, 2, 3, 4, 5, 6, 7};
    public ref int FindNumber(int target)
    {
        for (int ctr = 0; ctr < numbers.Length; ctr++)
        {
            if (numbers[ctr] >= target)
            {
                return ref numbers[ctr];
            }
        }
        return ref numbers[0];
    }

    public override string ToString() => string.Join(" ", numbers);
}