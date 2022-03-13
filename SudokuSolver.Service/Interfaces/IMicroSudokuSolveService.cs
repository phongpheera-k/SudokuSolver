using SudokuSolver.Service.Domains;

namespace SudokuSolver.Service.Interfaces;

public interface IMicroSudokuSolveService
{
    Position[] GetUniBlock(int col, int row);
    Position[] GetColLine(int col, int row, int size = 9);
    Position[] GetRowLine(int col, int row, int size = 9);

    int[] GetAllPossible(SudokuBoard board, Position position);
}