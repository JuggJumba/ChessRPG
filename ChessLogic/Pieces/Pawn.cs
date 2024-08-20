using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic
{
    public class Pawn : Piece
    {
        public override PieceType Type => PieceType.Pawn;
        public override Player Colour { get;  }
        public Pawn(Player colour)
        {
            Colour = colour;
        }

        public override Piece Copy()
        {
            Pawn copy = new Pawn(Colour);
            copy.HasMoved = HasMoved;
            return copy;
        }
    }
}
