using SudokuSolver.Service.Domains;
using SudokuSolver.Service.Extensions;
using SudokuSolver.Service.Interfaces;

namespace SudokuSolver.Service.Services;

public class SudokuSolveService : ISudokuSolveService
{
    public SudokuBoard InitBoard(int size, Dictionary<Position, int> valueInits)
    {
        var board = new SudokuBoard(size);
        valueInits.ForEach(p =>
        {
            board.SetCellValue(p.Key.Col, p.Key.Row, p.Value);
            board.MemberIncCount(p.Value);
        });

        return board;
    }

    public void SolveBoard(ref SudokuBoard board)
    {
        do
        {
            throw new NotImplementedException();
        } while (board.CountCellAvailable() > 0);
    }

    #region Private method


    #endregion
}