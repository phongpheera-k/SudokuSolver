namespace SudokuSolver.Service.Extensions;

public static class ArrayExtension
{
    public static T[] ToOneDimension<T>(this T[,] array) 
        => Enumerable.Range(0, array.GetLength(0))
            .SelectMany(col => Enumerable.Range(0, array.GetLength(1))
                .Select(row => array[col, row]))
            .ToArray();
}