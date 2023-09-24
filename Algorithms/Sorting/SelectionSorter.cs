using Algorithms.Helpers;

namespace Algorithms.Sorting;

public static class SelectionSorter
{
    /// <summary>
    /// Selection Sort the List.
    /// <para>Time Complexity - O(n^2)</para>
    /// <para>Space Complexity - O(1)</para>
    /// <para>Stable Sort - Yes</para>
    /// <para>In-place - Yes</para>
    /// </summary>
    /// <param name="comparer">Comparer to compare in a custom order.</param>
    /// <typeparam name="T"></typeparam>
    public static void SelectionSort<T>(this IList<T> list, Comparer<T>? comparer = null) where T : IComparable<T>
    {
        comparer = comparer ?? Comparer<T>.Default;
        int n = list.Count;
        for (int i = 0; i < n; i++)
        {
            int minIdx = i;
            for (int j = i + 1; j < n; j++)
            {
                if (comparer.Compare(list[j], list[minIdx]) < 0)
                {
                    minIdx = j;
                }
            }

            if (minIdx != i) 
            {
                list.Swap(i, minIdx);
            }
        }
    }
}