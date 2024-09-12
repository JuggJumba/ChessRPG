using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic
{
    public class Rook : Piece
    {
        public override PieceType Type => PieceType.Rook;
        public override Player Colour { get; }
        private static readonly Direction[] dirs = new Direction[]
        {
            Direction.North,
            Direction.South,
            Direction.East,
            Direction.West,
        };
        public Rook(Player colour)
        {
            Colour = colour;
        }

        public override Piece Copy()
        {
            Rook copy = new Rook(Colour);
            copy.HasMoved = HasMoved;
            return copy;
        }
        public override IEnumerable<Move> GetMoves(Position from, Board board)
        {
            return MovePositionsInDirs(from, board, dirs).Select(to => new NormalMove(from, to));
        }
    }
}
