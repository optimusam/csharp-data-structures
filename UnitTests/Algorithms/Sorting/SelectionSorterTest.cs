using Algorithms.Sorting;
using FluentAssertions;

namespace UnitTests.Algorithms.Sorting;

public class SelectionSorterTest
{    
    
    [Fact]
    public void SelectionSorter_SelectionSortAscending_Integer()
    {
        IList<int> list = new List<int>() { 5, 3, 1, 4, 2 };
        list.SelectionSort();
        list.Should().BeInAscendingOrder();
    }

    [Fact]
    public void SelectionSorter_SelectionSortDescending_Integer()
    {
        IList<int> list = new List<int>() { 5, 3, 1, 4, 2 };
        list.SelectionSort(Comparer<int>.Create((x, y) => y.CompareTo(x)));
        list.Should().BeInDescendingOrder();
    }

    [Fact]
    public void SelectionSorter_SelectionSortAscendingSortedList_Integer()
    {
        IList<int> list = new List<int>() { 1, 2, 3, 4, 5 };
        list.SelectionSort();
        list.Should().BeInAscendingOrder();
    }

    [Fact]
    public void SelectionSorter_SelectionSortAscendingSingleElementList_Integer()
    {
        IList<int> list = new List<int>() { 1 };
        list.SelectionSort();
        list.Should().BeInAscendingOrder();
    }

    [Fact]
    public void SelectionSorter_SelectionSortZToA_String()
    {
        IList<string> list = new List<string>() { "aprajita", "sameer", "Mehul", "Rahul" };
        list.SelectionSort(Comparer<string>.Create((x, y) => String.Compare(y, x, StringComparison.OrdinalIgnoreCase)));
        var expected = new List<string>() { "sameer", "Rahul", "Mehul", "aprajita" };
        list.Should().Equal(expected);
    }

    [Fact]
    public void SelectionSorter_SelectionSortEmptyList_Integer()
    {
        IList<int> list = new List<int>();
        list.SelectionSort();
        list.Should().BeInAscendingOrder();
    }
}