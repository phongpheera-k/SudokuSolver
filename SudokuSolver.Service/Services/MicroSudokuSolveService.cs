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
    {
        throw new NotImplementedException();
    }

    public Position[] GetRowLine(int col, int row, int size = 9)
    {
        throw new NotImplementedException();
    }

    public int[] GetAllPossible(SudokuBoard board, Position position)
    {
        throw new NotImplementedException();
    }
}