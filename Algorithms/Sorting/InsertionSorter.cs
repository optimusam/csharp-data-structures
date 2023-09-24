namespace Algorithms.Sorting;

public static class InsertionSorter
{
    /// <summary>
    /// Insertion Sort the List.
    /// <para>Time Complexity - O(n^2)</para>
    /// <para>Space Complexity - O(1)</para>
    /// <para>Stable Sort - Yes</para>
    /// <para>In-place - Yes</para>
    /// </summary>
    /// <param name="comparer">Comparer to compare in a custom order.</param>
    /// <typeparam name="T"></typeparam>
    public static void InsertionSort<T>(this IList<T> list, Comparer<T>? comparer = null) where T : IComparable<T>
    {
        comparer = comparer ?? Comparer<T>.Default;
        int n = list.Count;   
        for (int i = 1; i < n; i++)
        {
            var key = list[i];
            int j = i - 1;
            while (j >= 0 && comparer.Compare(list[j], key) > 0)
            {
                list[j + 1] = list[j];
                j--;
            }
            list[j + 1] = key;
        }
    }
}