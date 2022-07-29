using System;

namespace Chess.Core
{
    public enum PieceType
    {
        King,
        Queen,
        Bishop,
        Knight,
        Rook,
        Pawn
    }

    public enum PieceColor
    {
        White,
        Black,
    }

    public interface IPiece
    {
        PieceColor Color { get; }
        PieceType Type { get; }
    }

    public abstract class Piece : IPiece
    {
        public PieceColor Color { get; private set; }

        public PieceType Type { get; private set; }

        protected Piece(PieceColor color, PieceType type)
        {
            Color = color;
            Type = type;
        }

        public override string ToString()
        {
            return $"{Color}-{Type}";
        }
    }

    public class Pawn : Piece, IPiece
    {
        public Pawn(PieceColor color) : base(color, PieceType.Pawn)
        {
        }
    }

    public class King : Piece, IPiece
    {
        public King(PieceColor color) : base(color, PieceType.King)
        {
        }
    }

    public class Queen : Piece, IPiece
    {
        public Queen(PieceColor color) : base(color, PieceType.Queen)
        {
        }
    }

    public class Bishop : Piece, IPiece
    {
        public Bishop(PieceColor color) : base(color, PieceType.Bishop)
        {
        }
    }

    public class Knight : Piece, IPiece
    {
        public Knight(PieceColor color) : base(color, PieceType.Knight)
        {
        }
    }

    public class Rook : Piece, IPiece
    {
        public Rook(PieceColor color) : base(color, PieceType.Rook)
        {
        }
    }
}
