namespace ChessLogic
{
    public abstract class Piece
    {
        public abstract PieceType Type { get; }
        public abstract Player Colour { get; }
        public bool HasMoved { get; set; } = false;
        public abstract Piece Copy();

        public abstract IEnumerable<Move> GetMoves(Position from, Board board);

        protected IEnumerable<Position> MovePositionsInDir(Position from, Board board, Direction dir)
        {
            for (Position pos = from + dir; Board.IsInside(pos); pos += dir)
                // starting position is From + the direction; checks if the piece can continue inside the board; if it can, it adds a step
            {
                if (board.IsEmpty(pos))
                {
                    yield return pos;
                    continue;
                }

                Piece piece = board[pos];

                if (piece.Colour != Colour)
                {
                    yield return pos;
                }

                yield break;
            }
        }

        protected IEnumerable<Position> MovePositionsInDirs(Position from, Board board, Direction[] dirs) // method that takes an array of all reachable positions in given directions
        {
            return dirs.SelectMany(dir => MovePositionsInDir(from, board, dir));
        }

        public virtual bool CanCaptureOpponentKing(Position from, Board board)
        {
            return GetMoves(from, board).Any(move =>
            {
                Piece piece = board[move.ToPos];
                return piece != null && piece.Type == PieceType.King;
            });
        }
    }
}
