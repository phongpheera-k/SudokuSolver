using SudokuSolver.Service.Domains;
using SudokuSolver.Service.Interfaces;

namespace SudokuSolver.Service.Services;

public class MicroSudokuSolveService : IMicroSudokuSolveService
{
    public Position[] GetUniBlock(int col, int row)
    {
        var startCol = FindStartPosition(col);
        var startRow = FindStartPosition(row);
        return Enumerable.Range(startCol, 3)
            .SelectMany(c => Enumerable.Range(startRow, 3)
                .Select(r => new Position(c, r)))
            .OrderBy(o => o.Col)
            .ThenBy(o => o.Row)
            .ToArray();

        int FindStartPosition(int input) => (int) Math.Floor((decimal) input / 3) * 3;
    }

    public Position[] GetColLine(int col, int row, int size = 9)
        => Enumerable.Range(0, 9)
            .Select(r => new Position(r, row)).ToArray();

    public Position[] GetRowLine(int col, int row, int size = 9)
        => Enumerable.Range(0, 9)
            .Select(r => new Position(col, r)).ToArray();

    public int[] GetAllPossible(SudokuBoard board, Position position)
    {
        throw new NotImplementedException();
    }
}