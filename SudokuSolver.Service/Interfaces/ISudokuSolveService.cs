using SudokuSolver.Service.Domains;

namespace SudokuSolver.Service.Interfaces;

public interface ISudokuSolveService
{
    SudokuBoard InitBoard(int size, Dictionary<Position, int> valueInits);
    void SolveBoard(ref SudokuBoard board);
}