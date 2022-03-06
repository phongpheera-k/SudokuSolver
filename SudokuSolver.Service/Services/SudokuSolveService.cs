using SudokuSolver.Service.Domains;
using SudokuSolver.Service.Interfaces;

namespace SudokuSolver.Service.Services;

public class SudokuSolveService : ISudokuSolveService
{
    public SudokuBoard InitBoard(int size, Dictionary<Position, int> valueInits)
    {
        var board = new SudokuBoard(size);
        foreach (var (key, value) in valueInits)
        {
            board.SetCellValue(key.Col, key.Row, value);
        }

        return board;
    }

    public void SolveBoard(ref SudokuBoard board)
    {
        throw new NotImplementedException();
    }

    #region Private method


    #endregion
}