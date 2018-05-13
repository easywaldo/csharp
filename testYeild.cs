using System.Collections;

public class MyList
{
    private int[] data = { 1,2,3,4,5 };

    public IEnumerator GetEnumerator()
    {
        int i = 0;
        while (i < data.Length)
        {
            yield return data[i];
            i++;
        }
    }
}