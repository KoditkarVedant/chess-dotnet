// See https://aka.ms/new-console-template for more information
using Chess.Core;
using System.Text;

public static class BoardUIHelper
{
    public static void Render(IBoard board)
    {
        for (int row = board.Rows - 1; row > -1; row--)
        {
            for (int col = 0; col < board.Columns; col++)
            {
                string pieceString = board.Squares[row, col].Piece?.ToString() ?? string.Empty;

                int padding = 12 - pieceString.Length;

                string paddedString = AddPadding(pieceString, padding);

                Console.Write("|" + paddedString + "|");
            }

            Console.WriteLine();
        }
    }

    private static string AddPadding(string str, int padding)
    {
        int paddingLeft = padding % 2 == 1 ? padding / 2 + 1 : padding / 2;
        int paddingRight = padding / 2;

        var sb = new StringBuilder(str.Length + padding);
        sb.Append(' ', paddingLeft);
        sb.Append(str);
        sb.Append(' ', paddingRight);

        return sb.ToString();
    }
}