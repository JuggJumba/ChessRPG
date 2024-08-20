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
    }
}
