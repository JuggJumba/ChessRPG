using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic
{
    public class Knight : Piece
    {
        public override PieceType Type => PieceType.Knight;
        public override Player Colour { get; }
        public Knight(Player colour) 
        {
            Colour = colour;
        }

        public override Piece Copy()
        {
            Knight copy = new Knight(Colour);
            copy.HasMoved = HasMoved;
            return copy; 
        }
    }
}
