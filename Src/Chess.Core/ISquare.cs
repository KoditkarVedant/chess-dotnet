namespace Chess.Core
{
    public interface ISquare
    {
        Notation Notation { get; }
        IPiece Piece { get; }

        void SetPiece(IPiece piece);
    }

    public class Square : ISquare
    {
        public Notation Notation { get; }

        public IPiece Piece { get; private set; }

        public Square(Notation notation) : this(notation, null)
        {
        }

        public Square(Notation notation, IPiece piece)
        {
            Notation = notation;
            Piece = piece;
        }

        public void SetPiece(IPiece piece)
        {
            Piece = piece;
        }
    }
}
