using Algorithms.Sorting;
using FluentAssertions;

namespace UnitTests.Algorithms.Sorting;

public class MergeSorterTest
{
    [Fact]
    public void MergeSorter_MergeSortAscending_Integer()
    {
        IList<int> list = new List<int>() { 5, 3, 1, 4, 2 };
        list.MergeSort();
        list.Should().BeInAscendingOrder();
    }

    [Fact]
    public void MergeSorter_MergeSortDescending_Integer()
    {
        IList<int> list = new List<int>() { 5, 3, 1, 4, 2 };
        list.MergeSort(Comparer<int>.Create((x, y) => y.CompareTo(x)));
        list.Should().BeInDescendingOrder();
    }

    [Fact]
    public void MergeSorter_MergeSortAscendingSortedList_Integer()
    {
        IList<int> list = new List<int>() { 1, 2, 3, 4, 5 };
        list.MergeSort();
        list.Should().BeInAscendingOrder();
    }

    [Fact]
    public void MergeSorter_MergeSortAscendingSingleElementList_Integer()
    {
        IList<int> list = new List<int>() { 1 };
        list.MergeSort();
        list.Should().BeInAscendingOrder();
    }

    [Fact]
    public void MergeSorter_MergeSortZToA_String()
    {
        IList<string> list = new List<string>() { "aprajita", "sameer", "Mehul", "Rahul" };
        list.MergeSort(Comparer<string>.Create((x, y) => String.Compare(y, x, StringComparison.OrdinalIgnoreCase)));
        var expected = new List<string>() { "sameer", "Rahul", "Mehul", "aprajita" };
        list.Should().Equal(expected);
    }

    [Fact]
    public void MergeSorter_MergeSortEmptyList_Integer()
    {
        IList<int> list = new List<int>();
        list.MergeSort();
        list.Should().BeInAscendingOrder();
    }
}