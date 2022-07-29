namespace Chess.Core
{
    public interface IBoard
    {
        int Rows { get; }
        int Columns { get; }
        ISquare[,] Squares { get; }
    }

    public class Board : IBoard
    {
        private const int WHITE_PAWN_ROW = 1;
        private const int BLACK_PAWN_ROW = 6;

        public int Rows => 8;

        public int Columns => 8;

        public ISquare[,] Squares { get; }

        public Board()
        {
            Squares = new Square[8, 8];
            Initialize();
        }

        private void Initialize()
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    Squares[i, j] = new Square((Notation)(i * 10 + j));
                }
            }

            InitializePieces(PieceColor.White, 0);
            InitializePieces(PieceColor.Black, 7);
        }

        private void InitializePieces(PieceColor color, int bigPieceRow)
        {
            Squares[bigPieceRow, 0].SetPiece(new Rook(color));
            Squares[bigPieceRow, 1].SetPiece(new Knight(color));
            Squares[bigPieceRow, 2].SetPiece(new Bishop(color));
            Squares[bigPieceRow, 3].SetPiece(new Queen(color));
            Squares[bigPieceRow, 4].SetPiece(new King(color));
            Squares[bigPieceRow, 5].SetPiece(new Bishop(color));
            Squares[bigPieceRow, 6].SetPiece(new Knight(color));
            Squares[bigPieceRow, 7].SetPiece(new Rook(color));

            int pawnRow = GetPawnRow(color);

            for (int pawnColumn = 0; pawnColumn < Columns; pawnColumn++)
            {
                Squares[pawnRow, pawnColumn].SetPiece(new Pawn(color));
            }
        }

        private int GetPawnRow(PieceColor color)
        {
            return color == PieceColor.White ? WHITE_PAWN_ROW : BLACK_PAWN_ROW;
        }
    }
}
