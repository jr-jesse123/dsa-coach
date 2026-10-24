

namespace TopCoding.Array.Problems.P003_ValidSudoku;

public class Solution
{
    public bool IsValidSudoku(char[][] board)
    {
        HashSet<(char, int)> columSet = new();
        HashSet<(char, int)> rowSet = new();
        HashSet<(char, int row,int col)> squareSet = new();

        for(int row = 0; row < board.Length; row++)
        {
            for(int col = 0; col < board[row].Length; col++) 
            {
                var value = board[row][col];
                if (value == '.') continue;

                var repeated =
                    !columSet.Add((value, row)) ||
                    !rowSet.Add((value, col)) ||
                    !squareSet.Add((value, row /3, col/3));

                if (repeated) return false;
            }
        }

        return true;

    }
}
