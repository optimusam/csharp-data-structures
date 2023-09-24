using System.Collections.Concurrent;
using Algorithms.Helpers;

namespace Algorithms.Sorting;

/// <summary>
/// Found this thread to have the easiest explanation - https://www.reddit.com/r/explainlikeimfive/comments/lb7w1/eli5_how_in_the_hell_does_quicksort_work/
/// </summary>
public static class QuickSorter
{
    /// <summary>
    /// Quick Sort the List.
    /// <para>Time Complexity - Average: O(nlogn), Worst: O(n^2)</para>
    /// <para>Space Complexity - O(n)</para>
    /// <para>Stable Sort - No</para>
    /// <para>In-place - Yes</para>
    /// </summary>
    /// <param name="comparer">Comparer to compare in a custom order.</param>
    /// <typeparam name="T"></typeparam>
    public static void QuickSort<T>(this IList<T> list, Comparer<T>? comparer = null) where T: IComparable<T>
    {
        comparer = comparer ?? Comparer<T>.Default;
        QuickSort(list, 0, list.Count-1, comparer);
    }

    private static void QuickSort<T>(IList<T> list, int left, int right, Comparer<T> comparer) where T: IComparable<T>
    {
        // there is just one element in the range, so it's already sorted.
        if (left >= right) return;
        // find the pivot element after partitioning and putting pivotElement at it's correct place.
        int pivot = Partition(list, left, right, comparer);
        // Quick sort to the left of pivot.
        QuickSort(list, left, pivot-1, comparer);
        // Quick sort to the right of pivot.
        QuickSort(list, pivot+1, right, comparer);
    }
    
    /// <summary>
    /// Chooses a random pivot element. Places all elements lesser than it to the left and greater than it to the right of the pivot.
    /// </summary>
    /// <param name="left">Denotes the start of the range inclusive</param>
    /// <param name="right">Denotes the end of the range inclusive</param>
    /// <param name="comparer">To compare elements in a custom order</param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    private static int Partition<T>(IList<T> list, int left, int right, Comparer<T> comparer) where T: IComparable<T>
    {
        var random = new Random();
        var pivot = random.Next(left, right+1);
        var pivotElement = list[pivot];
        list.Swap(pivot, right);
        int correctIndexForPivotElement = left;
        for (int i = left; i < right; i++)
        {
            // if list[i] <= pivotElement, then we swap it to left of pivot
            if (comparer.Compare(list[i], pivotElement) <= 0)
            {
                list.Swap(correctIndexForPivotElement, i);
                correctIndexForPivotElement++;
            }
        }
        list.Swap(correctIndexForPivotElement, right);
        return correctIndexForPivotElement;
    }
}