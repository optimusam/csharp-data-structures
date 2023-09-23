namespace Algorithms.Sorting;

public static class MergeSorter
{
    /// <summary>
    /// Merge Sort the List.
    /// <para>Time Complexity - O(nlogn)</para>
    /// <para>Space Complexity - O(n)</para>
    /// <para>Stable Sort - Yes</para>
    /// <para>In-place - No</para>
    /// </summary>
    /// <param name="comparer">Comparer to compare in a custom order.</param>
    /// <typeparam name="T"></typeparam>
    public static void MergeSort<T>(this IList<T> list, Comparer<T>? comparer = null) where T: IComparable<T>
    {
        comparer = comparer ?? Comparer<T>.Default;
        MergeSort(list, 0, list.Count-1, comparer);
    }

    private static void MergeSort<T>(IList<T> list, int left, int right, Comparer<T> comparer) where T: IComparable<T>
    {
        if (left >= right) return;
        int mid = left + (right - left) / 2;
        MergeSort(list, left, mid, comparer);
        MergeSort(list, mid+1, right, comparer);
        Merge(list, left, mid, right, comparer);
    }

    private static void Merge<T>(IList<T> list, int left, int mid, int right, Comparer<T> comparer) where T: IComparable<T>
    {
        // at this point [left, mid] and [mid+1, right] is sorted.
        // We have to merge them in a sorted list of [left, right].
        IList<T> sortedList = new List<T>();
        int i = left, j = mid + 1;
        while (i <= mid && j <= right)
        {
            if (comparer.Compare(list[i], list[j]) <= 0) 
            {
                sortedList.Add(list[i]);
                i++;
            }
            else
            {
                sortedList.Add(list[j]);
                j++;
            }
        }

        while (i <= mid)
        {
            sortedList.Add(list[i]);
            i++;
        }
        while (j <= right)
        {
            sortedList.Add(list[j]);
            j++;
        }

        for (int k = left, l = 0; k <= right; k++, l++)
        {
            list[k] = sortedList[l];
        }
    }
}

/*
Working 
[5,3,1,4,2] 
[5,3]       |       [1,4,2]
[5] | [3]
merge
[3,5]
[3,5]       |       [1] | [4,2]
                    merge
[3,5]       |       [1] | [4] | [2] 
                    merge
[3,5]       |       [1] | [2,4] 
[3,5]               merge [1,2,4]
merge
[1,2,3,4,5]
*/