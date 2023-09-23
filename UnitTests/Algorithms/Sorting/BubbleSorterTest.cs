using Algorithms.Sorting;
using FluentAssertions;

namespace UnitTests.Algorithms.Sorting;

public class BubbleSorterTest
{
    [Fact]
    public void BubbleSorter_SortAscending_Integer()
    {
        IList<int> numbers = new List<int>() { 5, 4, 3, 1, 2 };
        numbers.BubbleSort();
        numbers.Should().BeInAscendingOrder();
    }

    [Fact]
    public void BubbleSorter_SortDescending_Integer()
    {
        IList<int> numbers = new List<int>() { 1, 2, 3, 99, 4, 100, -23 };
        var comparer = Comparer<int>.Create((x, y) => y.CompareTo(x));
        numbers.BubbleSort(comparer);
        numbers.Should().BeInDescendingOrder();
    }
}