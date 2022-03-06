using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using SudokuSolver.Service.Domains;
using SudokuSolver.Service.Extensions;
using SudokuSolver.Service.Services;
using Xunit;

namespace SudokuSolver.Test.Services.MicroSudokuSolve;

public class GetUniBoardTest
{
    private readonly Dictionary<int, Position[]> _resultExpectCase = new ()
    {
        { 0 , new Position[]
        {
            new(0,0), new(0,1), new(0,2),
            new(1,0), new(1,1), new(1,2),
            new(2,0), new(2,1), new(2,2)
        }},
        { 1 , new Position[]
        {
            new(0,3), new(0,4), new(0,5),
            new(1,3), new(1,4), new(1,5),
            new(2,3), new(2,4), new(2,5)
        }},
        { 2 , new Position[]
        {
            new(0,6), new(0,7), new(0,8),
            new(1,6), new(1,7), new(1,8),
            new(2,6), new(2,7), new(2,8)
        }},
        { 3 , new Position[]
        {
            new(3,0), new(3,1), new(3,2),
            new(4,0), new(4,1), new(4,2),
            new(5,0), new(5,1), new(5,2)
        }},
        { 4 , new Position[]
        {
            new(3,3), new(3,4), new(3,5),
            new(4,3), new(4,4), new(4,5),
            new(5,3), new(5,4), new(5,5)
        }},
        { 5 , new Position[]
        {
            new(3,6), new(3,7), new(3,8),
            new(4,6), new(4,7), new(4,8),
            new(5,6), new(5,7), new(5,8)
        }},
        { 6 , new Position[]
        {
            new(6,0), new(6,1), new(6,2),
            new(7,0), new(7,1), new(7,2),
            new(8,0), new(8,1), new(8,2)
        }},
        { 7 , new Position[]
        {
            new(6,3), new(6,4), new(6,5),
            new(7,3), new(7,4), new(7,5),
            new(8,3), new(8,4), new(8,5)
        }},
        { 8 , new Position[]
        {
            new(6,6), new(6,7), new(6,8),
            new(7,6), new(7,7), new(7,8),
            new(8,6), new(8,7), new(8,8)
        }}
    };
    
    [Theory]
    [InlineData(0, 0, 0)]
    [InlineData(2, 4, 1)]
    [InlineData(1, 8, 2)]
    [InlineData(4, 0, 3)]
    [InlineData(3, 3, 4)]
    [InlineData(5, 8, 5)]
    [InlineData(8, 0, 6)]
    [InlineData(7, 4, 7)]
    [InlineData(6, 7, 8)]
    public void GetUniBoard_WithInlineData_ShouldReturnSuccess(int col, int row, int resultExpectKey)
    {
        // Arrange
        var resultExpect = _resultExpectCase[resultExpectKey];
        var service = new MicroSudokuSolveService();
        
        // Act
        var result = service.GetUniBlock(col, row);
        
        // Assert
        result.Length.Should().Be(resultExpect.Length);
        Enumerable.Range(0, result.Length)
            .ForEach(r => result[r].Should().Be(resultExpect[r]));
    }
}