using Algorithms.Sorting;
using FluentAssertions;

namespace UnitTests.Algorithms.Sorting;

public class InsertionSorterTest
{
    [Fact]
    public void InsertionSorter_InsertionSortAscending_Integer()
    {
        IList<int> list = new List<int>() { 5, 3, 1, 4, 2 };
        list.InsertionSort();
        list.Should().BeInAscendingOrder();
    }

    [Fact]
    public void InsertionSorter_InsertionSortDescending_Integer()
    {
        IList<int> list = new List<int>() { 5, 3, 1, 4, 2 };
        list.InsertionSort(Comparer<int>.Create((x, y) => y.CompareTo(x)));
        list.Should().BeInDescendingOrder();
    }

    [Fact]
    public void InsertionSorter_InsertionSortAscendingSortedList_Integer()
    {
        IList<int> list = new List<int>() { 1, 2, 3, 4, 5 };
        list.InsertionSort();
        list.Should().BeInAscendingOrder();
    }

    [Fact]
    public void InsertionSorter_InsertionSortAscendingSingleElementList_Integer()
    {
        IList<int> list = new List<int>() { 1 };
        list.InsertionSort();
        list.Should().BeInAscendingOrder();
    }

    [Fact]
    public void InsertionSorter_InsertionSortZToA_String()
    {
        IList<string> list = new List<string>() { "aprajita", "sameer", "Mehul", "Rahul" };
        list.InsertionSort(Comparer<string>.Create((x, y) => String.Compare(y, x, StringComparison.OrdinalIgnoreCase)));
        var expected = new List<string>() { "sameer", "Rahul", "Mehul", "aprajita" };
        list.Should().Equal(expected);
    }

    [Fact]
    public void InsertionSorter_InsertionSortEmptyList_Integer()
    {
        IList<int> list = new List<int>();
        list.InsertionSort();
        list.Should().BeInAscendingOrder();
    }

}