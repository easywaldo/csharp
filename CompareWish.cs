using System;
using System.Collections.Generic;

public class CompareWish : Comparer<WishList>
{
    public override int Compare(WishList one, WishList other)
    {
        if (one == null || other == null) return 0;

        if (one.Priority > other.Priority)
        {
            return 1;
        }

        if (one.Priority < other.Priority)
        {
            return -1;
        }

        if (one.Priority == other.Priority)
        {
            return 0;
        }

        return 0;
    }
}