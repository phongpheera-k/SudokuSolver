namespace SudokuSolver.Service.Domains;

public class SudokuBoard
{
    private int Size { get; set; }
    private SudokuCell[,] Cells { get; set; }
    private Dictionary<int,int> Members { get; set; }

    public SudokuBoard(int size)
    {
        Size = size;
        Cells = new SudokuCell[size,size];
        Members = Enumerable.Range(1, size)
            .ToDictionary(r => r,_ => 0);
    }

    #region Manage Cells

    public int? GetCellValue(int col, int row) => Cells[col, row].Value;
    public void SetCellValue(int col, int row, int value) => Cells[col, row].Value = value;
    public Position? GetPosition(int col, int row) => Cells[col, row].Position;
    public void SetPosition(int col, int row) => Cells[col, row].Position = new Position(col, row);
    
    public UniqueList<int> GetPossibility(int col, int row) => Cells[col, row].Possibility;
    public void SetPossibility(int col, int row, UniqueList<int> possibility) =>
        Cells[col, row].Possibility = possibility;
    public void RemovePossibility(int col, int row, int value) => Cells[col, row].Possibility.Remove(value);

    public bool GetHardPossibility(int col, int row) => Cells[col, row].HardPossibility;
    public void SetHardPossibility(int col, int row) => Cells[col, row].HardPossibility = true;

    #endregion

    #region Manage Members

    public void IncCount(int key) => Members[key]++;
    public int[] FindAvailable() => Members.Where(m => m.Value < Size)
        .Select(m => m.Key)
        .ToArray();

    #endregion
}

public class SudokuCell
{
    public int? Value { get; set; }
    public Position? Position { get; set; }
    public UniqueList<int> Possibility { get; set; } = new();
    public bool HardPossibility { get; set; }
}

public class Position
{
    public int Col { get; }
    public int Row { get; }

    public Position(int col, int row)
    {
        Col = col;
        Row = row;
    }

    public override bool Equals(object? obj)
        => obj is Position position
           && Col == position.Col && Row == position.Row;

    public override int GetHashCode() => HashCode.Combine(Col, Row);
}