namespace Algorithms.Helpers;

public static class Helpers
{
    public static void Swap<T>(this IList<T> list, int i, int j)
    {
        (list[i], list[j]) = (list[j], list[i]);
    }
}