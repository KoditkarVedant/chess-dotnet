namespace Chess.Core
{
    public interface ISquare
    {
        Notation Notation { get; }
        IPiece Piece { get; }
    }
}
