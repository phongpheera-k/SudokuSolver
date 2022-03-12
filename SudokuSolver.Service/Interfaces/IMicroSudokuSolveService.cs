using SudokuSolver.Service.Domains;

namespace SudokuSolver.Service.Interfaces;

public interface IMicroSudokuSolveService
{
    Position[] GetUniBlock(int col, int row);

    int[] GetAllPossible(SudokuBoard board, Position position);
}