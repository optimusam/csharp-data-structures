using Algorithms.Sorting;
using FluentAssertions;

namespace UnitTests.Algorithms.Sorting;

public class QuickSorterTest
{ 
    [Fact]
    public void QuickSorter_QuickSortAscending_Integer()
    {
        IList<int> list = new List<int>() { 5, 3, 1, 4, 2 };
        list.QuickSort();
        list.Should().BeInAscendingOrder();
    }

    [Fact]
    public void QuickSorter_QuickSortDescending_Integer()
    {
        IList<int> list = new List<int>() { 5, 3, 1, 4, 2 };
        list.QuickSort(Comparer<int>.Create((x, y) => y.CompareTo(x)));
        list.Should().BeInDescendingOrder();
    }

    [Fact]
    public void QuickSorter_QuickSortAscendingSortedList_Integer()
    {
        IList<int> list = new List<int>() { 1, 2, 3, 4, 5 };
        list.QuickSort();
        list.Should().BeInAscendingOrder();
    }

    [Fact]
    public void QuickSorter_QuickSortAscendingSingleElementList_Integer()
    {
        IList<int> list = new List<int>() { 1 };
        list.QuickSort();
        list.Should().BeInAscendingOrder();
    }

    [Fact]
    public void QuickSorter_QuickSortZToA_String()
    {
        IList<string> list = new List<string>() { "aprajita", "sameer", "Mehul", "Rahul" };
        list.QuickSort(Comparer<string>.Create((x, y) => String.Compare(y, x, StringComparison.OrdinalIgnoreCase)));
        var expected = new List<string>() { "sameer", "Rahul", "Mehul", "aprajita" };
        list.Should().Equal(expected);
    }

    [Fact]
    public void QuickSorter_QuickSortEmptyList_Integer()
    {
        IList<int> list = new List<int>();
        list.QuickSort();
        list.Should().BeInAscendingOrder();
    }

}