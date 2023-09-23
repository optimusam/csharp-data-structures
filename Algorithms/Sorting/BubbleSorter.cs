using Algorithms.Helpers;

namespace Algorithms.Sorting;

public static class BubbleSorter
{
    /// <summary>
    /// Swaps and bubbles out the greatest element to the rightmost of the array after every iteration.
    /// Time Complexity - O(n^2)
    /// Space Complexity - O(1)
    /// Stable Sort - Yes
    /// In-place - Yes
    /// </summary>
    /// <param name="comparer">Optional param Comparer to compare elements in custom order</param>
    public static void BubbleSort<T>(this IList<T> list, Comparer<T>? comparer = null) where T : IComparable<T>
    {
        comparer = comparer ?? Comparer<T>.Default;
        int n = list.Count;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (comparer.Compare(list[j], list[j + 1]) > 0)
                {
                    list.Swap(j, j + 1);
                }
            }
        }
    }
}

/* Swaps and bubbles out the greatest element to the rightmost of the array.
 * After at most n^2 iterations, the array becomes sorted.
 * [4,3,2,1] -> [3,4,2,1] -> [3,2,4,1] -> [3,2,1,4]
 * [3,2,1,4] -> ... -> [2,1,3,4]
 * [2,1,3,4] -> ... -> [1,2,3,4]
 */