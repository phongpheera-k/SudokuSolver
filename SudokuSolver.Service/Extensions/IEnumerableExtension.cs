namespace SudokuSolver.Service.Extensions;

// ReSharper disable once InconsistentNaming
public static class IEnumerableExtension
{
    public static void ForEach<T>(this IEnumerable<T> collections, Action<T> action)
    {
        foreach (var item in collections)
        {
            action(item);
        }
    }
}